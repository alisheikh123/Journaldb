namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Galery")]
    public partial class Galery
    {
        public int Id { get; set; }

        [Required]
        public string Img { get; set; }

        [Required]
        public string Category { get; set; }

        public string imgDesc { get; set; }
    }
}
