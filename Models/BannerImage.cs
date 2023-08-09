using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

namespace hienv_asp.Models
{

    [Table("banner_image")]
    public class BannerImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int banner_image_id { get; set; }

        [Display(Name = "banner_id")]
        public int banner_id { get; set; }

        [Display(Name = "link")]
        [StringLength(225)]
        public String link { get; set; }

        [Display(Name = "image")]
        [StringLength(225)]
        public String image { get; set; }
    }
}