using System;
using System.Collections.Generic;

namespace RH_PJ.Models
{
    public partial class tbl_Contract
    {
        public string Contract_Guid { get; set; } = null!;
        public string? Account_Guid { get; set; }
        public string? Contract_Code { get; set; }
        public DateTime? Contract_SignedDate { get; set; }
        public DateTime? Contract_ExpiredDate { get; set; }
        public int? Contract_Status { get; set; }
        public double? Contract_TotalPrice { get; set; }
        public double? Contract_Discount_Price { get; set; }
        public double? Contract_Discount_Percent { get; set; }
    }
}
