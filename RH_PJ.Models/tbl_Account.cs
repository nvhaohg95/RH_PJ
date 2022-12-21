using System;
using System.Collections.Generic;

namespace RH_PJ.Models
{
    public partial class tbl_Account
    {
        public tbl_Account()
        {
            tbl_AccountInfos = new HashSet<tbl_AccountInfo>();
        }

        public string Account_Guid { get; set; } = null!;
        public string? Account_Code { get; set; }
        public string? Account_Phone { get; set; }
        public string? Account_Email { get; set; }
        public string? Account_Password { get; set; }
        /// <summary>
        /// 0. Admin
        /// 1. Client
        /// 2. Customer
        /// </summary>
        public int? Account_Role { get; set; }
        /// <summary>
        /// 1. NotActived
        /// 2. Actived
        /// 3. Blocked
        /// 
        /// </summary>
        public int? Account_Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }

        public virtual ICollection<tbl_AccountInfo> tbl_AccountInfos { get; set; }
    }
}
