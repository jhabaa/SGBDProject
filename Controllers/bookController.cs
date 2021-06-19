using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using SGBDProject.Models;

namespace SGBDProject.Controllers
{
    public class bookController : Controller
    {
        bibliothequeEntities db = new bibliothequeEntities();
        // GET: book
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addBook(book book)
        {
            ViewBag.listBook = db.books.ToList();
            db.books.Add(book);
            db.SaveChanges();
            return RedirectToAction("addbook"); 
        }
        public ActionResult addBook()
        {
            ViewBag.listBook = db.books.ToList();
            return View();
        }
     
        public ActionResult Delete(string id)
        {
            book toDelete = db.books.Find(id);
            if(toDelete != null)
            {
                db.books.Remove(toDelete);
                db.SaveChanges();
            }
            
            return RedirectToAction("addbook"); 
        }
        public ActionResult Edit(string id)
        {
            ViewBag.listBook = db.books.ToList();
            book toEdit = db.books.Find(id);
            return View("addBook",toEdit);
        }
        [HttpPost]
        public ActionResult Edit(book newBook)
        {
           // ViewBag.listBook = db.books.ToList();
            book forTrash = db.books.Find(newBook.book_id);
            db.books.Remove(forTrash);
            db.SaveChanges();
            db.Entry(newBook).State = EntityState.Added;  
            db.SaveChanges();
            return RedirectToAction("addbook");
        }
    }
}