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
    
    public partial class ReviewerEvaluationGroupGuidance
    {
        public int ReviewerEvaluationGroupGuidanceId { get; set; }
        public int ClientReviewerEvaluationGroupId { get; set; }
        public int Rating { get; set; }
        public string RatingDescription { get; set; }
    
        public virtual ClientReviewerEvaluationGroup ClientReviewerEvaluationGroup { get; set; }
    }
}
