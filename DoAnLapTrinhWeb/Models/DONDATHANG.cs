//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnLapTrinhWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DONDATHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONDATHANG()
        {
            this.CHITIETDONDATHANG = new HashSet<CHITIETDONDATHANG>();
        }
    
        public string MaDonHang { get; set; }
        public bool Dathanhtoan { get; set; }
        public string Tinhtranggiaohang { get; set; }
        public System.DateTime Ngaydat { get; set; }
        public Nullable<System.DateTime> Ngaygiao { get; set; }
        public string MaKH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONDATHANG> CHITIETDONDATHANG { get; set; }
        public virtual TAIKHOAN TAIKHOAN { get; set; }
    }
}
