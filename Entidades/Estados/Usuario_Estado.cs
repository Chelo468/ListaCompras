using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Estados
{
    [Serializable]
    public class Usuario_Estado
    {
        [DataMember]
        public int id_estado { get; set; }

        [DataMember]
        public string descripcion { get; set; }
    }
}
