using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult HomePage()
        {
            return View();
        }
        public ActionResult MyAccount()
        {
            return View();
        }

        // GET: Customer/Details
        public ActionResult Details()
        {
            var customer = new Customer {firstName = "Sarah", lastName = "Henry", emailAddress = "sarahelhe@gmail.com", password = "blah2781", address = " 2700 n Stowell ave Milwaukee"};
            return View(customer);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("HomePage");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("HomePage");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("HomePage");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult SetPickUpDay()
        {
            return View();
        }

        public ActionResult EditPickUpDay()
        {
            return View();
        }
        public ActionResult ChooseFrequency()
        {
            return View();
        }
        public ActionResult PausePickup()
        {
            return View();
        }
        public ActionResult ViewTrashSchedule()
        {
            return View();
        }
        public ActionResult ViewPayments()
        {
            return View();
        }
    }
}
