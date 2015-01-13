using Newtonsoft.Json;

namespace InsightlySDK
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ContactInfo
    {
        [JsonProperty(PropertyName = "CONTACT_INFO_ID")]
        public int? Id { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty(PropertyName = "TYPE")]
        public string ContactType { get; set; }

        [JsonProperty(PropertyName = "SUBTYPE")]
        public string ContactSubtype { get; set; }

        [JsonProperty(PropertyName = "LABEL")]
        public string Label { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty(PropertyName = "DETAIL")]
        public string Detail { get; set; }
    }
}