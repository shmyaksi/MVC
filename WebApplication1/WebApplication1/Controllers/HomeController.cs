using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private LinkContext db = new LinkContext();

        public ActionResult Index()
        {
            var allLinks = db.Links.ToList<Links>();
            ViewBag.Links = allLinks;
            return View();
        }

        private void GiveLinks()
        {
            var allCredits = db.Links.ToList<Links>();
            ViewBag.Credits = allCredits;
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult CreateBid()
        {
            var allLinks = db.Links.ToList<Links>();
            ViewBag.Links = allLinks;
            var allBids = db.Bids.ToList<BidLink>();
            ViewBag.Bids = allBids;
            return View();
        }


        [HttpPost]
        public string CreateBid(BidLink newBid)
        {
            db.Bids.Add(newBid);
            db.SaveChanges();
            return "Thanks for helping us";
 }

    }
}