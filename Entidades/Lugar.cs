using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Lugar
    {
        [DataMember]
        public int id_lugar { get; set; }

        [DataMember]
        public string descripcion { get; set; }

        [DataMember]
        public string observaciones { get; set; }
    }
}
