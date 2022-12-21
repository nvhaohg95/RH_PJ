using System;
using System.Collections.Generic;

namespace RH_PJ.Models
{
    public partial class tbl_AR
    {
        public string AR_Guid { get; set; } = null!;
        public string? Account_Guid { get; set; }
        public string? Room_Guid { get; set; }
        public string? CustomerContract_Guid { get; set; }
        public bool? AR_IsMain { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
