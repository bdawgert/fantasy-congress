using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FantasyCongress.Domain.Entities
{
    public class BillHistory
    {
        public bool Active { get; set; }
        [JsonProperty("active_at")]
        public DateTime ActiveAt { get; set; }
        [JsonProperty("awaiting_signature")]
        public bool AwaitingSignature { get; set; }
        public bool Enacted { get; set; }
        [JsonProperty("enacted_at")]
        public DateTime EnactedAt { get; set; }
        public bool Vetoed { get; set; }

        [JsonProperty("house_passage_result")]
        public string HousePassageResult { get; set; }
        [JsonProperty("house_passage_result_at")]
        public DateTime HousePassageResultAt { get; set; }
        [JsonProperty("senate_cloture_result")]
        public string SenateClotureResult { get; set; }
        [JsonProperty("senate_cloture_result_at")]
        public DateTime SenateClotureResultAt { get; set; }
        [JsonProperty("senate_passage_result")]
        public string SenatePassageResult { get; set; }
        [JsonProperty("senate_passage_result_at")]
        public DateTime SenatePassageResultAt { get; set; }

    }
}
