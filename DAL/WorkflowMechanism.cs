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
    
    public partial class WorkflowMechanism
    {
        public int WorkflowMechanismId { get; set; }
        public int WorkflowId { get; set; }
        public int MechanismId { get; set; }
        public Nullable<int> ReviewStatusId { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ReviewStatu ReviewStatu { get; set; }
        public virtual Workflow Workflow { get; set; }
    }
}
