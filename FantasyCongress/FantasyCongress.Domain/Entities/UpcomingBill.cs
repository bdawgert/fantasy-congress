using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FantasyCongress.Domain.Entities
{
    public class UpcomingBill : Upcoming
    {
        [JsonProperty("bill_id")]
        public int BillId { get; set; }
        
        [JsonProperty("scheduled_at")]
        public DateTime ScheduledAt { get; set; }

        public BillBrief Bill { get; set; }

}
