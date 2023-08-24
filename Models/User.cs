using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hienv_asp.Models
{

    [Table("oc_user")]
    public class User
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int user_id { get; set; }

        [Display(Name = "User Group Id")]
        public int user_group_id { get; set; }

        [Display(Name = "username")]
        [StringLength(32)]
        public String username { get; set; }

        [Display(Name = "password")]
        [StringLength(255)]
        public String password { get; set; }

        [Display(Name = "firstname")]
        [StringLength(255)]
        public String firstname { get; set; }

        [Display(Name = "lastname")]
        [StringLength(255)]
        public String lastname { get; set; }

        [Display(Name = "email")]
        [StringLength(255)]
        public String email { get; set; }

        [Display(Name = "code")]
        [StringLength(32)]
        public String code { get; set; }

        [Display(Name = "ip")]
        [StringLength(15)]
        public String ip { get; set; }

        [Display(Name = "status")]
        [DefaultValue("1")]
        public Int16 status { get; set; }

        [Display(Name = "date added")]
        [DefaultValue("0000-00-00 00:00:00")]
        public DateTime? date_added { get; set; }
    }
}