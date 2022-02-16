namespace TestRestClient
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BA_KSB
    {
        [StringLength(10)]
        public string ID { get; set; }

        [Required]
        [StringLength(30)]
        public string MC { get; set; }

        public int ROW { get; set; }

        public int? BZCW { get; set; }

        public int? ZKCW { get; set; }

        [StringLength(10)]
        public string ZKYS { get; set; }

        [StringLength(10)]
        public string ZKHS { get; set; }

        [StringLength(10)]
        public string KZR { get; set; }
    }
}
