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
    
    public partial class SummaryDocument
    {
        public SummaryDocument()
        {
            this.MechanismTemplates = new HashSet<MechanismTemplate>();
        }
    
        public int SummaryDocumentId { get; set; }
        public string DocumentFile { get; set; }
        public string DocumentName { get; set; }
        public string DocumentDescription { get; set; }
    
        public virtual ICollection<MechanismTemplate> MechanismTemplates { get; set; }
    }
}
