using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Web_API_Core.Model
{
    [DataContract]
    public class Test
    {
        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "fname")]
        public string firstname { get; set; }

        [DataMember(Name = "lname")]
        public string lastname { get; set; }

        [DataMember(Name = "email")]
        public string email { get; set; }

    }
}
