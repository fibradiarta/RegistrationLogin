using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMitrais.Models;

namespace TestMitrais.Controllers
{
    public class UserController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            var message = "";

            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                message = "success";
            }
            else
            {
                message = "error";
            }

            return Json(new { data = message }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Check(string email, string phonenumber)
        {
            var messageEmail = true;
            var messagePhoneNumber = true;

            var checkEmail = db.Users.Where(x => x.Email == email).ToList();
            var checkMobilePhone = db.Users.Where(x => x.PhoneNumber == phonenumber).ToList();

            if (checkEmail.Count() == 0 )
            {
                messageEmail = false;
            }
            if (checkMobilePhone.Count() == 0)
            {
                messagePhoneNumber = false;
            }

            return Json(new { email = messageEmail, phonenumber = messagePhoneNumber }, JsonRequestBehavior.AllowGet);
        }
    }
}