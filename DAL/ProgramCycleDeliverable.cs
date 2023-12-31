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
    
    public partial class ProgramCycleDeliverable
    {
        public int ProgramCycleDeliverableId { get; set; }
        public int ProgramYearId { get; set; }
        public Nullable<int> ReceiptCycle { get; set; }
        public int ClientDataDeliverableId { get; set; }
        public int GeneratedUserId { get; set; }
        public System.DateTime GeneratedDate { get; set; }
        public bool QcFlag { get; set; }
        public Nullable<int> QcUserId { get; set; }
        public Nullable<System.DateTime> QcDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public string DeliverableFile { get; set; }
        public byte[] QcDataFile { get; set; }
    
        public virtual ClientDataDeliverable ClientDataDeliverable { get; set; }
        public virtual User User { get; set; }
        public virtual ProgramYear ProgramYear { get; set; }
        public virtual User User1 { get; set; }
    }
}
