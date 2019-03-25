using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Lista
    {
        [DataMember]
        public int id_lista { get; set; }

        [DataMember]
        public string nombre { get; set; }

        [DataMember]
        public DateTime fecha_alta { get; set; }

        [DataMember]
        public DateTime fecha_vencimiento { get; set; }

        [DataMember]
        public int id_usuario_alta { get; set; }

        [DataMember]
        public int id_estado { get; set; }
    }
}
