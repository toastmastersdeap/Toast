//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Toast.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AspNetUserLoginLog
    {
        public string UserID { get; set; }
        public string IP { get; set; }
        public string Device { get; set; }
        public string JavascriptVersion { get; set; }
        public Nullable<bool> IsMobileDevice { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public Nullable<System.DateTimeOffset> LoginDateTime { get; set; }
        public Nullable<System.DateTimeOffset> LogoffDateTime { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
    }
}