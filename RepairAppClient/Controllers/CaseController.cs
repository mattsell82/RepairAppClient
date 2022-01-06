using RepairAppClient.CaseService;
using RepairAppClient.ProduktService;
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

        // GET: Case/Details/get by guid
        public ActionResult GetByGuid(string guidString)
        {
            Guid guid = Guid.Parse(guidString);

            using (CaseServiceClient client = new CaseServiceClient())
            {
                var caseDto = client.GetCaseByGuid(guid);

                return View("Details", caseDto);
            }

        }

        // GET: Case/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Case/Create
        public ActionResult Create(int id)
        {
            using (ProduktServiceClient produktService = new ProduktServiceClient())
            {
              List<ProduktService.Produkter1> MarkesLista= produktService.VisaAllaProdukter().ToList();
              return View();
            }
            //kod för att hämta produkter
            //lägg produkterna i viewdata/viewbag
            //            List<ArticleCategory> articleCategories = _context.ArticleCategory.OrderBy(a => a.Name).ToList();
            //             ViewData["ArticleCategoryId"] = new SelectList(articleCategories, "Id", "Name");
            //i vyn, hitta en likande som den nedan.
            //< select asp -for= "ArticleCategoryId" class ="form-control" asp-items="ViewBag.ArticleCategoryId"></select>


            return View(new CaseDto { CustomerId = id });
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
