//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyBanVeXemPhim
{
    using System;
    using System.Collections.Generic;
    
    public partial class LICHCHIEU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LICHCHIEU()
        {
            this.VEs = new HashSet<VE>();
        }
    
        public int ID { get; set; }
        public Nullable<int> PhimID { get; set; }
        public Nullable<int> PhongchieuID { get; set; }
        public Nullable<System.DateTime> Thoigianchieu { get; set; }
        public Nullable<int> Giave { get; set; }
    
        public virtual PHIM PHIM { get; set; }
        public virtual PHONGCHIEU PHONGCHIEU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VE> VEs { get; set; }
    }
}