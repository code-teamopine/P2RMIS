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
    
    public partial class RegistrationDocumentItem
    {
        public RegistrationDocumentItem()
        {
            this.PanelUserRegistrationDocumentItems = new HashSet<PanelUserRegistrationDocumentItem>();
            this.ClientRegistrationDocumentItems = new HashSet<ClientRegistrationDocumentItem>();
        }
    
        public int RegistrationDocumentItemId { get; set; }
        public string ItemName { get; set; }
    
        public virtual ICollection<PanelUserRegistrationDocumentItem> PanelUserRegistrationDocumentItems { get; set; }
        public virtual ICollection<ClientRegistrationDocumentItem> ClientRegistrationDocumentItems { get; set; }
    }
}
