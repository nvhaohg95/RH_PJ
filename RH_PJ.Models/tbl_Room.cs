using System;
using System.Collections.Generic;

namespace RH_PJ.Models
{
    public partial class tbl_Room
    {
        public string Room_Guid { get; set; } = null!;
        public string? Room_Code { get; set; }
        public string? Building_Guid { get; set; }
        public double? Room_Area { get; set; }
        public string? Room_Area_Unit { get; set; }
        public string? Room_Summary { get; set; }
        public string? Room_Description { get; set; }
        public bool? Room_IsHidden { get; set; }
        public double? Room_MaxAmount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
