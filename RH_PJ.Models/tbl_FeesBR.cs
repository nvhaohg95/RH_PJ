using System;
using System.Collections.Generic;

namespace RH_PJ.Models
{
    public partial class tbl_FeesBR
    {
        public string FBR_Guid { get; set; } = null!;
        public string? Fees_Guid { get; set; }
        public string? BR_Guid { get; set; }
        public string? BR_Code { get; set; }
        /// <summary>
        /// 1. Building
        /// 2. Room
        /// </summary>
        public int? BR_Type { get; set; }
        public bool? FBR_Hidden { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
