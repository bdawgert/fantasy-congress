using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FantasyCongress.Domain.Entities
{
    public class Subcommittee
    {
        public string Name { get; set; }
        [JsonProperty("committee_id")]
        public string CommitteeId { get; set; }
        public string Phone { get; set; }
        public string Chamber { get; set; }
    }
}
