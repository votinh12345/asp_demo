using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hienv_asp.Models
{

    [Table("oc_country")]
    public class Country
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int country_id { get; set; }

        [Display(Name = "name")]
        [Required(ErrorMessage = "Country Name do not exit!")]        
        [StringLength(128, MinimumLength = 5, ErrorMessage = "{0} must be between {1} and {2} characters!")]
        public string name { get; set; }

        [Display(Name = "Iso Code 2")]
        [StringLength(2)]
        public String iso_code_2 { get; set; }

        [Display(Name = "Iso Code 3")]
        [StringLength(3)]
        public String iso_code_3 { get; set; }

        [Display(Name = "Address Format")]
        public String address_format { get; set; }

        [Display(Name = "Postcode Required")]
        public Int16 postcode_required { get; set; }

        [Display(Name = "status")]
        [DefaultValue("1")]
        public Int16 status { get; set; }

      

    }
}