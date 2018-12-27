using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                var config = new Dictionary<string, object>();
                var p = new Producer(config);
                //await p.ProduceAsync("foo", Array.Empty<byte>(), Array.Empty<byte>());
                Console.WriteLine("Sent a message!");
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Failed to load librdkafka (probably).");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to send a message!");
                Console.WriteLine(ex);
            }
            return View();
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
    }
}