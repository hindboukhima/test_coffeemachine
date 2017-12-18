using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;


namespace WCF_BD
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int id_customer { get; set; }

        [DataMember]
        public string type_drink { get; set; }

        [DataMember]
        public int qtSucre { get; set; }

        [DataMember]
        public byte mug { get; set; }

    }
}