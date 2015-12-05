using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using AHCWebDeveloperExam.Models;


namespace AHCWebDeveloperExam.Controllers
{
    public class HomeController : Controller
    {
//        public string DateRange = "WeekOverWeek";

        public ActionResult Index(string DateRange)
        {
            if (string.IsNullOrEmpty(DateRange))
            {
                DateRange = "WeekOverWeek";
            }
            string url = "http://ahcwebapi.azurewebsites.net/api/OrderSummary/" + DateRange;
            WebRequest request = WebRequest.Create(url);
            WebResponse ws = request.GetResponse();
            
            List<OrderSummary> OrderSummaryList = null;

            using (Stream stream = ws.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                String responseString = reader.ReadToEnd();

               OrderSummaryList = JsonConvert.DeserializeObject<List<OrderSummary>>(responseString);
            }

            return View(OrderSummaryList);
        }

    }
}
