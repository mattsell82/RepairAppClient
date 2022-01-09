using RepairAppClient.CaseService;
using RepairAppClient.ProduktService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepairAppClient.Controllers
{
    public class QuoteController : Controller
    {
        // GET: Quote
        public ActionResult Index()
        {
            return View();
        }

        // GET: Accept
        public ActionResult AnswerQuote(int quoteId, bool answer, int caseId)
        {
            using (CaseServiceClient client = new CaseServiceClient())
            {
                client.AnswerQuote(quoteId, answer);
            }
            return RedirectToAction("Details", "Case", new { id = caseId});
        }

        // GET: Quote/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Quote/Create
        public ActionResult Create(string caseId)
        {
            if (int.TryParse(caseId, out int parsedId))
            {
                return View(new QuoteDto { CaseId = parsedId});
            }

            return RedirectToAction("Index", "Case");
        }

        // POST: Quote/Create
        [HttpPost]
        public ActionResult Create(QuoteDto quoteDto)
        {
            try
            {
                using (CaseServiceClient client = new CaseServiceClient())
                {
                    client.AddQuote(quoteDto);
                }

                return RedirectToAction("Details", "Case", new { id = quoteDto.CaseId});
            }
            catch
            {
                return View();
            }
        }

        // GET: Quote/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Quote/Edit/5
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

        // GET: Quote/Delete/5
        public ActionResult Delete(string id, int caseId)
        {

            if (int.TryParse(id, out int parsedQuoteId))
            {
                using (CaseServiceClient client = new CaseServiceClient())
                {
                    client.DeleteQuote(parsedQuoteId);

                }

                return RedirectToAction("Details", "Case", new { id = caseId});

            }

            return RedirectToAction("Details", "Case", new { id = caseId });
        }

        // POST: Quote/Delete/5
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
