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
    
    public partial class LookupReportParameter
    {
        public LookupReportParameter()
        {
            this.ReportParameters = new HashSet<ReportParameter>();
        }
    
        public int ParameterId { get; set; }
        public string ParamName { get; set; }
        public string DataType { get; set; }
    
        public virtual ICollection<ReportParameter> ReportParameters { get; set; }
    }
}
