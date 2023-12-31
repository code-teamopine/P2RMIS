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
    
    public partial class PanelUserAssignment
    {
        public PanelUserAssignment()
        {
            this.PanelApplicationReviewerExpertises = new HashSet<PanelApplicationReviewerExpertise>();
            this.PanelApplicationReviewerAssignments = new HashSet<PanelApplicationReviewerAssignment>();
            this.ReviewerEvaluations = new HashSet<ReviewerEvaluation>();
            this.ApplicationWorkflows = new HashSet<ApplicationWorkflow>();
            this.CommunicationLogRecipients = new HashSet<CommunicationLogRecipient>();
            this.PanelUserRegistrations = new HashSet<PanelUserRegistration>();
            this.MeetingRegistrations = new HashSet<MeetingRegistration>();
        }
    
        public int PanelUserAssignmentId { get; set; }
        public int SessionPanelId { get; set; }
        public int UserId { get; set; }
        public int ClientParticipantTypeId { get; set; }
        public Nullable<int> ClientRoleId { get; set; }
        public Nullable<int> LegacyParticipantId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<System.DateTime> NotificationDateSent { get; set; }
        public bool RestrictedAssignedFlag { get; set; }
        public int ParticipationMethodId { get; set; }
        public Nullable<bool> ClientApprovalFlag { get; set; }
        public Nullable<int> ClientApprovalBy { get; set; }
        public Nullable<System.DateTime> ClientApprovalDate { get; set; }
    
        public virtual ClientParticipantType ClientParticipantType { get; set; }
        public virtual ClientRole ClientRole { get; set; }
        public virtual SessionPanel SessionPanel { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<PanelApplicationReviewerExpertise> PanelApplicationReviewerExpertises { get; set; }
        public virtual ICollection<PanelApplicationReviewerAssignment> PanelApplicationReviewerAssignments { get; set; }
        public virtual ICollection<ReviewerEvaluation> ReviewerEvaluations { get; set; }
        public virtual ICollection<ApplicationWorkflow> ApplicationWorkflows { get; set; }
        public virtual ICollection<CommunicationLogRecipient> CommunicationLogRecipients { get; set; }
        public virtual ICollection<PanelUserRegistration> PanelUserRegistrations { get; set; }
        public virtual ParticipationMethod ParticipationMethod { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<MeetingRegistration> MeetingRegistrations { get; set; }
    }
}
