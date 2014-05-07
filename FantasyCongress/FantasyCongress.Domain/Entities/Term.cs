using System;
using Newtonsoft.Json;

namespace FantasyCongress.Domain.Entities
{
    public class Term
    {
        [JsonProperty("start")]
        public DateTime Start { get; set; }
        [JsonProperty("end")]
        public DateTime End { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("party")]
        public char Party { get; set; }
        [JsonProperty("class")]
        public int Class { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("chamber")]
        public string Chamber { get; set; }

    }
}
