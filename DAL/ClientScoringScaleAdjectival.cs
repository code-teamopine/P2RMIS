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
    
    public partial class ClientScoringScaleAdjectival
    {
        public int ClientScoringScaleAdjectivalId { get; set; }
        public int ClientScoringId { get; set; }
        public string ScoreLabel { get; set; }
        public int NumericEquivalent { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ClientScoringScale ClientScoringScale { get; set; }
    }
}
