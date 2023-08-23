using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hienv_asp.Models
{

    [Table("oc_currency")]
    public class Currency
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int currency_id { get; set; }

        [Display(Name = "title")]
        [Required(ErrorMessage = "Country Name do not exit!")]        
        [StringLength(32, MinimumLength = 5, ErrorMessage = "{0} must be between {1} and {2} characters!")]
        public string title { get; set; }

        [Display(Name = "code")]
        [StringLength(3)]
        public String code { get; set; }

        [Display(Name = "symbol left")]
        [StringLength(12)]
        public String symbol_left { get; set; }

        [Display(Name = "symbol right")]
        [StringLength(12)]
        public String symbol_right { get; set; }

        [Display(Name = "decimal place")]
        [StringLength(1)]
        public String decimal_place { get; set; }

        [Display(Name = "value")]
        [Precision(15, 8)]
        public decimal value { get; set; }

        [Display(Name = "status")]
        [DefaultValue("1")]
        public Int16 status { get; set; }

        [Display(Name = "date modified")]
        [DefaultValue("0000-00-00 00:00:00")]
        public DateTime? date_modified { get; set; }

    }
}