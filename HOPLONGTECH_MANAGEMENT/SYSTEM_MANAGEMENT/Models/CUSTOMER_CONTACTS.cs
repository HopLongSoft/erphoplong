//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SYSTEM_MANAGEMENT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CUSTOMER_CONTACTS
    {
        public int ID_LIEN_HE_KH { get; set; }
        public string MA_KHACH_HANG { get; set; }
        public string NGUOI_LIEN_HE { get; set; }
        public Nullable<System.DateTime> NGAY_SINH { get; set; }
        public string GIOI_TINH { get; set; }
        public string CHUC_VU { get; set; }
        public string SO_DIEN_THOAI { get; set; }
        public string EMAIL { get; set; }
        public string FACEBOOK { get; set; }
        public string SKYPE { get; set; }
        public string GHI_CHU { get; set; }
    
        public virtual CUSTOMER CUSTOMER { get; set; }
    }
}