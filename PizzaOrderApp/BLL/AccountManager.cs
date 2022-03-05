using PizzaOrderApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaOrderApp.BLL
{
    
    public class AccountManager
    {
        PizzaDBContext dbentities=new PizzaDBContext();
        public bool Validate(string email, string password)
        {
            bool status = false;

            //get DBcontext 
            //fire LINQ Against DBcontext.user
            
            if (email == "sumitbonde@gmail.com" && password == "sumit123")
            {
                status = true;
            }
            return status;
        }
    }
}