using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booky.Models
{
    public class Customer
    {
        public int Id { get; set; }

        //[Required(ErrorMessage = "Please enter customer's name")]
        //[StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }


        public DateTime? BirthDate { get; set; }
    }
}