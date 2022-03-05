using MySql.Data.EntityFramework;
using PizzaOrderApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PizzaOrderApp.DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class PizzaDBContext:DbContext
    {
        public DbSet<PizzaModel> Pizzas { get; set; }

        public PizzaDBContext() : base("dbcon")
        {

        }
    }
}