using System;
using System.Collections.Generic;

namespace RH_PJ.Models
{
    public partial class tbl_RC
    {
        public string RC_Guid { get; set; } = null!;
        public string? Room_Guid { get; set; }
        public string? Capacitor_Guid { get; set; }
        public int? RC_Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
