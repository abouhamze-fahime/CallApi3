using callapi.Models;
using callapi.service;
using Microsoft.AspNetCore.Mvc;
using mvcCrud.service;
using System.Diagnostics;
using static callapi.service.CallApi;
using static mvcCrud.service.GetToken;

namespace callapi.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public List<MyResponseModel> GetPeopleByInfo([FromBody] BodyInfo nationalcode)
        {
            GetToken token = new GetToken();
            LoginModel us = new LoginModel();
            us.UserName = "MehraneUser";
            us.Password = "s@edRfE395Vb!";
            // var to = token.GetToken(us);
            var to2 = token.GetToken2(us);
            // string token = User.FindFirst("AccessKey").Value;
            CallApi s = new CallApi();
            nationalcode.Nationalcode = "0067199577";

            var person1 = s.PostApI(nationalcode, to2);
            return person1;
        }
    }
}