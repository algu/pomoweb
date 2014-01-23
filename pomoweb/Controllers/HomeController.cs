using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pomoweb.Domain.Entities;
using pomoweb.Domain.ViewModels;

namespace pomoweb.Controllers
{
    public class HomeController : Controller
    {
        private static List<PomoFull> pomolist = new List<PomoFull>()
            {
                new PomoFull() {Id = 1, Name = "test1", Estimate = 7, Pomodoros = 2},
                new PomoFull() {Id = 2, Name = "test2", Estimate = 7, Pomodoros = 0}
            };
        
        public ActionResult Index()
        {
            
            return PartialView(pomolist);
        }

        public ActionResult PartialList()
        {
            return PartialView(pomolist);
        }

        public ActionResult PartialCreate()
        {
            return PartialView(new PomoShort());
        }

        [HttpPost]
        public ActionResult PartialCreate(PomoShort p)
        {
            pomolist.Add(new PomoFull() { Id = pomolist.Max(x => x.Id)+1, Name = p.Name, Estimate = p.Estimate, Pomodoros = 0});
            if (Request.IsAjaxRequest())
            {
                return PartialView("PartialList", pomolist);
            }
            return View("PartialList", pomolist);
        }

        public ActionResult PartialDetails(int id)
        {

            return PartialView(pomolist.Find(x => x.Id == id));
        }

        public ActionResult PartialEdit(int id)
        {
            return PartialView(pomolist.Find(x => x.Id == id));
        }

        [HttpPost]
        public ActionResult PartialEdit(PomoFull p)
        {
            var pomo = pomolist.Find(x => x.Id == p.Id);
            pomo.Name = p.Name;
            pomo.Estimate = p.Estimate;
            if (Request.IsAjaxRequest())
            {
                return PartialView("PartialList",pomolist);
            }
            return View("PartialList", pomolist);
        }

        public ActionResult PartialDelete(int id)
        {
            return PartialView(pomolist.Find(x => x.Id == id));
        }
        
        [HttpPost]
        public ActionResult PartialDelete(PomoFull p)
        {
            //var pomo = pomolist.Find(x => x.Id == p.Id);
            //pomolist.Remove(pomo);
            pomolist.Remove(pomolist.Find(x => x.Id == p.Id));
            
            if (Request.IsAjaxRequest())
            {
                return PartialView("PartialList", pomolist);
            }
            return View("PartialList", pomolist);
        }
    }
}
