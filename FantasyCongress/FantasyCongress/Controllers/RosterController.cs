using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FantasyCongress.Domain.Concrete;
using FantasyCongress.Domain.Entities;

namespace FantasyCongress.Controllers
{
    public class RosterController : Controller
    {
        //
        // GET: /Roster/

        public ActionResult Index()
        {

            //http://theunitedstates.io/images/congress/[size]/[bioguide].jpg

            APILegislatorRepository repo = new APILegislatorRepository();
            Legislator l = repo.GetLegislator("K000384");
            return View(l);

        }

        public ActionResult List()
        {

            //http://theunitedstates.io/images/congress/[size]/[bioguide].jpg

            APILegislatorRepository repo = new APILegislatorRepository();
            IEnumerable<Legislator> legislators = repo.Legislators;
            return View(legislators);

        }

    }
}
