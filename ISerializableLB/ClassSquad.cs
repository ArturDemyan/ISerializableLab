using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ISerializableLB
{
    //[Serializable]
    public class ClassSquad : ISerializable
    {
        [JsonPropertyName("squadName")]
        public string SquadName { get; set; }
        [JsonPropertyName("homeTown")]
        public string HomeTown { get; set; }
        [JsonPropertyName("formed")]
        public int Formed {  get; set; }
        [JsonPropertyName("secretBase")]
        public string SecretBase { get; set; }
        [JsonPropertyName("active")]
        public bool Active { get; set; }
        [JsonPropertyName("members")]
        public List<Members> MembersList { get; set; }  

        public ClassSquad() { }
 

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
