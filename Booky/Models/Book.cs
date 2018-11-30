using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booky.Models
{
    public class Book
    {
        public int Id { get; set; }

        //[Required]
        //[StringLength(255)]
        public string Name { get; set; }

        public DateTime DateAdded { get; set; }

        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }

        public ICollection<Genre> Genres { get; set; }

    }
}