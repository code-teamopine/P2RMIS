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
    
    public partial class PanelApplicationReviewerExpertise
    {
        public PanelApplicationReviewerExpertise()
        {
            this.PanelApplicationReviewerCoiDetails = new HashSet<PanelApplicationReviewerCoiDetail>();
        }
    
        public int PanelApplicationReviewerExpertiseId { get; set; }
        public int PanelApplicationId { get; set; }
        public int PanelUserAssignmentId { get; set; }
        public Nullable<int> ClientExpertiseRatingId { get; set; }
        public string ExpertiseComments { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
    
        public virtual ClientExpertiseRating ClientExpertiseRating { get; set; }
        public virtual PanelApplication PanelApplication { get; set; }
        public virtual ICollection<PanelApplicationReviewerCoiDetail> PanelApplicationReviewerCoiDetails { get; set; }
        public virtual PanelUserAssignment PanelUserAssignment { get; set; }
    }
}
