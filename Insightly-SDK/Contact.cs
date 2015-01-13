using System.Collections.Generic;
using Newtonsoft.Json;

namespace InsightlySDK
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Contact
    {
        public Contact() { }

        [JsonProperty(PropertyName = "CONTACT_ID", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty(PropertyName = "SALUTATION", NullValueHandling = NullValueHandling.Ignore)]
        public string Salutation { get; set; }

        [JsonProperty(PropertyName = "FIRST_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "LAST_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos"), JsonProperty(PropertyName = "CONTACTINFOS", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ContactInfo> ContactInfos { get; set; }
    }
}