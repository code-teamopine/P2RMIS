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
    
    public partial class ClientParticipantType
    {
        public ClientParticipantType()
        {
            this.PanelUserAssignments = new HashSet<PanelUserAssignment>();
            this.ProgramUserAssignments = new HashSet<ProgramUserAssignment>();
            this.SummaryReviewerDescriptions = new HashSet<SummaryReviewerDescription>();
            this.PanelUserPotentialAssignments = new HashSet<PanelUserPotentialAssignment>();
            this.RoleParticipantTypes = new HashSet<RoleParticipantType>();
            this.ProgramSessionPayRates = new HashSet<ProgramSessionPayRate>();
        }
    
        public int ClientParticipantTypeId { get; set; }
        public int ClientId { get; set; }
        public string LegacyPartTypeId { get; set; }
        public string ParticipantTypeAbbreviation { get; set; }
        public string ParticipantTypeName { get; set; }
        public string ParticipantScope { get; set; }
        public bool ActiveFlag { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public bool ReviewerFlag { get; set; }
        public bool ChairpersonFlag { get; set; }
        public bool ConsumerFlag { get; set; }
        public bool ElevatedChairpersonFlag { get; set; }
        public Nullable<bool> SROFlag { get; set; }
        public Nullable<bool> RTAFlag { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual ICollection<PanelUserAssignment> PanelUserAssignments { get; set; }
        public virtual ICollection<ProgramUserAssignment> ProgramUserAssignments { get; set; }
        public virtual ICollection<SummaryReviewerDescription> SummaryReviewerDescriptions { get; set; }
        public virtual ICollection<PanelUserPotentialAssignment> PanelUserPotentialAssignments { get; set; }
        public virtual ICollection<RoleParticipantType> RoleParticipantTypes { get; set; }
        public virtual ICollection<ProgramSessionPayRate> ProgramSessionPayRates { get; set; }
    }
}
