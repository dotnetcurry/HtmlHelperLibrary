using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetCurry.HtmlHelpers.WebHarness.Models;

namespace DotNetCurry.HtmlHelpers.WebHarness.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Creating your own HtmlHelper library";
            TwoDimensionalData data = new TwoDimensionalData();
            data.Data.Add(new int[] { 2007, 23045 });
            data.Data.Add(new int[] { 2008, 20345 });
            data.Data.Add(new int[] { 2009, 23405 });
            data.Data.Add(new int[] { 2010, 23425 });
            data.Data.Add(new int[] { 2011, 21345 });
            data.Data.Add(new int[] { 2012, 32345 });
            data.Data.Add(new int[] { 2013, 48345 });
            data.Data.Add(new int[] { 2014, 62345 });
            data.Data.Add(new int[] { 2015, 72345 });
            data.Data.Add(new int[] { 2016, 82345 });
            data.Data.Add(new int[] { 2017, 89345 });
            data.Data.Add(new int[] { 2018, 92345 });
            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
