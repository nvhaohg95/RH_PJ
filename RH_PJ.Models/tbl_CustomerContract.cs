using System;
using System.Collections.Generic;

namespace RH_PJ.Models
{
    public partial class tbl_CustomerContract
    {
        public string CustomerContract_Guid { get; set; } = null!;
        public string? ClientAccount_Guid { get; set; }
        public string? CustomerAccount_Guid { get; set; }
        public double? CustomerContract_Months { get; set; }
        public DateTime? CustomerContract_SignedDate { get; set; }
        public DateTime? CustomerContract_ExpiredDate { get; set; }
        /// <summary>
        /// 1. Still due
        /// 2. Expired
        /// </summary>
        public int? CustomerContract_Status { get; set; }
        public bool? CustomerContract_IsHidden { get; set; }
        public double? CustomerContract_Renting_FeeM { get; set; }
        public double? CustomerContract_MonthsDeposit { get; set; }
        public double? CustomerContract_DepositTotal { get; set; }
        public string? Building_Guid { get; set; }
        public string? Room_Guid { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
