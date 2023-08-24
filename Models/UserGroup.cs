using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hienv_asp.Models
{

    [Table("oc_user_group")]
    public class UserGroup
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int user_group_id { get; set; }

        [Display(Name = "name")]
        [StringLength(64)]
        public String name { get; set; }

        [Display(Name = "permission")]
        public String permission { get; set; }
    }
}