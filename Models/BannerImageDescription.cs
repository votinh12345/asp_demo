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

    [Table("banner_image_description")]
    public class BannerImageDescription
    {
        public int banner_image_id { get; set; }

        [Display(Name = "Language Id")]
        public int language_id { get; set; }

        [Display(Name = "Banner Id")]
        public int banner_id { get; set; }

        [Display(Name = "title")]
        [StringLength(64)]
        public String title { get; set; }
    }
}