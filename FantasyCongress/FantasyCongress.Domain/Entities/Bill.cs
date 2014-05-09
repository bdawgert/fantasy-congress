using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FantasyCongress.Domain.Entities
{
    public class Bill
    {
        [JsonProperty("bill_id")]
        public string Id { get; set; }
        [JsonProperty("bill_type")]
        public char Type { get; set; }
        public string Chamber { get; set; }
        public int Number { get; set; }
        public int Congress { get; set; }

        public BillHistory History { get; set; }
        [JsonProperty("introduced_on")]
        public DateTime IntroducedOn { get; set; }
        [JsonProperty("last_action_at")]
        public DateTime LastActionAt { get; set; }
        [JsonProperty("last_version_on")]
        public DateTime LastVersionOn { get; set; }
        [JsonProperty("last_vote_at")]
        public DateTime LastVoteAt { get; set; }

        [JsonProperty("enacted_as")]
        public string EnactedAs { get; set; }
        [JsonProperty("official_title")]
        public string OfficialTitle { get; set; }
        [JsonProperty("popular_title")]
        public string PopularTitle { get; set; }
        [JsonProperty("short_title")]
        public string ShortTitle { get; set; }
        public IEnumerable<BillTitle> Titles { get; set; }
        public IEnumerable<string> Nicknames { get; set; }

        [JsonProperty("committee_ids")]
        public IEnumerable<string> CommitteeIds { get; set; }
        [JsonProperty("related_bill_ids")]
        public IEnumerable<string> RelatedBillIds { get; set; }
        [JsonProperty("cosponsors_count")]
        public int CosponsorsCount { get; set; }
        [JsonProperty("withdrawn_cosponsors_count")]
        public int WithdrawnCosponsorsCount { get; set; }

        public Person Sponsor { get; set; }
        [JsonProperty("sponsor_id")]
        public string SponsorId { get; set; }

        public UrlSet Urls { get; set; }

        public IEnumerable<string> Keywords { get; set; }
        public string Summary { get; set; }
        [JsonProperty("summary_short")]
        public string ShortSummary { get; set; }

        public IEnumerable<Action> Actions { get; set; }
        public IEnumerable<Action> Votes { get; set; }
        //public IEnumerable<BillSponsorship> Sponsorships { get; set; }
        public IEnumerable<Committee> Committees { get; set; }
        //public IEnumerable<BillVersion> Versions { get; set; }
        //[JsonProperty("last_version")]
        //public BillVersion LastVersion { get; set; }
        [JsonProperty("upcoming")]
        public IEnumerable<UpcomingDebate> UpcomingDebate { get; set; }
        //[JsonProperty("enacted_as")]
        //public EnactedLaw EnactedAs { get; set; }
    }
}
