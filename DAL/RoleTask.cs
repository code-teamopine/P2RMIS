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
    
    public partial class RoleTask
    {
        public int RoleTaskId { get; set; }
        public int SystemRoleId { get; set; }
        public int SystemTaskId { get; set; }
    
        public virtual SystemRole SystemRole { get; set; }
        public virtual SystemTask SystemTask { get; set; }
    }
}
