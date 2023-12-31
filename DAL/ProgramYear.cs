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
    
    public partial class ProgramYear
    {
        public ProgramYear()
        {
            this.ProgramMechanism = new HashSet<ProgramMechanism>();
            this.ProgramUserAssignments = new HashSet<ProgramUserAssignment>();
            this.ProgramPanels = new HashSet<ProgramPanel>();
            this.ProgramMeetings = new HashSet<ProgramMeeting>();
            this.ProgramCycleDeliverables = new HashSet<ProgramCycleDeliverable>();
            this.UserPeerReviewDocuments = new HashSet<UserPeerReviewDocument>();
            this.ReferralMappings = new HashSet<ReferralMapping>();
            this.NomineePrograms = new HashSet<NomineeProgram>();
            this.ProgramSessionPayRates = new HashSet<ProgramSessionPayRate>();
        }
    
        public int ProgramYearId { get; set; }
        public Nullable<int> LegacyProgramId { get; set; }
        public int ClientProgramId { get; set; }
        public string Year { get; set; }
        public Nullable<System.DateTime> DateClosed { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
    
        public virtual ClientProgram ClientProgram { get; set; }
        public virtual ICollection<ProgramMechanism> ProgramMechanism { get; set; }
        public virtual ICollection<ProgramUserAssignment> ProgramUserAssignments { get; set; }
        public virtual ICollection<ProgramPanel> ProgramPanels { get; set; }
        public virtual ICollection<ProgramMeeting> ProgramMeetings { get; set; }
        public virtual ICollection<ProgramCycleDeliverable> ProgramCycleDeliverables { get; set; }
        public virtual ICollection<UserPeerReviewDocument> UserPeerReviewDocuments { get; set; }
        public virtual ICollection<ReferralMapping> ReferralMappings { get; set; }
        public virtual ICollection<NomineeProgram> NomineePrograms { get; set; }
        public virtual ICollection<ProgramSessionPayRate> ProgramSessionPayRates { get; set; }
    }
}
