using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hienv_asp.Models
{

    [Table("oc_language")]
    public class Language
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int language_id { get; set; }

        [Display(Name = "name")]
        [Required(ErrorMessage = "Country Name do not exit!")]        
        [StringLength(32)]
        public string name { get; set; }

        [Display(Name = "code")]
        [StringLength(5)]
        public String code { get; set; }

        [Display(Name = "locale")]
        [StringLength(255)]
        public String locale { get; set; }

        [Display(Name = "image")]
        [StringLength(64)]
        public String? image { get; set; }

        [Display(Name = "directory")]
        [StringLength(32)]
        public String? directory { get; set; }

        [Display(Name = "filename")]
        [StringLength(64)]
        public String? filename { get; set; }

        [Display(Name = "sort order")]
        [DefaultValue("0")]
        public Int16 sort_order { get; set; }

        [Display(Name = "status")]
        public Int16 status { get; set; }

      

    }
}