using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PFDC.LolaAppWeb.Data;
using PFDC.LolaAppWeb.Models;

namespace PFDC.LolaAppWeb.Controllers
{
    public class UsersController : Controller
    {
        private PFDCLolaAppWebContext db = new PFDCLolaAppWebContext();

        // GET: Users
        public ActionResult Index()
        {
            var users = db.Users.Include(u => u.Sex).Include(u => u.UserType);
            return View(users.ToList());
        }
        //Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            using (PFDCLolaAppWebContext db = new PFDCLolaAppWebContext())
            {
                var usr = db.Users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);
                if (usr != null)
                {
                    Session["Id"] = usr.Id.ToString();
                    Session["Email"] = usr.Email.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    //ModelState.AddModelError("", "Email o contraseña son incorrectos");
                    ViewBag.ErrorMessegeLogin = "Email o contraseña son incorrectos";
                }
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["Id"] != null)
            {
                //return View("Index", "Home");
                return RedirectToAction("Index", "Home");
                //var env = System.Environment.
                //return Redirect("https://localhost:44354/Home/Index");
            }
            else
            {
                //ModelState.AddModelError("", "Email o contraseña son incorrectos");
                ViewBag.ErrorMessegeLogin = "Email o contraseña son incorrectos";
                return RedirectToAction("Login");
            }
        }

        // GET: Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            ViewBag.SexId = new SelectList(db.Sex, "Id", "Description");
            ViewBag.UserTypeId = new SelectList(db.UserTypes, "Id", "Description");
            return View();
        }

        // POST: Users/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,LastName,DNI,CuitCuil,Birthday,Street,StreetNumber,Neighbourhood,ZipCode,City,Mobile,Email,Password,PasswordConfirm,Enable,UserTypeId,SexId")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SexId = new SelectList(db.Sex, "Id", "Description", user.SexId);
            ViewBag.UserTypeId = new SelectList(db.UserTypes, "Id", "Description", user.UserTypeId);
            return View(user);
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            ViewBag.SexId = new SelectList(db.Sex, "Id", "Description", user.SexId);
            ViewBag.UserTypeId = new SelectList(db.UserTypes, "Id", "Description", user.UserTypeId);
            return View(user);
        }

        // POST: Users/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,LastName,DNI,CuitCuil,Birthday,Street,StreetNumber,Neighbourhood,ZipCode,City,Mobile,Email,Password,PasswordConfirm,Enable,UserTypeId,SexId")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SexId = new SelectList(db.Sex, "Id", "Description", user.SexId);
            ViewBag.UserTypeId = new SelectList(db.UserTypes, "Id", "Description", user.UserTypeId);
            return View(user);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
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
