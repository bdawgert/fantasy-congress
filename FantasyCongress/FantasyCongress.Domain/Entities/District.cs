using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FantasyCongress.Domain.Entities
{
    public class District
    {
        [JsonProperty("district")]
        public int DistrictNumber { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
    }
}
