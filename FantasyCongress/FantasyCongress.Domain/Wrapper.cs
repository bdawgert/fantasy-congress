using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FantasyCongress.Domain
{
    public class Wrapper<T>
    {
        [JsonProperty("results")]
        public IEnumerable<T> Results { get; set; }
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("page")]
        public Page Page { get; set; }
    }
}
