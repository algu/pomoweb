using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using pomoweb.Data.Repositories;
using pomoweb.Domain.Entities;
using pomoweb.Domain.Repositories;
using pomoweb.ViewModels;
using pomoweb.Domain.Services;

namespace pomoweb.Controllers
{
    public class HomeController : Controller
    {
        private IPomodoroService _pomoservice;

        public HomeController(IPomodoroService pomoService)
        {
            _pomoservice = pomoService;
        }

        public ActionResult Index()
        {
            return PartialView(GetAllPomos());
        }

        public ActionResult PartialList()
        {
            return PartialView(GetAllPomos());
        }

        public ActionResult PartialCreate()
        {
            return PartialView(new PomoShort());
        }

        [HttpPost]
        public ActionResult PartialCreate(PomoShort p)
        {
            _pomoservice.Add(p.Name, p.Estimate);

            if (Request.IsAjaxRequest())
            {
                return PartialView("PartialList", GetAllPomos());
            }
            return View("PartialList", GetAllPomos());
        }

        public ActionResult PartialDetails(int id)
        {
            return PartialView(GetPomoById(id));
        }

        public ActionResult PartialEdit(int id)
        {
            return PartialView(GetPomoById(id));
        }

        [HttpPost]
        public ActionResult PartialEdit(PomoFull p)
        {
            _pomoservice.Update(p.Id, p.Name, p.Estimate);

            if (Request.IsAjaxRequest())
            {
                return PartialView("PartialList", GetAllPomos());
            }
            return View("PartialList", GetAllPomos());
        }

        public ActionResult PartialDelete(int id)
        {
            return PartialView(GetPomoById(id));
        }

        [HttpPost]
        public ActionResult PartialDelete(PomoFull p)
        {
            _pomoservice.Delete(p.Id);

            if (Request.IsAjaxRequest())
            {
                return PartialView("PartialList", GetAllPomos());
            }
            return View("PartialList", GetAllPomos());
        }
        

        private IList<PomoFull> GetAllPomos()
        {
            IEnumerable<Pomodoro> pomodoros = _pomoservice.GetAll();
            IList<PomoFull> models = Mapper.Map<IEnumerable<Pomodoro>, IList<PomoFull>>(pomodoros);
            return models;
        }

        private PomoFull GetPomoById(int id)
        {
            var pomodoro = _pomoservice.Get(x => x.Id == id).First();
            var model = Mapper.Map<Pomodoro, PomoFull>(pomodoro);
            return model;
        }
    }
}
