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

    [Table("affiliate")]
    public class Affiliate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int affiliate_id { get; set; }

        [Display(Name = "firstname")]
        [StringLength(32)]
        [DefaultValue("")]
        public String firstname { get; set; }

        [Display(Name = "lastname")]
        [StringLength(32)]
        [DefaultValue("")]
        public String lastname { get; set; }

        [Display(Name = "email")]
        [StringLength(96)]
        [DefaultValue("")]
        public String email { get; set; }

        [Display(Name = "telephone")]
        [StringLength(32)]
        [DefaultValue("")]
        public String telephone { get; set; }

        [Display(Name = "fax")]
        [StringLength(32)]
        [DefaultValue("")]
        public String fax { get; set; }

        [Display(Name = "password")]
        [StringLength(40)]
        [DefaultValue("")]
        public String password { get; set; }

        [Display(Name = "company")]
        [StringLength(32)]
        public String company { get; set; }

        [Display(Name = "website")]
        [StringLength(225)]
        public String website { get; set; }

        [Display(Name = "address_1")]
        [StringLength(128)]
        [DefaultValue("")]
        public String address_1 { get; set; }

        [Display(Name = "address_2")]
        [StringLength(128)]
        public String address_2 { get; set; }

        [Display(Name = "city")]
        [StringLength(128)]
        public String city { get; set; }

        [Display(Name = "postcode")]
        [StringLength(10)]
        public String postcode { get; set; }

        [Display(Name = "country id")]
        [DefaultValue(0)]
        public int country_id { get; set; }

        [Display(Name = "zone id")]
        [DefaultValue(0)]
        public int zone_id { get; set; }

        [Display(Name = "code")]
        [StringLength(64)]
        public String code { get; set; }

        [Display(Name = "commission")]
        [Precision(4, 2)]
        [DefaultValue("0.00")]
        public decimal commission { get; set; }

        [Display(Name = "tax")]
        [StringLength(64)]
        public String tax { get; set; }

        [Display(Name = "payment")]
        [StringLength(6)]
        public String payment { get; set; }

        [Display(Name = "cheque")]
        [StringLength(100)]
        [DefaultValue("")]
        public String cheque { get; set; }

        [Display(Name = "paypal")]
        [StringLength(64)]
        [DefaultValue("")]
        public String paypal { get; set; }

        [Display(Name = "bank_name")]
        [StringLength(64)]
        [DefaultValue("")]
        public String bank_name { get; set; }

        [Display(Name = "Bank Branch Number")]
        [StringLength(64)]
        [DefaultValue("")]
        public String bank_branch_number { get; set; }

        [Display(Name = "Bank Swift Code")]
        [StringLength(64)]
        [DefaultValue("")]
        public String bank_swift_code { get; set; }

        [Display(Name = "Bank Account Name")]
        [StringLength(64)]
        [DefaultValue("")]
        public String bank_account_name { get; set; }

        [Display(Name = "Bank Account Number")]
        [StringLength(64)]
        [DefaultValue("")]
        public String bank_account_number { get; set; }

        [Display(Name = "ip")]
        [StringLength(15)]
        public String ip { get; set; }

        [Display(Name = "status")]
        public Int16 status { get; set; }

        [Display(Name = "approved")]
        public Int16 approved { get; set; }

        [Display(Name = "date added")]
        [DefaultValue("0000-00-00 00:00:00")]
        public DateTime? date_added { get; set; }
    }
}