using Confluent.Kafka;
using Confluent.Kafka.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MvcMusic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var config = new Dictionary<string, object> { { "bootstrap.servers", "localhost:2222" }, { "debug", "interceptor" } };
            Producer<string, string> _producer = new Producer<string, string>(config, new StringSerializer(Encoding.UTF8), new StringSerializer(Encoding.UTF8));
            var deliveryReport = _producer.ProduceAsync("AAA", null, null);
            Console.WriteLine("Sent a message!");
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