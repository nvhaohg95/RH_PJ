using System;
using System.Collections.Generic;

namespace RH_PJ.Models
{
    public partial class tbl_Fee
    {
        public string Fees_Guid { get; set; } = null!;
        public string? Fees_Code { get; set; }
        public string? Fees_Title { get; set; }
        public double? Fees_Value { get; set; }
        /// <summary>
        /// 0. Per Month
        /// 1. Per One
        /// 2. Per Day
        /// </summary>
        public int? Fees_Type { get; set; }
        public int? Fees_Status { get; set; }
        public bool? Fees_IsHidden { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
