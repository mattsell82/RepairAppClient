using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepairAppClient.CaseService;

namespace RepairAppClient.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            using (CaseServiceClient client = new CaseServiceClient()) 
            {
                var customers = client.GetCustomers();
                if (customers is null)
                {
                    return HttpNotFound();
                }

                return View(customers);
            }

        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            using (CaseServiceClient client = new CaseServiceClient())
            {
                var customer = client.GetCustomer(id);
                if (customer is null)
                {
                    return RedirectToAction("Index");
                }

                return View(customer);
            }

        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View(new CustomerDto());
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(CustomerDto dto)
        {
            try
            {
                using (CaseServiceClient client = new CaseServiceClient())
                {
                    var customerId = client.CreateCustomer(dto);
                    return RedirectToAction("Details", new { Id = customerId });

                }

            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "Firstname, Email and phone number are required.");
                return View(dto);
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            using (CaseServiceClient client = new CaseServiceClient())
            {
                var customer = client.GetCustomer(id);

                if (customer is null)
                {
                    return HttpNotFound();
                }

                return View(customer);
            }
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(CustomerDto dto)
        {
            if (dto is null)
            {
                return HttpNotFound();
            }

            try
            {
                using (CaseServiceClient client = new CaseServiceClient())
                {
                    client.EditCustomer(dto);
                }

                return RedirectToAction("Details", new { id = dto.Id});
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            using (CaseServiceClient client = new CaseServiceClient())
            {
                var customerDto = client.GetCustomer(id);

                if (customerDto is null)
                {
                    return RedirectToAction("Index");
                }

                return View(customerDto);
            }
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult ConfirmDelete(int id)
        {
            try
            {
                using (CaseServiceClient client = new CaseServiceClient())
                {
                    client.DeleteCustomer(id);
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
