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

    [Table("attribute_description")]
    public class AttributeDescription
    {
        public int attribute_id { get; set; }
        [Display(Name = "language_id")]
        public int language_id { get; set; }

        [Display(Name = "firstname")]
        [StringLength(64)]
        public String name { get; set; }
    }
}