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
    
    public partial class AssignmentType
    {
        public AssignmentType()
        {
            this.ApplicationWorkflowStepAssignments = new HashSet<ApplicationWorkflowStepAssignment>();
            this.ClientAssignmentTypes = new HashSet<ClientAssignmentType>();
        }
    
        public int AssignmentTypeId { get; set; }
        public string AssignmentLabel { get; set; }
        public Nullable<int> LegacyAssignmentId { get; set; }
    
        public virtual ICollection<ApplicationWorkflowStepAssignment> ApplicationWorkflowStepAssignments { get; set; }
        public virtual ICollection<ClientAssignmentType> ClientAssignmentTypes { get; set; }
    }
}
