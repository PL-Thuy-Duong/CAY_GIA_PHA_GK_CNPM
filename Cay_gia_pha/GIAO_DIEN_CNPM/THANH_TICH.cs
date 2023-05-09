namespace GIAO_DIEN_CNPM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class THANH_TICH
    {
        [Key]
        [StringLength(10)]
        public string MaTVien { get; set; }

        [Required]
        [StringLength(30)]
        public string TenTT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayGN { get; set; }
    }
}
