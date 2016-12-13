﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TessaStore.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students/{id}
        public ActionResult Index(int? id)
        {
            if(id != null)
            {
                switch(id.Value)
                {
                    case 1:
                        return Json(new { name = "Jimmy Ellis" }, JsonRequestBehavior.AllowGet);
                    case 2:
                        return Json(new { name = "Jin Xiao" }, JsonRequestBehavior.AllowGet);
                    case 3:
                        return Json(new { name = "Tessa Konkol" }, JsonRequestBehavior.AllowGet);
                    case 4:
                        return Json(new { name = "Serkan Nizam" }, JsonRequestBehavior.AllowGet);
                    case 5:
                        return Json(new { name = "Jerry Bony" }, JsonRequestBehavior.AllowGet);
                }
            }
            return HttpNotFound("No student found");
        }
    }
}