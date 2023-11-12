using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BBBMVCPROJECT.Models;
using System.Data;

namespace BBBMVCPROJECT.Controllers
{
    public class GadgetController : Controller
    {
        private readonly IGadgetRepository _repo;

        public GadgetController(IGadgetRepository repo)
        {
            this._repo = repo;
        }

        public IActionResult Index()
        {
            var gadgets = _repo.GetAllGadgets();
            return View(gadgets);
        }

        public IActionResult ViewGadgets(int id)
        {
            var gadget = _repo.GetGadget(id);

            return View(gadget);
        }

        public IActionResult UpdateGadget(int id)
        {
            
            Gadget gad = _repo.GetGadget(id);   

            if (gad == null)
            {
                return View(gad);
            }

            return View(gad);

        }

        public IActionResult UpdateGadgetToDatabase(Gadget gadget)
        {
            repo.UpdateGadget(gadget);

            return RedirectToAction("ViewGadget", new { id = gadget.GadgetID });
        }

        public IActionResult InsertGadget()
        {
            var prod = repo.AssignCategory();
            return View(prod);
        }

        public IActionResult InsertGadgetToDatabase(Gadget gadgetToInsert)
        {
            repo.InsertProduct(gadgetToInsert);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteGadget(Gadget gadget)
        {
            repo.DeleteGadget(gadget);
            return RedirectToAction("Index");
        }

    }
}
