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

    [Table("attribute")]
    public class Attributes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int attribute_id { get; set; }
        [Display(Name = "attribute_group_id")]
        public int attribute_group_id { get; set; }

        [Display(Name = "Sort Order")]
        public int sort_order { get; set; }
    }
}