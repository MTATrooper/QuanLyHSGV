namespace QuanlyHS_GV_THPT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THOIKHOABIEU")]
    public partial class THOIKHOABIEU
    {
        public int ID { get; set; }

        public int? MAGV { get; set; }

        public int? MALOP { get; set; }

        [StringLength(20)]
        public string THU { get; set; }

        [StringLength(10)]
        public string TIET { get; set; }

        public virtual GIAOVIEN GIAOVIEN { get; set; }

        public virtual LOP LOP { get; set; }
    }
}
