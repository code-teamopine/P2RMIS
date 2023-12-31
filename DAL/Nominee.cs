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
    
    public partial class Nominee
    {
        public Nominee()
        {
            this.NomineePhones = new HashSet<NomineePhone>();
            this.NomineePrograms = new HashSet<NomineeProgram>();
        }
    
        public int NomineeId { get; set; }
        public Nullable<int> PrefixId { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FirstName { get; set; }
        public Nullable<int> GenderId { get; set; }
        public Nullable<int> EthnicityId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public Nullable<int> StateId { get; set; }
        public string ZipCode { get; set; }
        public Nullable<int> CountryId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual Ethnicity Ethnicity { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Prefix Prefix { get; set; }
        public virtual State State { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<NomineePhone> NomineePhones { get; set; }
        public virtual ICollection<NomineeProgram> NomineePrograms { get; set; }
    }
}
