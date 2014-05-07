using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FantasyCongress.Domain.Entities
{
    public class UrlSet
    {
        public string Congress { get; set; }
        public string GovTrack { get; set; }
        public string OpenCongress { get; set; }
    }
}
