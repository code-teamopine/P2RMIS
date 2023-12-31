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
    
    public partial class ReviewStage
    {
        public ReviewStage()
        {
            this.ApplicationStages = new HashSet<ApplicationStage>();
            this.PanelStages = new HashSet<PanelStage>();
            this.MechanismTemplates = new HashSet<MechanismTemplate>();
            this.Workflows = new HashSet<Workflow>();
            this.StepTypes = new HashSet<StepType>();
        }
    
        public int ReviewStageId { get; set; }
        public string ReviewStageName { get; set; }
    
        public virtual ICollection<ApplicationStage> ApplicationStages { get; set; }
        public virtual ICollection<PanelStage> PanelStages { get; set; }
        public virtual ICollection<MechanismTemplate> MechanismTemplates { get; set; }
        public virtual ICollection<Workflow> Workflows { get; set; }
        public virtual ICollection<StepType> StepTypes { get; set; }
    }
}
