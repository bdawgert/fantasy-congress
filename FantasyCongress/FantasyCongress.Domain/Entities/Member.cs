using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyCongress.Domain.Entities
{
    public class Member
    {
        public string Side { get; set; }
        public int Rank { get; set; }
        public string Title { get; set; }
        public Legislator Legislator { get; set; }
    }
}
