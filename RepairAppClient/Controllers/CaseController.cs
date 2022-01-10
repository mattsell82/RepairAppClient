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
        [Authorize]
        public ActionResult Index()
        {
            try
            {
                using (CaseServiceClient client = new CaseServiceClient())
                {
                    var cases = client.GetCases();

                    Dictionary<int, string> productDictionary = new Dictionary<int, string>();

                    //hämtar produkternas man och lägger dem i en dictionary. skulle nog vara bättra att göra detta med en viewModel istället.
                    using (ProduktServiceClient produktClient = new ProduktServiceClient())
                    {
                        var productList = produktClient.VisaAllaProdukter().ToList();

                        foreach (var item in productList)
                        {
                            productDictionary.Add(item.Id, item.Modell);
                        }
                    }

                    ViewData["Products"] = productDictionary;

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
            //försöker parsa guiden
            if (Guid.TryParse(guidString, out Guid guid))
            {
                //om guiden kan parsas hämtas ärendet
                using (CaseServiceClient client = new CaseServiceClient())
                {
                    var caseDto = client.GetCaseByGuid(guid);

                    //Hämtar produkten och lägger den i en viewbag
                    using (ProduktServiceClient productClient = new ProduktServiceClient())
                    {
                        Produkter1 product = productClient.VisaProdukt(caseDto.ProductId);
                        ViewData["Product"] = product;
                    }

                    return View("Details", caseDto);
                }
            }

            //om guiden inte kan parsas skickas man till home index.
            return RedirectToAction("Index", "Home");
        }

        // GET: Case/Details/5
        [Authorize]
        public ActionResult Details(string id)
        {
            int caseId;
            if (!int.TryParse(id, out caseId))
            {
                return RedirectToAction("Index");
            }

            using (CaseServiceClient client = new CaseServiceClient())
            {
                var caseDto = client.GetCase(caseId);


                using (ProduktServiceClient productClient = new ProduktServiceClient())
                {
                    Produkter1 product = productClient.VisaProdukt(caseDto.ProductId);
                    ViewData["Product"] = product;
                }


                return View(caseDto);
            }
        }

        // GET: Case/Create
        [Authorize]
        public ActionResult Create(string id)
        {
            int parsedId;

            if (!int.TryParse(id, out parsedId))
            {
                return RedirectToAction("Index");
            }

            using (ProduktServiceClient produktService = new ProduktServiceClient())
            {
                var products = produktService.VisaAllaProdukter();

                var options = products.Select(p => new SelectListItem { Value = p.Id.ToString(), Text = p.Märke + p.Modell });

                ViewData["Products"] = new SelectList(options, "Value", "Text");

                var caseDto = new CaseDto { 
                    CustomerDto = new CustomerDto { Id = parsedId },
                    EstimatedDeliveryDate = DateTime.Now };

                caseDto.EstimatedDeliveryDate = caseDto.EstimatedDeliveryDate.Date;

                return View(caseDto);
            }

        }

        // POST: Case/Create
        [Authorize]
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
            catch (Exception e)
            {
                Debug.WriteLine("Felmeddelande case/create: " + e.Message);
                return RedirectToAction("index", "Customer");
            }
        }

        // GET: Case/Edit/5
        [Authorize]
        public ActionResult Edit(int id)
        {
            using (CaseServiceClient client = new CaseServiceClient())
            {
                var caseDto = client.GetCase(id);

                if (caseDto is null)
                {
                    return HttpNotFound();
                }

                var statusDtos = client.GetStatusList();

                ViewData["Status"] = new SelectList(statusDtos, "Id", "Name", caseDto.StatusDto.Id);

                return View(caseDto);
            }


        }

        // POST: Case/Edit/5
        [HttpPost]
        [Authorize]
        public ActionResult Edit(CaseDto caseDto)
        {
            if (caseDto is null)
            {
                return HttpNotFound();
            }

            try
            {
                using (CaseServiceClient client = new CaseServiceClient())
                {
                    client.EditCase(caseDto);
                }

                return RedirectToAction("Details", new { id = caseDto.Id });
            }
            catch
            {
                return View();
            }
        }

        // GET: Case/Delete/5
        [Authorize]
        public ActionResult Delete(int id)
        {
            using (CaseServiceClient client = new CaseServiceClient())
            {
                var caseDto = client.GetCase(id);

                if (caseDto is null)
                {
                    return RedirectToAction("Index");
                }

                return View(caseDto);
            }
        }

        // POST: Case/Delete/5
        [Authorize]
        [HttpPost]
        public ActionResult ConfirmDelete(int id)
        {
            try
            {
                using (CaseServiceClient client = new CaseServiceClient())
                {
                    client.DeleteCase(id);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }
}
