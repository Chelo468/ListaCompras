using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Marca_Producto
    {
        [DataMember]
        public int id_marca { get; set; }

        [DataMember]
        public string descripcion { get; set; }
    }
}
