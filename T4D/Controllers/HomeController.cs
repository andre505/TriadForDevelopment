using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using T4D.Models;
using T4D.ViewModels;

namespace T4D.Controllers
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
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]

        //public async Task<IActionResult> Contact(ContactViewModel model)
        //{

        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            ViewBag.error = "none";
        //            ViewBag.loading = "loading";
        //            ViewBag.loading = "not loading";
        //            return View();

        //             var subject = "Ticket Request Successful";
        //                //string ticketss = String.Join(",", stringofticketids);
        //                var body = "";
        //                string body2 = @"<!DOCTYPE html>
        //                    <html>
        //                    <head>
        //                    <style>
        //                    </style>
        //                    </head>
        //                    <body>
        //                    <img style='display:block;' align='right' src='https://www.dropbox.com/s/0p1flnq0voo7hn9/oftcoftlogosmall.jpg?raw=1' alt = 'felt lucky'></a>" +
        //                        "<h1 style = 'font-family: Arial, sans-serif; font-size: 100%; color:#9370DB;'>Thank you, " + model.name + "</h1>" +
        //                         "<p style = 'font-family: Gill Sans, sans-serif; font-size: 160%; color:#666666;'> You have successfully entered into the National Giveaways Draw. Find draw details and ticket reference(s) below</p>" +
        //                         "<p style = 'font-family: Gill Sans, sans-serif; font-size: 160%; color:#666666;'> Draw Date: " + sqlFormattedDate + "</p>" +
        //                         "<p style = 'font-family: Gill Sans, sans-serif; font-size: 160%; color:#666666;'> Draw Date: " + item.Itemdescription + "</p>" +
        //                         "<p style = 'font-family: Gill Sans, sans-serif; font-size: 160%; color:#666666;'> Ticket Reference(s)</p>" +
        //                         "<table style='border:1px solid #d9d9d9;width:50%;font-family:Gill Sans, sans-serif;text-align:left; font-size: 130%; color:#666666;'>" +
        //                         "<tr style='background-color:#595959; color:#FFFFFF'><td>S/N</td><td>Ticket Reference</td></tr> " +

        //                         ticketrows +
        //                         //
        //                         "</table>" +
        //                         "<p></p>" +
        //                         "<a href='https://www.nationalgiveaway.com'><img style='display:block; width:100%;height:100%;' src='https://www.dropbox.com/s/medm6f3npfr4gh5/freegift.jpg?raw=1' alt = 'feeling lucky'></a>" +
        //                         "</body>" +
        //                         "</html>";
        //                EmailSender sender = new EmailSender();
        //                try
        //                {
        //                    await sender.Execute2(ticket.Emailaddress, subject, body, body2);
        //                }
        //                catch (Exception ex)
        //                {
        //                    _logger.LogError(ex, ex.Message);
        //                }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ViewBag.loading = "not loading";
        //        //Log the error (uncomment ex variable name and write a log.
        //        ModelState.AddModelError("", "Unable to Complete Request");
        //        ViewBag.error = "true";
        //        ViewBag.Status = "A Network Error Occurred";
        //    }
        //    return View(model);
        //}

        public IActionResult Projects()
        {
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
