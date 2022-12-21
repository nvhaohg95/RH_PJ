using System;
using System.Collections.Generic;

namespace RH_PJ.Models
{
    public partial class tbl_BillDetail
    {
        public string BillDetail_Guid { get; set; } = null!;
        public string? Bill_Guid { get; set; }
        public string? BillDetail_FeeName { get; set; }
        public string? BillDetail_FeeUnit { get; set; }
        public double? BillDetail_Price { get; set; }
        public double? BillDetail_Quantity { get; set; }
        public double? BillDetail_TotalPrice { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
