using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StatesoftheUnitedKind.Models;

namespace StatesoftheUnitedKind.Controllers
{
    public class StatesController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        // GET: States/States
        public ActionResult States(int id)
        {
            
            List<StateModel> States = new List<StateModel>
            {
                new StateModel { Name = "Delaware", Id = 0, yearFounded = 1787 },
                new StateModel { Name = "Pennsylvania", Id = 1, yearFounded = 1787 },
                new StateModel { Name = "New Jersey", Id = 2, yearFounded = 1787 },
                new StateModel { Name = "Georgia", Id = 3, yearFounded = 1788 },
                new StateModel { Name = "Connecticut", Id = 4, yearFounded = 1788 }
            };
            var chosenState = States[id];
            return View(chosenState);
        }
    }
}