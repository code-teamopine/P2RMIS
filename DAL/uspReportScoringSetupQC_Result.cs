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
    
    public partial class uspReportScoringSetupQC_Result
    {
        public string Program { get; set; }
        public string Year { get; set; }
        public Nullable<int> Cycle { get; set; }
        public string AwardAbbreviation { get; set; }
        public string Criterion { get; set; }
        public string Phase { get; set; }
        public bool ScoreFlag { get; set; }
        public bool OverallFlag { get; set; }
        public decimal HighValue { get; set; }
        public decimal LowValue { get; set; }
        public bool TextFlag { get; set; }
        public Nullable<int> SummaryStatementOrder { get; set; }
    }
}
