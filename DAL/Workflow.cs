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
    
    public partial class Workflow
    {
        public Workflow()
        {
            this.WorkflowSteps = new HashSet<WorkflowStep>();
            this.ApplicationWorkflows = new HashSet<ApplicationWorkflow>();
            this.ApplicationDefaultWorkflows = new HashSet<ApplicationDefaultWorkflow>();
            this.WorkflowMechanism = new HashSet<WorkflowMechanism>();
            this.PanelStages = new HashSet<PanelStage>();
            this.ClientDefaultWorkflows = new HashSet<ClientDefaultWorkflow>();
        }
    
        public int WorkflowId { get; set; }
        public int ClientId { get; set; }
        public string WorkflowName { get; set; }
        public string WorkflowDescription { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public int ReviewStageId { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual ICollection<WorkflowStep> WorkflowSteps { get; set; }
        public virtual ICollection<ApplicationWorkflow> ApplicationWorkflows { get; set; }
        public virtual ICollection<ApplicationDefaultWorkflow> ApplicationDefaultWorkflows { get; set; }
        public virtual ICollection<WorkflowMechanism> WorkflowMechanism { get; set; }
        public virtual ReviewStage ReviewStage { get; set; }
        public virtual ICollection<PanelStage> PanelStages { get; set; }
        public virtual ICollection<ClientDefaultWorkflow> ClientDefaultWorkflows { get; set; }
    }
}
