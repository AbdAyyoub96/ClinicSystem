﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicSystem.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        // GET: Admin/User
        public ActionResult Users()
        {
            return View();
        }
        public ActionResult NewUsers()
        {
            return View();
        }
    }
}