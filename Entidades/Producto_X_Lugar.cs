using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Producto_X_Lugar
    {
        [DataMember]
        public int id_producto { get; set; }

        [DataMember]
        public int id_lugar { get; set; }

        [DataMember]
        public decimal precio { get; set; }

        [DataMember]
        public DateTime fecha_alta { get; set; }

        [DataMember]
        public DateTime fecha_ultima_modif { get; set; }
    }
}
