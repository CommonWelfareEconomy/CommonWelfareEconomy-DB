using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using GwoDb;


public class SupporterController : Controller
{
    private readonly CompanyRepository _orgaRepository;

    public SupporterController(CompanyRepository orgaRepository)
    {
        _orgaRepository = orgaRepository;
    }

    public ActionResult Company()
    {
        return View(new SupporterCompanyModel());
    }

    [HttpPost]
    public ActionResult Company(SupporterCompanyModel model)
    {
        if (!ModelState.IsValid)
        {
            model.Message = new Message(MessageType.IsError, "Bitte überprüfen Sie Ihre Eingaben.");
            return View(model);
        }
            

        var organistaion = SupporterCompanyModel2Entity.Run(model);
        _orgaRepository.Create(organistaion);

        return View("CompanySuccess", model);
    }

}

