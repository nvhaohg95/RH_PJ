using System;
using System.Collections.Generic;

namespace RH_PJ.Models
{
    public partial class tbl_AccountInfo
    {
        public string AccountInfo_Guid { get; set; } = null!;
        public string? Account_Guid { get; set; }
        public string? AccountInfo_FirstName { get; set; }
        public string? AccountInfo_LastName { get; set; }
        public string? AccountInfo_Address { get; set; }
        public string? AccountInfo_District { get; set; }
        public string? AccountInfo_Ward { get; set; }
        public string? AccoutnInfo_City { get; set; }
        public string? AccountIno_Nationality { get; set; }
        public string? AccountInfo_Gender { get; set; }
        public DateTime? AccountInfo_Birthday { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }

        public virtual tbl_Account? Account_Gu { get; set; }
    }
}
