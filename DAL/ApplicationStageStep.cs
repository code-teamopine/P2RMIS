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
    
    public partial class ApplicationStageStep
    {
        public ApplicationStageStep()
        {
            this.ApplicationStageStepDiscussions = new HashSet<ApplicationStageStepDiscussion>();
        }
    
        public int ApplicationStageStepId { get; set; }
        public int ApplicationStageId { get; set; }
        public int PanelStageStepId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
    
        public virtual ApplicationStage ApplicationStage { get; set; }
        public virtual PanelStageStep PanelStageStep { get; set; }
        public virtual ICollection<ApplicationStageStepDiscussion> ApplicationStageStepDiscussions { get; set; }
    }
}
