using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using RegistrationForm.EntityFramework;

namespace RegistrationForm.Models
{
    public class RegistrationContext:DbContext
    {

        RegistrationFormDBEntities _db = new RegistrationFormDBEntities();

        public List<Sp_GetUser_Result> Getuser()
        {
            return _db.Sp_GetUser().ToList();
        }

        public void Insert(Sp_GetUser_Result model)
        {

        }

    }


  
}