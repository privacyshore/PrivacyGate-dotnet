using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PrivacyGate.Models
{
   [JsonConverter(typeof(StringEnumConverter), true)]
   public enum ListOrder
   {
      Asc,
      Desc
   }
}