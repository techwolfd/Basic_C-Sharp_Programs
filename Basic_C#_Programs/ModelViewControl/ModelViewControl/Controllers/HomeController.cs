using ModelViewControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelViewControl.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // //string text = "Hello";
            // //System.IO.File.WriteAllText(@"C:\Users\David\Documents\GitHub\Basic_C-_Programs\Basic_C#_Programs\ModelViewControl\log.txt",text);

            //Random rnd = new Random(10);
            //int num = rnd.Next();

            //ViewBag.RandomNumber = num;
            //if (num > 20000)
            //{
            //    return View("About");
            //}

            List<string> names = new List<string>
            {
                "wolf","i do not ever", "give up"
            };
            int number = 5;
            //se puede pasar number o names

            Class1 user = new Class1();
            user.Id = 01;
            user.FirstName = "wolf";
            user.LastName = "wolff";
            user.Age = 28;
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //throw new Exception("invalid page");
            return View();
        }

        public ActionResult Contact(int id = 0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}