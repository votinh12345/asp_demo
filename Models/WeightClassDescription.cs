using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hienv_asp.Models
{

    [Table("oc_weight_class_description")]
    public class WeightClassDescription
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int weight_class_id { get; set; }

        [Display(Name = "Language Id")]
        public int language_id { get; set; }

        [Display(Name = "title")]
        [StringLength(32)]
        public String title { get; set; }

        [Display(Name = "unit")]
        [StringLength(4)]
        public String unit { get; set; }
    }
}