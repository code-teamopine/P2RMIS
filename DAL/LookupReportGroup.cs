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
    
    public partial class LookupReportGroup
    {
        public LookupReportGroup()
        {
            this.Reports = new HashSet<Report>();
        }
    
        public int ReportGroupId { get; set; }
        public string ReportGroupName { get; set; }
        public int SortOrder { get; set; }
        public string ReportDescription { get; set; }
    
        public virtual ICollection<Report> Reports { get; set; }
    }
}
