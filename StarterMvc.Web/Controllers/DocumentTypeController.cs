﻿using StarterMvc.Web.Core;
using StarterMvc.Web.Core.Models;
using StarterMvc.Web.Persistence;
using System.Net;
using System.Web.Mvc;

namespace StarterMvc.Web.Controllers
{
    public class DocumentTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public DocumentTypeController()
        {
            _unitOfWork = new UnitOfWork(new ApplicationDbContext());
        }

        // GET: DocumentType
        public ActionResult Index()
        {
            return View(_unitOfWork.DocumentTypes.GetAll());
        }

        // GET: DocumentType/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            DocumentType documentType = _unitOfWork.DocumentTypes.Get((int)id);
            if (documentType == null)
            {
                return HttpNotFound();
            }
            return View(documentType);
        }

        // GET: DocumentType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DocumentType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Code,Description,IsActive")] DocumentType documentType)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.DocumentTypes.Add(documentType);
                _unitOfWork.Commit();
                return RedirectToAction("Index");
            }

            return View(documentType);
        }

        // GET: DocumentType/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DocumentType documentType = _unitOfWork.DocumentTypes.Get((int)id);
            if (documentType == null)
            {
                return HttpNotFound();
            }

            return View(documentType);
        }

        // POST: DocumentType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Code,Description,IsActive")] DocumentType documentType)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(documentType).State = EntityState.Modified;
                //db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(documentType);
        }

        // GET: DocumentType/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DocumentType documentType = _unitOfWork.DocumentTypes.Get((int)id);
            if (documentType == null)
            {
                return HttpNotFound();
            }
            return View(documentType);
        }

        // POST: DocumentType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DocumentType documentType = _unitOfWork.DocumentTypes.Get(id);
            _unitOfWork.DocumentTypes.Remove(documentType);
            _unitOfWork.Commit();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
