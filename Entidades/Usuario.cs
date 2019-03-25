using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Usuario
    {
        [DataMember]
        public int id_usuario { get; set; }

        [DataMember]
        public string nombre_usuario { get; set; }

        [DataMember]
        public string password { get; set; }

        [DataMember]
        public string telefono { get; set; }

        [DataMember]
        public string password_recovery { get; set; }

        [DataMember]
        public DateTime fecha_alta { get; set; }

        [DataMember]
        public DateTime fecha_recovery { get; set; }

        [DataMember]
        public int id_estado { get; set; }

        [DataMember]
        public string calle { get; set; }

        [DataMember]
        public string calle_nro { get; set; }
    }
}
