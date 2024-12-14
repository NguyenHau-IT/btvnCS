namespace QLSV.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STUDENT")]
    public partial class STUDENT
    {
        [StringLength(20)]
        public string STUDENTID { get; set; }

        [Required]
        [StringLength(20)]
        public string FULLNAME { get; set; }

        public double AVERAGESCORE { get; set; }

        [Required]
        [StringLength(20)]
        public string FACULTYID { get; set; }

        public virtual FACULTY FACULTY { get; set; }
    }
}
