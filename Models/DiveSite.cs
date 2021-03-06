//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace diveSiteProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class DiveSite
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Country { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string City { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Location { get; set; }

        [Required]
        [Range(0,9999)]
        public Nullable<int> Depth { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1000)]
        public string Image { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(25)]
        public string Buddy { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public Nullable<System.DateTime> Date { get; set; }

        [Required]
        [Range(0,200)]
        public Nullable<int> Visibility { get; set; }

        [Required]
        [Range(0, 1000)]
        [DisplayName("Air Start")]
        public Nullable<int> AirStart { get; set; }
        [Required]
        [Range(0, 1000)]
        [DisplayName("Air End")]
        public Nullable<int> AirEnd { get; set; }

        [Required]
        [Range(0, 180)]
        [DisplayName("Bottom Time")]
        public Nullable<int> BottomTime { get; set; }
        [Required]
        [Range(0, 180)]
        [DisplayName("Dive Time")]
        public Nullable<int> DiveTime { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1000)]
        [DisplayName("Dive Site Information")]
        public string SiteInfo { get; set; }

        [Required]
        [Range(0, 100)]
        [DisplayName("Water Temp")]
        public Nullable<int> WaterTemperature { get; set; }
    }
}
