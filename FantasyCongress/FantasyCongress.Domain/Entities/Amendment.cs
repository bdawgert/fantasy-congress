using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FantasyCongress.Domain.Entities
{
    public class Amendment
    {

        [JsonProperty("amendment_id")]
        public string Id { get; set; }
        [JsonProperty("amendment_type")]
        public string Type { get; set; }
        public int Number { get; set; }
        public int Congress { get; set; }
        public string Chamber { get; set; }
        [JsonProperty("house_number")]
        public int? HouseNumber { get; set; }
        [JsonProperty("introduced_on")]
        public DateTime IntroducedOn { get; set; }
        [JsonProperty("last_action_at")]
        public DateTime LastActionAt { get; set; }

        [JsonProperty("amends_amendment_id")]
        public int? AmendsAmendmentId { get; set; }
        //[JsonProperty("amends_amendment")]
        //public AmendmentSummary { get; set; }

        //[JsonProperty("amends_bill_id")]
        //public string AmendsBillId { get; set; }

        //[JsonProperty("amends_bill")]
        //public BillSummary { get; set; }
        //[JsonProperty("sponsor_type")]
        //public string SponsorType { get; set; }
        //[JsonProperty("sponsor_id")]
        //public string SponsorId { get; set; }
        public Legislator Sponsor { get; set; }

        public string Purpose { get; set; }
        public string Description { get; set; }
    }
}
