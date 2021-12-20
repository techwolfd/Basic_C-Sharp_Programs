using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;


namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
          



            return View(db.Insurees.ToList());
        }

        public ActionResult Admin()
        {



            //        < h1 > tabla de cobros</ h1 >

            //   < table class="table table-bordered"

            //<thead>

            //  <tr>
            //    <th>#</th>
            //    <th>User Menor a 18 (plus 100)</th>
            //    <th>User betwenn 19 and 25 (plus 50)</th>
            //    <th>User more to 25 (plus 25)</th>
            //    <th>Year car after 2000(plus 25)</th>
            //    <th>Year car before 2015(plus 25)</th>
            //    <th>Car Make is porsche(plus 25)</th>
            //    <th>Car Make is porsche and model 911(plus 25)</th>
            //    <th>Speeding ticket(plus 10)</th>
            //    <th>User have a DUI(plus 10 %)</th>
            //    <th>User have full coverage(plus 50 %)</th>

            //  </tr>
            //  </thead>
            //@*@{ 
            //    double
            //    double
            //    double
            //        base of 50 by month
            //        int baseMonth = 50;
            //    


            //    for(int i=0; i <=;) { }
            //    @i
            //    @Math.Round(baseMotnh, MidpointRounding.AwayFromZero)

            //    }*@
            Insurees coti = new Insurees();
            coti.modelo = 3;
            
            
            return View(db.Insurees);
        }
        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees insurees = db.Insurees.Find(id);
            if (insurees == null)
            {
                return HttpNotFound();
            }
            return View(insurees);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurees insurees)
        {

            if (ModelState.IsValid)
            {
                double month = 50;

                DateTime nacimiento = insurees.DateOfBirth; //Fecha de nacimiento
                                                        //double edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
                double user = 0;
                double Age = DateTime.Now.Year - Convert.ToInt32(insurees.DateOfBirth.Year);
                double CarYear = 0;
                double Porsche = 0;
                double Carrera = 0;
                double Speedtick = 0;
                double DUI = 0.0;
                double coverage = 0.0;
                double Total = 0.0;

                if (Age <= 18) { user = 100; }
                else if (19 <= Age && Age < 25) { user = 50; }
                else if (Age > 25) { user = 25; }


                if (insurees.CarYear > 1950 && insurees.CarYear < 2000 || insurees.CarYear > 2015 && insurees.CarYear < 2022) { CarYear = 25; }


                if (insurees.CarMake == "Porsche") { Porsche = 25; }
                if (insurees.CarModel == "911 Carrera" || insurees.CarModel == "911 carrera") { Carrera += 25; }

                if (insurees.SpeedingTickets > 0) { Speedtick += 10 * insurees.SpeedingTickets; }

                Total = user + CarYear + Porsche + Carrera + Speedtick;
                if (insurees.DUI == true) { DUI = Total * 0.25; }

                if (insurees.CoverageType == true) { coverage = Total * .5; }


                Total = Total + DUI + coverage + month;
                insurees.Quote = Convert.ToDecimal(Total);


                db.Insurees.Add(insurees);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insurees);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees insurees = db.Insurees.Find(id);
            if (insurees == null)
            {
                return HttpNotFound();
            }
            return View(insurees);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurees insurees)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insurees).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insurees);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees insurees = db.Insurees.Find(id);
            if (insurees == null)
            {
                return HttpNotFound();
            }
            return View(insurees);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insurees insurees = db.Insurees.Find(id);
            db.Insurees.Remove(insurees);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
