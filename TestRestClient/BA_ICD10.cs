namespace TestRestClient
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BA_ICD10
    {
        [Key]
        [StringLength(20)]
        public string BM { get; set; }

        [Required]
        [StringLength(100)]
        public string MC { get; set; }

        [StringLength(100)]
        public string PYM { get; set; }
    }
}
