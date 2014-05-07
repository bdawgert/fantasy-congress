using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FantasyCongress.Domain.Entities
{
    public class Committee
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("committee_id")]
        public string CommitteeId { get; set; }
        [JsonProperty("chamber")]
        public string Chamber { get; set; }
        [JsonProperty("url")]
        public string URL { get; set; }
        [JsonProperty("office")]
        public string Office { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("subcommittee")]
        public bool Subcommittee { get; set; }
        [JsonProperty("member_ids")]
        public IEnumerable<string> MemberIds { get; set; }
        [JsonProperty("members")]
        public IEnumerable<Member> Members { get; set; }
        [JsonProperty("subcommittees")]
        public IEnumerable<Subcommittee> Members { get; set; }
        [JsonProperty("parent_committee_id")]
        public string ParentCommitteeId { get; set; }
        [JsonProperty("parent_committee")]
        public ParentCommittee ParentCommittee { get; set; }
    }
}
