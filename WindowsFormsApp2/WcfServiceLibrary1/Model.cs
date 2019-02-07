using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1
{
    public class Model
    {
        [DataMember]
        public string Imie {get;set;}
        [DataMember]
        public DateTimeOffset Data { get; set; }
    }
}
