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
    
    public partial class uspGetPeerReviewData_Result
    {
        public int ApplicationId { get; set; }
        public string LogNumber { get; set; }
        public int PanelApplicationId { get; set; }
        public string PanelName { get; set; }
        public string PanelAbbreviation { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string MeetingTypeName { get; set; }
        public Nullable<System.DateTime> AssignmentReleaseDate { get; set; }
        public int ReviewStatusId { get; set; }
        public string ReviewStatusLabel { get; set; }
        public Nullable<decimal> AvgScore { get; set; }
        public Nullable<decimal> StDev { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> ClientAssignmentTypeId { get; set; }
        public string AssignmentLabel { get; set; }
        public Nullable<int> SortOrder { get; set; }
        public Nullable<System.DateTime> CoiSignedDate { get; set; }
        public Nullable<System.DateTime> ResolutionDate { get; set; }
        public Nullable<System.DateTime> ScreeningTcDate { get; set; }
        public Nullable<System.DateTime> ScreeningTcCritiqueDate { get; set; }
        public string Year { get; set; }
        public Nullable<int> ReceiptCycle { get; set; }
    }
}
