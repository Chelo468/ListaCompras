using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Lista_Participantes
    {
        [DataMember]
        public int id_lista { get; set; }

        [DataMember]
        public int id_usuario_participante { get; set; }

        [DataMember]
        public DateTime fecha_alta { get; set; }
    }
}
