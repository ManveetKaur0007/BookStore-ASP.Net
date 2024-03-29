﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManveetsBooks.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Category Name of the Book")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}