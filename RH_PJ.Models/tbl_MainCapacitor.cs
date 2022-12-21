using System;
using System.Collections.Generic;

namespace RH_PJ.Models
{
    public partial class tbl_MainCapacitor
    {
        public string MainCapacitor_Guid { get; set; } = null!;
        public string? Building_Guid { get; set; }
        public int? MainCapacitor_Status { get; set; }
        public bool? MainCapacitor_IsHidden { get; set; }
        public double? MainCapacitor_RoomAmount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
