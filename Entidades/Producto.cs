using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Producto
    {
        [DataMember]
        public int id_producto { get; set; }

        [DataMember]
        public string descripcion { get; set; }

        [DataMember]
        public string observaciones { get; set; }

        [DataMember]
        public int id_tipo { get; set; }

        [DataMember]
        public int id_marca { get; set; }

        [DataMember]
        public string codigo_barra { get; set; }

    }
}
