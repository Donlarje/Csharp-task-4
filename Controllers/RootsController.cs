using System;
using Microsoft.AspNetCore.Mvc;

namespace SquareRoots.Controllers
{
    public class RootsController : Controller
    {
        [HttpGet]
        public ActionResult compare()
        {
            return View();
        }

        [HttpPost]
        public ActionResult compare(string firstnumber, string secondnumber)
        {
            double numberone = int.Parse(firstnumber);
            double numbertwo = int.Parse(secondnumber);
            double root1 = Math.Sqrt(numberone);
            double root2 = Math.Sqrt(numbertwo);
            int result = 0;

            ViewBag.num1 = numberone;
            ViewBag.num2 = numbertwo;
            ViewBag.Root1 = root1;
            ViewBag.Root2 = root2;
            if(ViewBag.Root1 > ViewBag.Root2)
            {
                result = 1;
            }
            else if(ViewBag.Root1 < ViewBag.Root2)
            {
                result = 2;
            }
            else if(ViewBag.Root1 == ViewBag.Root2)
            {
                result = 3;
            }
            else if(ViewBag.num1 < 0)
            {
                result = 4;
            }
            else if(ViewBag.num2 < 0)
            {
                result = 5;
            }
            ViewBag.Result = result;
            return View();
        }
    }
}