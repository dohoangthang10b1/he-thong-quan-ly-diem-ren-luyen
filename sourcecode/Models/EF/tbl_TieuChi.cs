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
    
    public partial class tbl_TieuChi
    {
        public long ID { get; set; }
        public Nullable<int> TieuChi_1 { get; set; }
        public Nullable<int> TieuChi_2 { get; set; }
        public Nullable<int> TieuChi_3 { get; set; }
        public Nullable<int> TieuChi_4 { get; set; }
        public Nullable<int> TieuChi_5 { get; set; }
        public Nullable<int> TongDiem { get; set; }
        public string XepLoai { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public Nullable<int> LoaiDiem { get; set; }
        public Nullable<long> SinhVien_ID { get; set; }
        public Nullable<long> GiaoVien_ID { get; set; }
        public Nullable<long> HocKy_ID { get; set; }
    
        public virtual tbl_GiaoVien tbl_GiaoVien { get; set; }
        public virtual tbl_HocKy tbl_HocKy { get; set; }
        public virtual tbl_SinhVien tbl_SinhVien { get; set; }
    }
}
