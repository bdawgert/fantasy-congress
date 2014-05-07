using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FantasyCongress.Domain.Entities
{
    public class Person
    {

        public string Title { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        [JsonProperty("name_suffix")]
        public string NameSuffix { get; set; }
        public string Nickname { get; set; }
    }
}
