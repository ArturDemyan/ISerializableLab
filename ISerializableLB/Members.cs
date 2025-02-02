using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ISerializableLB
{
    public class Members
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }

        [JsonPropertyName("secretIdentity")]
        public string SecretIdentity { get; set; }
        
        [JsonPropertyName("powers")]
        public List<string> Powers { get; set; }

    }
}
