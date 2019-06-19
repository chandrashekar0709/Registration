using RegistrationForm.EntityFramework;
using RegistrationForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationForm.Controllers
{
    public class RegistrationFormController : Controller
    {
        RegistrationContext _db = new RegistrationContext();
        // GET: RegistrationForm
        public ActionResult Index()
        {
         
            return View();

        }
        [HttpPost]
        public ActionResult InsertUser(Sp_GetUser_Result model)
        {
            _db.Insert(model);

            return View("Index");
        }
        public ActionResult GetUserByUserName(Sp_GetUser_Result model)
        {
            List<Sp_GetUser_Result> user = new List<Sp_GetUser_Result>();
             user = _db.Getuser();
            if (user == null)
            {
                model.LoginErrorMessage = "Wrong username or Password.";
                return View("index", model);

            }
            else
            {

                return View("GetDetail");
            }
        }
        public ActionResult GetDetail(Sp_GetUser_Result model)
        {

            return View();
        }

        }
    }