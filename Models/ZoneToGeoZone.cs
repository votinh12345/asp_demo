using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hienv_asp.Models
{

    [Table("oc_zone_to_geo_zone")]
    public class ZoneToGeoZone
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int zone_to_geo_zone_id { get; set; }

        [Display(Name = "Country Id")]
        public int country_id { get; set; }

        [Display(Name = "Zone Id")]
        [DefaultValue("0")]
        public int zone_id { get; set; }

        [Display(Name = "Geo Zone Id")]
        public int geo_zone_id { get; set; }

        [Display(Name = "date added")]
        [DefaultValue("0000-00-00 00:00:00")]
        public DateTime? date_added { get; set; }

        [Display(Name = "Date Modified")]
        [DefaultValue("0000-00-00 00:00:00")]
        public DateTime? date_modified { get; set; }

    }
}