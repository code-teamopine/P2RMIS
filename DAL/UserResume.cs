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
    
    public partial class UserResume
    {
        public int UserResumeId { get; set; }
        public int UserInfoId { get; set; }
        public Nullable<int> LegacyCvId { get; set; }
        public string DocType { get; set; }
        public System.DateTime ReceivedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public string FileName { get; set; }
        public int Version { get; set; }
        public byte[] ResumeFile { get; set; }
    
        public virtual UserInfo UserInfo { get; set; }
    }
}
