﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesSample.Model
{
    public class Book
    {
       
       [Key]
        public int BookId { get; set; }
        [Required]
        public string BookName { get; set; }
        public string Author { get; set; }
        //Here i am adding new column  into the database
        //then we have to re migrate (App-migrate message)
        public string Volum { get; set; }
    }

}
