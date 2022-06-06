using Newtonsoft.Json;

namespace PrivacyGate.Models
{
   public partial class Money : Json
   {
      [JsonProperty("amount")]
      public decimal Amount { get; set; }

      [JsonProperty("currency")]
      public string Currency { get; set; }
   }
}