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
    
    public partial class PeerReviewDocumentType
    {
        public PeerReviewDocumentType()
        {
            this.PeerReviewDocuments = new HashSet<PeerReviewDocument>();
        }
    
        public int PeerReviewDocumentTypeId { get; set; }
        public string DocumentType { get; set; }
        public int SortOrder { get; set; }
    
        public virtual ICollection<PeerReviewDocument> PeerReviewDocuments { get; set; }
    }
}
