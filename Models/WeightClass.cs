using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hienv_asp.Models
{

    [Table("oc_weight_class")]
    public class WeightClass
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int weight_class_id { get; set; }

        [Display(Name = "value")]
        [Precision(15, 8)]
        public decimal value { get; set; }
    }
}