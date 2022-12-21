using System;
using System.Collections.Generic;

namespace RH_PJ.Models
{
    public partial class tbl_Capacitor
    {
        public string Capacitor_Guid { get; set; } = null!;
        public string? MainCapacitor_Guid { get; set; }
        public bool? Capacitor_IsHidden { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
