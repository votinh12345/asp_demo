using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace hienv_asp.Models
{

    [Table("category_to_store")]
    public class CategoryToStore
    {
        public int category_id { get; set; }
        [Display(Name = "Store id")]
        public int store_id { get; set; }
    }
}