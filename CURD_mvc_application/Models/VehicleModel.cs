//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CURD_mvc_application.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class VehicleModel
    {
        [Required]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string DisplayName { get; set; }

        [Required]
        public string make { get; set; }

        [Required]
        public string Vehicletype { get; set; }

        [Required]
        public string Fueltype { get; set; }

        [Required]
        public Nullable<int> vehicleMass { get; set; }

        [Required]
        public Nullable<int> EngineCapacity { get; set; }

        [Required]
        public Nullable<double> Maxspeed { get; set; }

        [Required]
        public Nullable<double> Maxpower { get; set; }

        [Required]
        public Nullable<double> OnRoadPrice { get; set; }

        [Required]
        public string description { get; set; }
    }
}
