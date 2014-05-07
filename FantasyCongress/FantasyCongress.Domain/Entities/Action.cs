using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FantasyCongress.Domain.Entities
{
    public class Action
    {
        public string Type { get; set; }
        [JsonProperty("acted_at")]
        public DateTime ActedAt { get; set; }
        public string Chamber { get; set; }
        public string How { get; set; }
        [JsonProperty("vote_type")]
        public string VoteType { get; set; }
        public string Result { get; set; }
        [JsonProperty("roll_id")]
        public string RollId { get; set; }
        public string Text { get; set; }
        public IEnumerable<Reference> References { get; set; }

    }
}
