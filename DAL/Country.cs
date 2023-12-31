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
    
    public partial class Country
    {
        public Country()
        {
            this.UserAddresses = new HashSet<UserAddress>();
            this.Nominees = new HashSet<Nominee>();
            this.NomineeSponsors = new HashSet<NomineeSponsor>();
        }
    
        public int CountryId { get; set; }
        public string CountryAbbreviation { get; set; }
        public string CountryName { get; set; }
    
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
        public virtual ICollection<Nominee> Nominees { get; set; }
        public virtual ICollection<NomineeSponsor> NomineeSponsors { get; set; }
    }
}
