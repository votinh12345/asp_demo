using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace hienv_asp.Models
{

    [Table("category_description")]
    [Index(nameof(name), Name = "idx_categories_name_zen")]
    public class CategoriesDescription
    {
        public int category_id { get; set; }
        [Display(Name = "Language Id")]
        public int language_id { get; set; }

        [Display(Name = "Categories Name")]
        [StringLength(255)]
        public int name { get; set; }

        [Display(Name = "Categories Description")]

        public String description { get; set; }

        [Display(Name = "Meta Description")]
        [StringLength(255)]
        public String meta_description { get; set; }

        [Display(Name = "Meta Keyword")]
        [StringLength(255)]
        public String meta_keyword { get; set; }

    }
}