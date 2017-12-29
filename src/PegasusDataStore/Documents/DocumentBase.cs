using System;
using Newtonsoft.Json;

namespace PegasusDataStore.Documents
{
    public class DocumentBase
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        [JsonIgnore]
        public string ETag { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
