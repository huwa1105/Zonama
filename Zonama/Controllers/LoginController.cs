using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zonama.DAL;
using Zonama.DTO;
using Zonama.Interface;
using System.Web.Mvc;
using Zonama.Controllers;

namespace Zonama.Controllers
{
    public class LoginController : Controller
    {
        private IRepository db;
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Connexion(String log_username, String log_password)
        {
            LoginDTO logg = db.Authentifier(log_username, log_password);
            if (logg == null)
            {
                return HttpNotFound();
            }
            Session["Nom"] = logg.name;
            Session["Prenom"] = logg.firstname;
            Session["ID"] = logg.id_user;
            return RedirectToAction("Index", "Home");
        }
        public LoginController()
        {
            db = new Repository();
        }
        public ActionResult Deco()
        {
            // Put user code to initialize the page here
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}