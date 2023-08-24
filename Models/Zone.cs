using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hienv_asp.Models
{

    [Table("oc_zone")]
    public class Zone
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int zone_id { get; set; }

        [Display(Name = "Country Id")]
        public int country_id { get; set; }

        [Display(Name = "code")]
        [StringLength(32)]
        public String code { get; set; }

        [Display(Name = "name")]
        [StringLength(128)]
        public String name { get; set; }

        [Display(Name = "status")]
        [DefaultValue("1")]
        public Int16 status { get; set; }
    }
}