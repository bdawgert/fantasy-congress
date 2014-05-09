using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FantasyCongress.Domain
{
    public class Page
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("per_page")]
        public int? PerPage { get; set; }
        [JsonProperty("page")]
        public int? PageNumber { get; set; }
    }
}
