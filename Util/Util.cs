using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Util
    {
        public static List<Object> DataTableToObjectList(DataTable objectTable, Type objectType)
        {
            List<Object> oneList = new List<object>();
            foreach (DataRow row in objectTable.Rows)
            {
                Object obj = loadObject(row, objectType);
                oneList.Add(obj);
            }

            return oneList;
        }

        private static Object loadObject(DataRow row, Type objectType)
        {

            Object obj = null;

            PropertyInfo[] pi = objectType.GetProperties((BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
                .Where(p => Attribute.IsDefined(p, typeof(DataMemberAttribute))).ToArray<PropertyInfo>();

            obj = Activator.CreateInstance(objectType);

            foreach (PropertyInfo infoElement in pi)
            {

                if (row[infoElement.Name] == DBNull.Value)
                {
                    infoElement.SetValue(obj, null, null);

                }
                else
                {
                    infoElement.SetValue(obj, Convert.ChangeType(row[infoElement.Name], Type.GetType(infoElement.PropertyType.FullName)), null);
                }

            }

            return obj;
        }
    }
}
