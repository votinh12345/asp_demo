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

    [Table("address")]
    [Index(nameof(customer_id), Name = "idx_customer_id")]
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int address_id { get; set; }
        [Display(Name = "Customer Id")]
        public int customer_id { get; set; }

        [Display(Name = "firstname")]
        [StringLength(32)]
        [DefaultValue("")]
        public String firstname { get; set; }

        [Display(Name = "lastname")]
        [StringLength(32)]
        [DefaultValue("")]
        public String lastname { get; set; }

        [Display(Name = "company")]
        [StringLength(32)]
        public String company { get; set; }

        [Display(Name = "address_1")]
        [StringLength(128)]
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
    }
}