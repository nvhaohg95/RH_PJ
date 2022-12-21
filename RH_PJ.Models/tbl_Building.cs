using System;
using System.Collections.Generic;

namespace RH_PJ.Models
{
    public partial class tbl_Building
    {
        public string Building_Guid { get; set; } = null!;
        public string? Building_Code { get; set; }
        public string? Building_Name { get; set; }
        public string? Building_Address { get; set; }
        public string? Building_District { get; set; }
        public string? Building_Ward { get; set; }
        public string? Building_City { get; set; }
        public string? Building_Country { get; set; }
        public int? Building_Room_Count { get; set; }
        public string? Building_Description { get; set; }
        public string? Building_Summary { get; set; }
        /// <summary>
        /// 0. Renting
        /// 1. Selling
        /// 
        /// </summary>
        public int? Building_Status { get; set; }
        /// <summary>
        /// 0. Motel
        /// 1. Building
        /// 2. Hotel
        /// 
        /// </summary>
        public int? Building_Type { get; set; }
        public bool? Building_IsHidden { get; set; }
        public string? Account_Guid { get; set; }
        public string? Account_Code { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
