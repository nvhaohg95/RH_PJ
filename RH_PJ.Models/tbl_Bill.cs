using System;
using System.Collections.Generic;

namespace RH_PJ.Models
{
    public partial class tbl_Bill
    {
        public string Bill_Guid { get; set; } = null!;
        public string? CustomerContract_Guid { get; set; }
        public string? Room_Guid { get; set; }
        public string? Building_Guid { get; set; }
        public string? ClientAccount_Guid { get; set; }
        public string? CustomerAccount_Guid { get; set; }
        public double? Electric_TotalPrice { get; set; }
        public double? Water_TotalPrice { get; set; }
        public double? Wifi_Fee_TotalPrice { get; set; }
        public double? Gabage_Fee_TotalPrice { get; set; }
        public double? Bike_TotalPrice { get; set; }
        public double? Car_TotalPrice { get; set; }
        public double? Security_TotalPrice { get; set; }
        public double? OtherFee_TotalPrice { get; set; }
        public double? VAT { get; set; }
        public double? Renting_Fee { get; set; }
        public double? TotalPrice { get; set; }
        /// <summary>
        /// 1. Not Pay
        /// 2. Paid
        /// 3. In Debt
        /// </summary>
        public int? Payment_Status { get; set; }
        /// <summary>
        /// 1. Cash
        /// 2. Bank
        /// 3. Momo
        /// </summary>
        public int? Payment_Method { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
