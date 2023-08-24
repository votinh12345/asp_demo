using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hienv_asp.Models
{

    [Table("oc_store")]
    public class Store
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int store_id { get; set; }

        [Display(Name = "name")]
        [StringLength(64)]
        public string name { get; set; }

        [Display(Name = "url")]
        [StringLength(255)]
        public String url { get; set; }

        [Display(Name = "ssl")]
        [StringLength(255)]
        public String ssl { get; set; }
    }
}