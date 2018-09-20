namespace QuanlyHS_GV_THPT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TOBM")]
    public partial class TOBM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TOBM()
        {
            GIAOVIENs = new HashSet<GIAOVIEN>();
            MONHOCs = new HashSet<MONHOC>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string TENTO { get; set; }

        public int? SOGV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIAOVIEN> GIAOVIENs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MONHOC> MONHOCs { get; set; }
    }
}
