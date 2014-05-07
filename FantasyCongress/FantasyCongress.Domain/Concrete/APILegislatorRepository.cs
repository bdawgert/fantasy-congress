using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FantasyCongress.Domain;
using FantasyCongress.Domain.Entities;

namespace FantasyCongress.Domain.Concrete
{
    public class APILegislatorRepository
    {

        private string apikey = "ac12522a36d24a4288cacdb972dc64f2";

        public Legislator GetLegislator(string bioguideId) { 
        
            WebClient client = new WebClient();
            //client.
            string url = String.Format("http://congress.api.sunlightfoundation.com/legislators?bioguide_id={0}&apikey={1}", bioguideId, apikey);
            string resultJson = client.DownloadString(url);

            Wrapper<Legislator> result = JsonConvert.DeserializeObject <Wrapper<Legislator>>(resultJson);

            return result.Results.First();

        
        }



    }
}
