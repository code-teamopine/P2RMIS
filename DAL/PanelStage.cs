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
    
    public partial class PanelStage
    {
        public PanelStage()
        {
            this.PanelStageSteps = new HashSet<PanelStageStep>();
        }
    
        public int PanelStageId { get; set; }
        public int SessionPanelId { get; set; }
        public int ReviewStageId { get; set; }
        public int StageOrder { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> WorkflowId { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
    
        public virtual SessionPanel SessionPanel { get; set; }
        public virtual ReviewStage ReviewStage { get; set; }
        public virtual ICollection<PanelStageStep> PanelStageSteps { get; set; }
        public virtual Workflow Workflow { get; set; }
    }
}
