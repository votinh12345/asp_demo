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

    [Table("affiliate_transaction")]
    public class AffiliateTransaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int affiliate_transaction_id { get; set; }

        [Display(Name = "Affiliate Id")]
        public int affiliate_id { get; set; }

        [Display(Name = "order_id")]
        public int order_id { get; set; }

        [Display(Name = "description")]
        public String description { get; set; }

        [Display(Name = "amount")]
        [Precision(15, 4)]
        [DefaultValue("0.00")]
        public decimal amount { get; set; }

        [Display(Name = "date added")]
        [DefaultValue("0000-00-00 00:00:00")]
        public DateTime? date_added { get; set; }
    }
}