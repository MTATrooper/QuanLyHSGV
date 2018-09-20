namespace QuanlyHS_GV_THPT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MONHOC")]
    public partial class MONHOC
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string TENMH { get; set; }

        public int? TOBMID { get; set; }

        public virtual TOBM TOBM { get; set; }
    }
}
