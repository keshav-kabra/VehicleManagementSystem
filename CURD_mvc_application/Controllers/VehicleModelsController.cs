﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CURD_mvc_application.Models;

namespace CURD_mvc_application.Controllers
{
    public class VehicleModelsController : Controller
    {
        private VehicleMasterDBEntities db = new VehicleMasterDBEntities();

        // GET: VehicleModels
        public async Task<ActionResult> Index()
        {
            return View(await db.VehicleModels.ToListAsync());
        }


        public ActionResult search()
        {
            return View();
        }

        // GET: VehicleModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                
            }
            VehicleModel vehicleModel = await db.VehicleModels.FindAsync(id);
            if (vehicleModel == null)
            {
                return HttpNotFound();
            }
            return View(vehicleModel);
        }

        // GET: VehicleModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehicleModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,name,DisplayName,make,Vehicletype,Fueltype,vehicleMass,EngineCapacity,Maxspeed,Maxpower,OnRoadPrice,description")] VehicleModel vehicleModel)
        {
            if (ModelState.IsValid)
            {
                db.VehicleModels.Add(vehicleModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(vehicleModel);
        }

        // GET: VehicleModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                 return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                
                
            }
            VehicleModel vehicleModel = await db.VehicleModels.FindAsync(id);
            if (vehicleModel == null)
            {
                return HttpNotFound();
            }
            return View(vehicleModel);
        }

        // POST: VehicleModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,name,DisplayName,make,Vehicletype,Fueltype,vehicleMass,EngineCapacity,Maxspeed,Maxpower,OnRoadPrice,description")] VehicleModel vehicleModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicleModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(vehicleModel);
        }

        // GET: VehicleModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleModel vehicleModel = await db.VehicleModels.FindAsync(id);
            if (vehicleModel == null)
            {
                return HttpNotFound();
            }
            return View(vehicleModel);
        }

        // POST: VehicleModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            VehicleModel vehicleModel = await db.VehicleModels.FindAsync(id);
            db.VehicleModels.Remove(vehicleModel);
            await db.SaveChangesAsync();
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
