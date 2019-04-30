﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreAuthorization.Models;

namespace DotNetCoreAuthorization.Controllers
{
    public class HomeController : Controller
    {
        MyDbContext db = new MyDbContext();

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("email") == null)
            {
                return Redirect("/Account/Login");
            }

            return View();
        }


    }
}