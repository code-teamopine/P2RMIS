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
    
    public partial class User
    {
        public User()
        {
            this.UserClients = new HashSet<UserClient>();
            this.UserInfoes = new HashSet<UserInfo>();
            this.UserSystemRoles = new HashSet<UserSystemRole>();
            this.UserApplicationComments = new HashSet<UserApplicationComment>();
            this.ApplicationWorkflowStepAssignments = new HashSet<ApplicationWorkflowStepAssignment>();
            this.ApplicationWorkflowStepElementComments = new HashSet<ApplicationWorkflowStepElementComment>();
            this.ApplicationWorkflowStepWorkLogs = new HashSet<ApplicationWorkflowStepWorkLog>();
            this.PanelUserAssignments = new HashSet<PanelUserAssignment>();
            this.ProgramUserAssignments = new HashSet<ProgramUserAssignment>();
            this.UserAccountRecoveries = new HashSet<UserAccountRecovery>();
            this.ApplicationSummaryLogs = new HashSet<ApplicationSummaryLog>();
            this.UserAccountStatus = new HashSet<UserAccountStatu>();
            this.PanelUserPotentialAssignments = new HashSet<PanelUserPotentialAssignment>();
            this.UserCommunicationLogs = new HashSet<UserCommunicationLog>();
            this.PanelUserAssignments1 = new HashSet<PanelUserAssignment>();
            this.PanelUserPotentialAssignments1 = new HashSet<PanelUserPotentialAssignment>();
            this.ApplicationStageStepDiscussionComments = new HashSet<ApplicationStageStepDiscussionComment>();
            this.ApplicationStageStepDiscussionComments1 = new HashSet<ApplicationStageStepDiscussionComment>();
            this.UserInfoChangeLogs = new HashSet<UserInfoChangeLog>();
            this.UserInfoChangeLogs1 = new HashSet<UserInfoChangeLog>();
            this.ProgramCycleDeliverables = new HashSet<ProgramCycleDeliverable>();
            this.ProgramCycleDeliverables1 = new HashSet<ProgramCycleDeliverable>();
            this.UserPeerReviewDocuments = new HashSet<UserPeerReviewDocument>();
            this.UserBlockLogs = new HashSet<UserBlockLog>();
            this.ApplicationWorkflowStepWorkLogs1 = new HashSet<ApplicationWorkflowStepWorkLog>();
            this.SessionUserAssignments = new HashSet<SessionUserAssignment>();
            this.MeetingRegistrationTravelFlights = new HashSet<MeetingRegistrationTravelFlight>();
            this.Nominees = new HashSet<Nominee>();
            this.ProgramMechanism = new HashSet<ProgramMechanism>();
            this.UserPasswords = new HashSet<UserPassword>();
        }
    
        public int UserID { get; set; }
        public string UserLogin { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> PasswordDate { get; set; }
        public string PasswordSalt { get; set; }
        public Nullable<bool> Verified { get; set; }
        public Nullable<System.DateTime> VerifiedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public bool IsActivated { get; set; }
        public System.DateTime LastLoginDate { get; set; }
        public bool IsLockedOut { get; set; }
        public System.DateTime LastLockedOutDate { get; set; }
        public Nullable<System.DateTime> NewPasswordRequested { get; set; }
        public string NewEmail { get; set; }
        public Nullable<System.DateTime> NewEmailRequested { get; set; }
        public Nullable<int> PersonID { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<int> CredentialSentBy { get; set; }
        public Nullable<System.DateTime> CredentialSentDate { get; set; }
        public Nullable<bool> W9Verified { get; set; }
        public Nullable<System.DateTime> W9VerifiedDate { get; set; }
    
        public virtual ICollection<UserClient> UserClients { get; set; }
        public virtual ICollection<UserInfo> UserInfoes { get; set; }
        public virtual ICollection<UserSystemRole> UserSystemRoles { get; set; }
        public virtual ICollection<UserApplicationComment> UserApplicationComments { get; set; }
        public virtual ICollection<ApplicationWorkflowStepAssignment> ApplicationWorkflowStepAssignments { get; set; }
        public virtual ICollection<ApplicationWorkflowStepElementComment> ApplicationWorkflowStepElementComments { get; set; }
        public virtual ICollection<ApplicationWorkflowStepWorkLog> ApplicationWorkflowStepWorkLogs { get; set; }
        public virtual ICollection<PanelUserAssignment> PanelUserAssignments { get; set; }
        public virtual ICollection<ProgramUserAssignment> ProgramUserAssignments { get; set; }
        public virtual ICollection<UserAccountRecovery> UserAccountRecoveries { get; set; }
        public virtual ICollection<ApplicationSummaryLog> ApplicationSummaryLogs { get; set; }
        public virtual ICollection<UserAccountStatu> UserAccountStatus { get; set; }
        public virtual ICollection<PanelUserPotentialAssignment> PanelUserPotentialAssignments { get; set; }
        public virtual ICollection<UserCommunicationLog> UserCommunicationLogs { get; set; }
        public virtual ICollection<PanelUserAssignment> PanelUserAssignments1 { get; set; }
        public virtual ICollection<PanelUserPotentialAssignment> PanelUserPotentialAssignments1 { get; set; }
        public virtual ICollection<ApplicationStageStepDiscussionComment> ApplicationStageStepDiscussionComments { get; set; }
        public virtual ICollection<ApplicationStageStepDiscussionComment> ApplicationStageStepDiscussionComments1 { get; set; }
        public virtual ICollection<UserInfoChangeLog> UserInfoChangeLogs { get; set; }
        public virtual ICollection<UserInfoChangeLog> UserInfoChangeLogs1 { get; set; }
        public virtual ICollection<ProgramCycleDeliverable> ProgramCycleDeliverables { get; set; }
        public virtual ICollection<ProgramCycleDeliverable> ProgramCycleDeliverables1 { get; set; }
        public virtual ICollection<UserPeerReviewDocument> UserPeerReviewDocuments { get; set; }
        public virtual ICollection<UserBlockLog> UserBlockLogs { get; set; }
        public virtual ICollection<ApplicationWorkflowStepWorkLog> ApplicationWorkflowStepWorkLogs1 { get; set; }
        public virtual ICollection<SessionUserAssignment> SessionUserAssignments { get; set; }
        public virtual ICollection<MeetingRegistrationTravelFlight> MeetingRegistrationTravelFlights { get; set; }
        public virtual ICollection<Nominee> Nominees { get; set; }
        public virtual ICollection<ProgramMechanism> ProgramMechanism { get; set; }
        public virtual ICollection<UserPassword> UserPasswords { get; set; }
    }
}
