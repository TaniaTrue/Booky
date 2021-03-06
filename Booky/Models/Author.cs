﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Booky.Models
{
    public class Author
    {
        //[HiddenInput(DisplayValue = false)]
        public int AuthorId { get; set; }

        [Required(ErrorMessage = "Please enter Author's firstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter  Author's lastName")]
        public string LastName { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}