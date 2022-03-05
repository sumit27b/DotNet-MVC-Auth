using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzaOrderApp.Models
{

    [Table("pizza")]
    public class PizzaModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PizzaName { get; set; }
        [Required]
        public string PizzaDesc { get; set; }
        [Required]
        public string PizzaType { get; set; }
        [Required]
        public int PizzaPrice { get; set; }

    }
}