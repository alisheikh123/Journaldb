namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UniBook
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Book_Name { get; set; }

        [Required]
        public string Path { get; set; }

        [Required]
        public string Dept_semester { get; set; }

        [Required]
        public string Department { get; set; }

        public int U_id { get; set; }
    }
}
