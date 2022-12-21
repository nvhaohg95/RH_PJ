using System;
using System.Collections.Generic;

namespace RH_PJ.Models
{
    public partial class tbl_PaymentHistory
    {
        public string PaymentHistory_Guid { get; set; } = null!;
        /// <summary>
        /// 1. Client Contract
        /// 2. Customer Contract
        /// </summary>
        public double? Contract_Type { get; set; }
        public string? Bill_Guid { get; set; }
        public string? ObjContract_Guid { get; set; }
        public string? Account_Guid_Pay { get; set; }
        public double? Account_Guid_Receive { get; set; }
        public double? PaymentHistory_Total { get; set; }
        public string? PaymentHistory_Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
