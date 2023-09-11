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
    
    public partial class ImportLog
    {
        public ImportLog()
        {
            this.ImportLogItems = new HashSet<ImportLogItem>();
            this.ProgramMechanismImportLogs = new HashSet<ProgramMechanismImportLog>();
        }
    
        public int ImportLogId { get; set; }
        public int ClientTransferTypeId { get; set; }
        public Nullable<bool> SuccessFlag { get; set; }
        public string Url { get; set; }
        public string Message { get; set; }
        public string Content { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
    
        public virtual ClientTransferType ClientTransferType { get; set; }
        public virtual ICollection<ImportLogItem> ImportLogItems { get; set; }
        public virtual ICollection<ProgramMechanismImportLog> ProgramMechanismImportLogs { get; set; }
    }
}
