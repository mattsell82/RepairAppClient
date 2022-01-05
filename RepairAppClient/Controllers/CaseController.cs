using RepairAppClient.CaseService;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepairAppClient.Controllers
{
    public class CaseController : Controller
    {
        // GET: Case
        public ActionResult Index()
        {
            try
            {
                using (CaseServiceClient client = new CaseServiceClient())
                {
                    var cases = client.GetCases();
                    return View(cases);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("Felmeddelande CaseController, Index method: " + e.Message);
                throw;
            }




        }

        // GET: Case/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Case/Create
        public ActionResult Create()
        {
            //kod för att hämta produkter
            //lägg produkterna i viewdata/viewbag


            return View(new CaseDto());
        }

        // POST: Case/Create
        [HttpPost]
        public ActionResult Create(CaseDto caseDto)
        {
            try
            {
                using (CaseServiceClient client = new CaseServiceClient())
                {
                    client.CreateCase(caseDto);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("", "Something went wrong");
                return View(caseDto);
            }
        }

        // GET: Case/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Case/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Case/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Case/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
