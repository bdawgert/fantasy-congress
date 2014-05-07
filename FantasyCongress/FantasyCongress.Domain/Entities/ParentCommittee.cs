using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FantasyCongress.Domain.Entities
{
    public class ParentCommittee
    {
        [JsonProperty("committee_id")]
        public string CommitteeId { get; set; }
        public string Name { get; set; }
        public string Chamber { get; set; }
        public string Website { get; set; }
        public string Office { get; set; }
        public string Phone { get; set; }

    }
}
