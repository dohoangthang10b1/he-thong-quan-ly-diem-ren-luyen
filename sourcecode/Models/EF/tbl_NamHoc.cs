//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLĐRenLuyen.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_NamHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_NamHoc()
        {
            this.tbl_HocKy = new HashSet<tbl_HocKy>();
        }
    
        public long ID { get; set; }
        public string NamHoc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_HocKy> tbl_HocKy { get; set; }
    }
}