using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hienv_asp.Models
{

    [Table("category")]
    public class Category {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int category_id { get; set; }

        [Display(Name = "image")]
        [StringLength(255)]
        public string? image { get; set; }

        [Display(Name = "Parent Id")]
        [DefaultValue(0)]
        public int parent_id { get; set; }

        [Display(Name = "top")]
        public int top { get; set; }

        [Display(Name = "column")]
        public int column { get; set; }

        [Display(Name = "sort order")]
        public int? sort_order { get; set; }

        [Display(Name = "status")]
        public Int16 status { get; set; }

        [Display(Name = "date added")]
        [DefaultValue("0000-00-00 00:00:00")]
        public DateTime? date_added { get; set; }

        [Display(Name = "date modified")]
        [DefaultValue("0000-00-00 00:00:00")]
        public DateTime? date_modified { get; set; }

    }
}