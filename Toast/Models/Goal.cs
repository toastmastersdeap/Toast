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
    
    public partial class Goal
    {
        public int GoalID { get; set; }
        public int ClubID { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public int NumbersOfSubgoals { get; set; }
        public int SubgoalsAchieved { get; set; }
    
        public virtual Club Club { get; set; }
    }
}