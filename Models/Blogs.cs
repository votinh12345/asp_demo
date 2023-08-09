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

    [Table("blogs")]
    public class Blogs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "title")]
        [StringLength(191)]
        public String title { get; set; }

        [Display(Name = "body")]
        public String body { get; set; }

        [Display(Name = "Created At")]
        [DefaultValue("0000-00-00 00:00:00")]
        public DateTime? created_at { get; set; }

        [Display(Name = "Updated At")]
        [DefaultValue("0000-00-00 00:00:00")]
        public DateTime? updated_at { get; set; }

        [Display(Name = "user id")]
        public int user_id { get; set; }
    }
}