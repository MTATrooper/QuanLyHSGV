namespace QuanlyHS_GV_THPT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOCSINH")]
    public partial class HOCSINH
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string HOTEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSINH { get; set; }

        [StringLength(50)]
        public string DIACHI { get; set; }

        public int? LOPID { get; set; }

        public virtual LOP LOP { get; set; }
    }
}
