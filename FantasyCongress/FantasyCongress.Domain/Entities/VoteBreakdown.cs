using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FantasyCongress.Domain.Entities
{
    public class VoteBreakdown
    {
        public Dictionary<string, int> Total { get; set; }
        public Dictionary<string, Dictionary<string, int>> Party { get; set; }
    }
 
}
