using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hienv_asp.Models
{

    [Table("oc_stock_status")]
    public class StockStatus
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int stock_status_id { get; set; }

        [Display(Name = "Language Id")]
        public int language_id { get; set; }

        [Display(Name = "name")]
        [StringLength(32)]
        public String name { get; set; }
    }
}