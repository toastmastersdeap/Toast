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
    
    public partial class NotificationExceptionLog
    {
        public int ID { get; set; }
        public string MemberID { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public string LineNumber { get; set; }
        public System.DateTimeOffset DateTime { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
    }
}