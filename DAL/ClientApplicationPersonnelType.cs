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
    
    public partial class ClientApplicationPersonnelType
    {
        public ClientApplicationPersonnelType()
        {
            this.ApplicationPersonnels = new HashSet<ApplicationPersonnel>();
        }
    
        public int ClientApplicationPersonnelTypeId { get; set; }
        public int ClientId { get; set; }
        public string ApplicationPersonnelType { get; set; }
        public bool CoiFlag { get; set; }
        public string ApplicationPersonnelTypeAbbreviation { get; set; }
        public Nullable<int> ExternalPersonnelTypeId { get; set; }
    
        public virtual ICollection<ApplicationPersonnel> ApplicationPersonnels { get; set; }
        public virtual Client Client { get; set; }
    }
}
