using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FantasyCongress.Domain.Entities
{
    public class Nomination
    {
        public string Organization { get; set; }
        [JsonProperty("received_on")]
        public DateTime ReceivedOn { get; set; }
        public IEnumerable<Nominee> Nominees { get; set; }

    }
}
