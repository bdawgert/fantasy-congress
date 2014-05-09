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
        public string Name { get; set; }
        [JsonProperty("committee_id")]
        public string CommitteeId { get; set; }
        public string Chamber { get; set; }
        public string URL { get; set; }
        public string Office { get; set; }
        public string Phone { get; set; }
        public bool Subcommittee { get; set; }
        [JsonProperty("member_ids")]
        public IEnumerable<string> MemberIds { get; set; }
        public IEnumerable<Member> Members { get; set; }
        public IEnumerable<Subcommittee> Subcommittees { get; set; }
        [JsonProperty("parent_committee_id")]
        public string ParentCommitteeId { get; set; }
        [JsonProperty("parent_committee")]
        public ParentCommittee ParentCommittee { get; set; }
    }
}
