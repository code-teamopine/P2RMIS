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
    
    public partial class CommunicationLogRecipient
    {
        public int CommunicationLogRecipientId { get; set; }
        public int CommunicationLogId { get; set; }
        public int CommunicationLogRecipientTypeId { get; set; }
        public int PanelUserAssignmentId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
    
        public virtual CommunicationLog CommunicationLog { get; set; }
        public virtual CommunicationLogRecipientType CommunicationLogRecipientType { get; set; }
        public virtual PanelUserAssignment PanelUserAssignment { get; set; }
    }
}
