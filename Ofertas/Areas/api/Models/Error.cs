using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ofertas.Areas.api.Models
{
    [Serializable]
    public class Error
    {
        [DataMember]
        public bool error { get; set; }

        [DataMember]
        public string mensaje { get; set; }
    }
}