using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using GwoDb;


public class SupporterController : Controller
{
    public ActionResult Company()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Company(SupporterCompanyModel model)
    {
        var organistaion = SupporterCompanyModel2Entity.Run(model);

        return View(model);
    }

}

