using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmpMgtApp.Models;

namespace EmpMgtApp.Controllers
{
    public class HomeController : Controller
    {
        private EmpDBEntities _db = new EmpDBEntities();

        // GET: Home
        public ActionResult Index()
        {
            return View(_db.tblUsers.ToList());
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude ="Id")] tblUser empToCreate)
        {
            if (!ModelState.IsValid)
                return View();

            _db.tblUsers.Add(empToCreate);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            //pass employee object to edit
            var empToEdit = (from e in _db.tblUsers
                             where e.UserId == id
                             select e).First();
            return View(empToEdit);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(tblUser emptoEdit)
        {
            //grab original employee object
            var originalEmp = (from e in _db.tblUsers
                               where e.UserId == emptoEdit.UserId
                               select e).First();
            //verify fields are valid
            if (!ModelState.IsValid)
                return View(originalEmp);

            _db.Entry(originalEmp).CurrentValues.SetValues(emptoEdit);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Us.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Information";

            return View();
        }
    }
}
