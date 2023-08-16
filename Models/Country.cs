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
        [StringLength(128)]
        public string name { get; set; }

        [Display(Name = "Iso Code 2")]
        [StringLength(2)]
        public int iso_code_2 { get; set; }

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

        public List<SelectListItem> Status { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Enabled" },
            new SelectListItem { Value = "0", Text = "Disabled" }
        };

    }
}