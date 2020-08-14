using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WellBeings_NetCoreApp.Models;
using Microsoft.AspNetCore.Http;

namespace WellBeings_NetCoreApp.Controllers
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

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Retailers()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel vm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (Request.Cookies["formSubmitted"] != null)
                    {
                        var formSubmittedValue = Convert.ToInt32(Request.Cookies["formSubmitted"]);
                        if (formSubmittedValue == 1)
                        { 
                        Response.Cookies.Append("formSubmitted", "1", new CookieOptions { Expires = DateTime.Today.AddDays(1) });
                        ViewBag.Message = "Form has already been submitted";
                        }
                    }
                    else
                    {
                        Response.Cookies.Append("formSubmitted", "1", new CookieOptions { Expires = DateTime.Today.AddDays(1) });
                        ViewBag.Message = "Form has been submitted";
                    }

                    //MailMessage msz = new MailMessage();
                    //msz.From = new MailAddress(vm.Email);//Email which you are getting 
                    //                                     //from contact us page 
                    //msz.To.Add("emailaddrss@gmail.com");//Where mail will be sent 
                    //msz.Subject = vm.Subject;
                    //msz.Body = vm.Message;
                    //SmtpClient smtp = new SmtpClient();

                    //smtp.Host = "smtp.gmail.com";

                    //smtp.Port = 587;

                    //smtp.Credentials = new System.Net.NetworkCredential
                    //("youremailid@gmail.com", "password");

                    //smtp.EnableSsl = true;

                    //smtp.Send(msz);

                    //ModelState.Clear();
                    //ViewBag.Message = "Thank you for Contacting us ";
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.Message = $" Sorry we are facing Problem here {ex.Message}";
                }
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
