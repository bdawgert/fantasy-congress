using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FantasyCongress.Domain.Entities
{
    public class Vote
    {
        [JsonProperty("roll_id")]
        public string RollId { get; set; }
        public string Chamber { get; set; }
        public int Number { get; set; }
        public int Year { get; set; }
        public int Congress { get; set; }
        [JsonProperty("voted_at")]
        public DateTime VotedAt { get; set; }
        [JsonProperty("vote_type")]
        public string VoteType { get; set; }
        [JsonProperty("roll_type")]
        public string RollType { get; set; }
        public string Question { get; set; }
        public string Required { get; set; }
        public string Result { get; set; }
        public string Source { get; set; }

        public string BillId { get; set; }
        public BillBrief Bill { get; set; }

        [JsonProperty("nomination_id")]
        public string NominationId { get; set; }
        public Nomination Nomination { get; set; }

        [JsonProperty("voter_ids")]
        public Dictionary<string, string> VoterIds { get; set; }
        public Dictionary<string, > Voters { get; set; }
    }
}
