using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Lubba Dubba Lub Dub!!! Oh! This is weirding me out, Let's get out of here Morty!";
        }

        public string BubbleSort(string data)
        {
            //Compare first two, take the largest as result
            //take result compare to next element
            //var elements = data.Split(',');
            int[] elements = { 64, 52, 11, 23, 45, 6, 77, 3, 4, 2 };

            for (int i = 0; i < elements.Length - 1; i++)
            {
                for (int j = 0; j < elements.Length - i - 1; j++)
                {
                    if (elements[j] > elements[j + 1])
                    {
                        var temp = elements[j];
                        elements[j] = elements[j + 1];  //since the next item is less than elements[i] lets set it as i+1
                        elements[j + 1] = temp; //move the original elements[i] into the new spot

                        System.Diagnostics.Debug.WriteLine("element has been swapped: {0}", elements[j]);
                    }
                }
            }
            return String.Join(",", elements);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
