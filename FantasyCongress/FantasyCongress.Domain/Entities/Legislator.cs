using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FantasyCongress.Domain.Entities
{
    public class Legislator : Person
    {
        [JsonProperty("bioguide_id")]
        public string BioGuideId { get; set; }
        [JsonProperty("govtrack_id")]
        public string GovTrackId { get; set; }
        [JsonProperty("crp_id")]
        public string CrpId { get; set; }
        [JsonProperty("icpsr_id")]
        public int IcpsrId { get; set; }
        [JsonProperty("lis_id")]
        public string LisId { get; set; }
        [JsonProperty("ocd_id")]
        public string OcdId { get; set; }
        [JsonProperty("thomas_id")]
        public string ThomasId { get; set; }
        [JsonProperty("votesmart_id")]
        public string VoteSmartId { get; set; }
        [JsonProperty("fec_ids")]
        public IEnumerable<string> FecIds { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("website")]
        public string Website { get; set; }
        [JsonProperty("office")]
        public string Office { get; set; }
        [JsonProperty("contact_form")]
        public string ContactForm { get; set; }
        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("birthday")]
        public DateTime Birthday { get; set; }
        [JsonProperty("chamber")]
        public string Chamber { get; set; }
        [JsonProperty("district")]
        public int? District { get; set; }
        [JsonProperty("gender")]
        public char Gender { get; set; }
        [JsonProperty("in_office")]
        public bool InOffice { get; set; }
        [JsonProperty("party")]
        public char Party { get; set; }
        [JsonProperty("senate_class")]
        public int? SenateClass { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("state_name")]
        public string StateName { get; set; }
        [JsonProperty("state_rank")]
        public string StateRank { get; set; }
        [JsonProperty("term_end")]
        public DateTime TermEnd { get; set; }
        [JsonProperty("term_start")]
        public DateTime TermStart { get; set; }

        [JsonProperty("facebook_id")]
        public string FacebookId { get; set; }
        [JsonProperty("twitter_id")]
        public string TwitterId { get; set; }
        [JsonProperty("youtube_id")]
        public string YouTubeId { get; set; }

    }
}
