//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sra.P2rmis.Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class SessionUserAssignment
    {
        public SessionUserAssignment()
        {
            this.MeetingRegistrations = new HashSet<MeetingRegistration>();
        }
    
        public int SessionUserAssignmentId { get; set; }
        public int UserId { get; set; }
        public int MeetingSessionId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
    
        public virtual MeetingSession MeetingSession { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<MeetingRegistration> MeetingRegistrations { get; set; }
    }
}
