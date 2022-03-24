using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebScrapping.Models;
using HtmlAgilityPack;

namespace WebScrapping.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://hptenders.gov.in/nicgep/app");
            var trOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='odd']").ToList();
            var trEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']").ToList();
            var tdOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='odd']//td").ToList();
            var tdEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td").ToList();
            var aOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td//a[@href]").ToList();
            var aEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td//a[@href]").ToList();
            ViewBag.TenderOdd = trOdd;
            ViewBag.TenderEven = trEven;
            ViewBag.TenderTdOdd = tdOdd;
            ViewBag.TenderTdEven = tdEven;
            
            List<string> aOddN = new List<string>();
            List<string> aEvenN = new List<string>();
            foreach (HtmlNode link in aOdd)
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty).Split(new[] { "component=" }, StringSplitOptions.None)[1].Replace("amp;","");
                aOddN.Add("https://hptenders.gov.in/nicgep/app?component=" + hrefValue);
            }
            foreach (HtmlNode link in aEven)
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty).Split(new[] { "component=" }, StringSplitOptions.None)[1].Replace("amp;", ""); 
                aEvenN.Add("https://hptenders.gov.in/nicgep/app?component=" + hrefValue);
            }
            ViewBag.TenderaOdd = aOddN;
            ViewBag.TenderaEven = aEvenN;
            return View();
        }
        public IActionResult J_K()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://jktenders.gov.in/nicgep/app");
            var trOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='odd']").ToList();
            var trEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']").ToList();
            var tdOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='odd']//td").ToList();
            var tdEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td").ToList();
            var aOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td//a[@href]").ToList();
            var aEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td//a[@href]").ToList();
            ViewBag.TenderOdd = trOdd;
            ViewBag.TenderEven = trEven;
            ViewBag.TenderTdOdd = tdOdd;
            ViewBag.TenderTdEven = tdEven;

            List<string> aOddN = new List<string>();
            List<string> aEvenN = new List<string>();
            foreach (HtmlNode link in aOdd)
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty).Split(new[] { "component=" }, StringSplitOptions.None)[1].Replace("amp;", "");
                aOddN.Add("https://jktenders.gov.in/nicgep/app?component=" + hrefValue);
            }
            foreach (HtmlNode link in aEven)
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty).Split(new[] { "component=" }, StringSplitOptions.None)[1].Replace("amp;", "");
                aEvenN.Add("https://jktenders.gov.in/nicgep/app?component=" + hrefValue);
            }
            ViewBag.TenderaOdd = aOddN;
            ViewBag.TenderaEven = aEvenN;
            return View();
        }
        public IActionResult Punjab()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://eproc.punjab.gov.in/nicgep/app");
            var trOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='odd']").ToList();
            var trEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']").ToList();
            var tdOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='odd']//td").ToList();
            var tdEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td").ToList();
            var aOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td//a[@href]").ToList();
            var aEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td//a[@href]").ToList();
            ViewBag.TenderOdd = trOdd;
            ViewBag.TenderEven = trEven;
            ViewBag.TenderTdOdd = tdOdd;
            ViewBag.TenderTdEven = tdEven;

            List<string> aOddN = new List<string>();
            List<string> aEvenN = new List<string>();
            foreach (HtmlNode link in aOdd)
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty).Split(new[] { "component=" }, StringSplitOptions.None)[1].Replace("amp;", "");
                aOddN.Add("https://eproc.punjab.gov.in/nicgep/app?component=" + hrefValue);
            }
            foreach (HtmlNode link in aEven)
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty).Split(new[] { "component=" }, StringSplitOptions.None)[1].Replace("amp;", "");
                aEvenN.Add("https://eproc.punjab.gov.in/nicgep/app?component=" + hrefValue);
            }
            ViewBag.TenderaOdd = aOddN;
            ViewBag.TenderaEven = aEvenN;
            return View();
        }
        public IActionResult Haryana()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://etenders.hry.nic.in/nicgep/app");
            var trOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='odd']").ToList();
            var trEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']").ToList();
            var tdOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='odd']//td").ToList();
            var tdEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td").ToList();
            var aOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td//a[@href]").ToList();
            var aEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td//a[@href]").ToList();
            ViewBag.TenderOdd = trOdd;
            ViewBag.TenderEven = trEven;
            ViewBag.TenderTdOdd = tdOdd;
            ViewBag.TenderTdEven = tdEven;

            List<string> aOddN = new List<string>();
            List<string> aEvenN = new List<string>();
            foreach (HtmlNode link in aOdd)
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty).Split(new[] { "component=" }, StringSplitOptions.None)[1].Replace("amp;", "");
                aOddN.Add("https://etenders.hry.nic.in/nicgep/app?component=" + hrefValue);
            }
            foreach (HtmlNode link in aEven)
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty).Split(new[] { "component=" }, StringSplitOptions.None)[1].Replace("amp;", "");
                aEvenN.Add("https://etenders.hry.nic.in/nicgep/app?component=" + hrefValue);
            }
            ViewBag.TenderaOdd = aOddN;
            ViewBag.TenderaEven = aEvenN;
            return View();
        }
        public IActionResult Delhi()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://govtprocurement.delhi.gov.in/nicgep/app");
            var trOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='odd']").ToList();
            var trEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']").ToList();
            var tdOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='odd']//td").ToList();
            var tdEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td").ToList();
            var aOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td//a[@href]").ToList();
            var aEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td//a[@href]").ToList();
            ViewBag.TenderOdd = trOdd;
            ViewBag.TenderEven = trEven;
            ViewBag.TenderTdOdd = tdOdd;
            ViewBag.TenderTdEven = tdEven;

            List<string> aOddN = new List<string>();
            List<string> aEvenN = new List<string>();
            foreach (HtmlNode link in aOdd)
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty).Split(new[] { "component=" }, StringSplitOptions.None)[1].Replace("amp;", "");
                aOddN.Add("https://govtprocurement.delhi.gov.in/nicgep/app?component=" + hrefValue);
            }
            foreach (HtmlNode link in aEven)
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty).Split(new[] { "component=" }, StringSplitOptions.None)[1].Replace("amp;", "");
                aEvenN.Add("https://govtprocurement.delhi.gov.in/nicgep/app?component=" + hrefValue);
            }
            ViewBag.TenderaOdd = aOddN;
            ViewBag.TenderaEven = aEvenN;
            return View();
        }
        public IActionResult Rajasthan()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://eproc.rajasthan.gov.in/nicgep/app");
            var trOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='odd']").ToList();
            var trEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']").ToList();
            var tdOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='odd']//td").ToList();
            var tdEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td").ToList();
            var aOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td//a[@href]").ToList();
            var aEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td//a[@href]").ToList();
            ViewBag.TenderOdd = trOdd;
            ViewBag.TenderEven = trEven;
            ViewBag.TenderTdOdd = tdOdd;
            ViewBag.TenderTdEven = tdEven;

            List<string> aOddN = new List<string>();
            List<string> aEvenN = new List<string>();
            foreach (HtmlNode link in aOdd)
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty).Split(new[] { "component=" }, StringSplitOptions.None)[1].Replace("amp;", "");
                aOddN.Add("https://eproc.rajasthan.gov.in/nicgep/app?component=" + hrefValue);
            }
            foreach (HtmlNode link in aEven)
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty).Split(new[] { "component=" }, StringSplitOptions.None)[1].Replace("amp;", "");
                aEvenN.Add("https://eproc.rajasthan.gov.in/nicgep/app?component=" + hrefValue);
            }
            ViewBag.TenderaOdd = aOddN;
            ViewBag.TenderaEven = aEvenN;
            return View();
        }
        public IActionResult UP()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://etender.up.nic.in/nicgep/app");
            var trOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='odd']").ToList();
            var trEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']").ToList();
            var tdOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='odd']//td").ToList();
            var tdEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td").ToList();
            var aOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td//a[@href]").ToList();
            var aEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td//a[@href]").ToList();
            ViewBag.TenderOdd = trOdd;
            ViewBag.TenderEven = trEven;
            ViewBag.TenderTdOdd = tdOdd;
            ViewBag.TenderTdEven = tdEven;

            List<string> aOddN = new List<string>();
            List<string> aEvenN = new List<string>();
            foreach (HtmlNode link in aOdd)
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty).Split(new[] { "component=" }, StringSplitOptions.None)[1].Replace("amp;", "");
                aOddN.Add("https://etender.up.nic.in/nicgep/app?component=" + hrefValue);
            }
            foreach (HtmlNode link in aEven)
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty).Split(new[] { "component=" }, StringSplitOptions.None)[1].Replace("amp;", "");
                aEvenN.Add("https://etender.up.nic.in/nicgep/app?component=" + hrefValue);
            }
            ViewBag.TenderaOdd = aOddN;
            ViewBag.TenderaEven = aEvenN;
            return View();
        }
        public IActionResult Maharashtra()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://mahatenders.gov.in/nicgep/app");
            var trOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='odd']").ToList();
            var trEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']").ToList();
            var tdOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='odd']//td").ToList();
            var tdEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td").ToList();
            var aOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td//a[@href]").ToList();
            var aEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td//a[@href]").ToList();
            ViewBag.TenderOdd = trOdd;
            ViewBag.TenderEven = trEven;
            ViewBag.TenderTdOdd = tdOdd;
            ViewBag.TenderTdEven = tdEven;

            List<string> aOddN = new List<string>();
            List<string> aEvenN = new List<string>();
            foreach (HtmlNode link in aOdd)
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty).Split(new[] { "component=" }, StringSplitOptions.None)[1].Replace("amp;", "");
                aOddN.Add("https://mahatenders.gov.in/nicgep/app?component=" + hrefValue);
            }
            foreach (HtmlNode link in aEven)
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty).Split(new[] { "component=" }, StringSplitOptions.None)[1].Replace("amp;", "");
                aEvenN.Add("https://mahatenders.gov.in/nicgep/app?component=" + hrefValue);
            }
            ViewBag.TenderaOdd = aOddN;
            ViewBag.TenderaEven = aEvenN;
            return View();
        }
        public IActionResult MP()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://mptenders.gov.in/nicgep/app");
            var trOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='odd']").ToList();
            var trEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']").ToList();
            var tdOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='odd']//td").ToList();
            var tdEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td").ToList();
            var aOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td//a[@href]").ToList();
            var aEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td//a[@href]").ToList();
            ViewBag.TenderOdd = trOdd;
            ViewBag.TenderEven = trEven;
            ViewBag.TenderTdOdd = tdOdd;
            ViewBag.TenderTdEven = tdEven;

            List<string> aOddN = new List<string>();
            List<string> aEvenN = new List<string>();
            foreach (HtmlNode link in aOdd)
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty).Split(new[] { "component=" }, StringSplitOptions.None)[1].Replace("amp;", "");
                aOddN.Add("https://mptenders.gov.in/nicgep/app?component=" + hrefValue);
            }
            foreach (HtmlNode link in aEven)
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty).Split(new[] { "component=" }, StringSplitOptions.None)[1].Replace("amp;", "");
                aEvenN.Add("https://mptenders.gov.in/nicgep/app?component=" + hrefValue);
            }
            ViewBag.TenderaOdd = aOddN;
            ViewBag.TenderaEven = aEvenN;
            return View();
        }
        public IActionResult TN()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://tntenders.gov.in/nicgep/app");
            var trOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='odd']").ToList();
            var trEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']").ToList();
            var tdOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='odd']//td").ToList();
            var tdEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td").ToList();
            var aOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td//a[@href]").ToList();
            var aEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td//a[@href]").ToList();
            ViewBag.TenderOdd = trOdd;
            ViewBag.TenderEven = trEven;
            ViewBag.TenderTdOdd = tdOdd;
            ViewBag.TenderTdEven = tdEven;

            List<string> aOddN = new List<string>();
            List<string> aEvenN = new List<string>();
            foreach (HtmlNode link in aOdd)
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty).Split(new[] { "component=" }, StringSplitOptions.None)[1].Replace("amp;", "");
                aOddN.Add("https://tntenders.gov.in/nicgep/app?component=" + hrefValue);
            }
            foreach (HtmlNode link in aEven)
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty).Split(new[] { "component=" }, StringSplitOptions.None)[1].Replace("amp;", "");
                aEvenN.Add("https://tntenders.gov.in/nicgep/app?component=" + hrefValue);
            }
            ViewBag.TenderaOdd = aOddN;
            ViewBag.TenderaEven = aEvenN;
            return View();
        }
        public IActionResult Puducherry()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://pudutenders.gov.in/nicgep/app");
            var trOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='odd']").ToList();
            var trEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']").ToList();
            var tdOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='odd']//td").ToList();
            var tdEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td").ToList();
            var aOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td//a[@href]").ToList();
            var aEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td//a[@href]").ToList();
            ViewBag.TenderOdd = trOdd;
            ViewBag.TenderEven = trEven;
            ViewBag.TenderTdOdd = tdOdd;
            ViewBag.TenderTdEven = tdEven;

            List<string> aOddN = new List<string>();
            List<string> aEvenN = new List<string>();
            foreach (HtmlNode link in aOdd)
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty).Split(new[] { "component=" }, StringSplitOptions.None)[1].Replace("amp;", "");
                aOddN.Add("https://pudutenders.gov.in/nicgep/app?component=" + hrefValue);
            }
            foreach (HtmlNode link in aEven)
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty).Split(new[] { "component=" }, StringSplitOptions.None)[1].Replace("amp;", "");
                aEvenN.Add("https://pudutenders.gov.in/nicgep/app?component=" + hrefValue);
            }
            ViewBag.TenderaOdd = aOddN;
            ViewBag.TenderaEven = aEvenN;
            return View();
        }
        public IActionResult Puducherry()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://pudutenders.gov.in/nicgep/app");
            var trOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='odd']").ToList();
            var trEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']").ToList();
            var tdOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='odd']//td").ToList();
            var tdEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td").ToList();
            var aOdd = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td//a[@href]").ToList();
            var aEven = doc.DocumentNode.SelectNodes("//table[@class='list_table']//tr[@class='even']//td//a[@href]").ToList();
            ViewBag.TenderOdd = trOdd;
            ViewBag.TenderEven = trEven;
            ViewBag.TenderTdOdd = tdOdd;
            ViewBag.TenderTdEven = tdEven;

            List<string> aOddN = new List<string>();
            List<string> aEvenN = new List<string>();
            foreach (HtmlNode link in aOdd)
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty).Split(new[] { "component=" }, StringSplitOptions.None)[1].Replace("amp;", "");
                aOddN.Add("https://pudutenders.gov.in/nicgep/app?component=" + hrefValue);
            }
            foreach (HtmlNode link in aEven)
            {
                // Get the value of the HREF attribute
                string hrefValue = link.GetAttributeValue("href", string.Empty).Split(new[] { "component=" }, StringSplitOptions.None)[1].Replace("amp;", "");
                aEvenN.Add("https://pudutenders.gov.in/nicgep/app?component=" + hrefValue);
            }
            ViewBag.TenderaOdd = aOddN;
            ViewBag.TenderaEven = aEvenN;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
