using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FantasyCongress.Domain.Entities
{
    public class Upcoming
    {
        public int Congress { get; set; }
        public string Chamber { get; set; }
        [JsonProperty("source_type")]
        public string SourceType { get; set; }
        [JsonProperty("legislative_day")]
        public DateTime LegislativeDay { get; set; }
        public string Range { get; set; }
        public string Context { get; set; }
        public string Url { get; set; }
    }
}
