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
    
    public partial class VE
    {
        public int ID { get; set; }
        public Nullable<int> LichchieuID { get; set; }
        public Nullable<int> GheID { get; set; }
        public Nullable<int> HoadonID { get; set; }
    
        public virtual GHE GHE { get; set; }
        public virtual HOADON HOADON { get; set; }
        public virtual LICHCHIEU LICHCHIEU { get; set; }
    }
}
