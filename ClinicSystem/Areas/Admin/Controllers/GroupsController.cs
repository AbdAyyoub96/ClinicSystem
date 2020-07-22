using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicSystem.Areas.Admin.Controllers
{
    public class GroupsController : Controller
    {
        // GET: Admin/Groups
        public ActionResult Groups()
        {
            return View();
        }
        public ActionResult NewGroups()
        {
            return View();
        }
    }
}