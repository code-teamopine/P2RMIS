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
    
    public partial class ImportLogItem
    {
        public int ImportLogItemId { get; set; }
        public int ImportLogId { get; set; }
        public string Key { get; set; }
        public bool SuccessFlag { get; set; }
        public string Message { get; set; }
        public string Content { get; set; }
    
        public virtual ImportLog ImportLog { get; set; }
    }
}
