using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FetchData
{
    public class TestClass
    {
        [JsonProperty("infected")]
        public int infected { get; set; }
        [JsonProperty("tested")]
        public int tested { get; set; }
        [JsonProperty("recovered")]
        public int recovered { get; set; }
        [JsonProperty("deceased")]
        public int deceased { get; set; }
        [JsonProperty("activeCases")]
        public int activeCases { get; set; }
        [JsonProperty("unique")]
        public int unique { get; set; }
        [JsonProperty("country")]
        public string country { get; set; }
    }
}
