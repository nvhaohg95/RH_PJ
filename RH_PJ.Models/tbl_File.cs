using System;
using System.Collections.Generic;

namespace RH_PJ.Models
{
    public partial class tbl_File
    {
        public string File_Guid { get; set; } = null!;
        /// <summary>
        /// 1. File (pdf, doc, excel,...)
        /// 2. Image (png, jpg)
        /// </summary>
        public int? File_Type { get; set; }
        public string? File_URL { get; set; }
        public string? Object_Guid { get; set; }
        /// <summary>
        /// 1. ClientContract
        /// 2. CustomerContract
        /// 3. IDentify
        /// 4. Building
        /// 5. Room
        /// </summary>
        public int? Object_Type { get; set; }
        public int? File_Status { get; set; }
        public bool? File_IsHidden { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
