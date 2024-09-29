using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace MeetingRoomBooking.WebApp.Controllers {
    public class AccountController : Controller {

        public IActionResult Index() {
            return View("~/");
        }

        public IActionResult Login() {
            return View("~/Views/Account/Login.cshtml");
        }
    }
}
