using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace INSAT.OneM2MCommunication.Models
{
    public class M2MApplicationEntity
    {
        [JsonProperty("rn")]
        [JsonPropertyName("rn")]
        public required string ResourceName { get; set; }

        [JsonProperty("api")]
        [JsonPropertyName("api")]
        public required string ApplicationId { get; set; }

        [JsonProperty("rr")]
        [JsonPropertyName("rr")]
        public bool RequestReachability { get; set; }

        [JsonProperty("srv")]
        [JsonPropertyName("srv")]
        public required List<string> SupportedReleaseVersions { get; set; }
    }

    public class M2MContainer
    {
        [JsonProperty("rn")]
        [JsonPropertyName("rn")]
        public required string ResourceName { get; set; }
    }

    public class RootContainerCreate
    {
        [JsonProperty("m2m:cnt")]
        [JsonPropertyName("m2m:cnt")]
        public required M2MContainer Container { get; set; }
    }

    public class RootApplicationEntityCreate
    {
        [JsonProperty("m2m:ae")]
        [JsonPropertyName("m2m:ae")]
        public M2MApplicationEntity? ApplicationEntity { get; set; }
    }
}
