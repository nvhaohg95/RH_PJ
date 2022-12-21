using Microsoft.AspNetCore.Mvc;
using RH_PJ.Base;
using RH_PJ.Models;
using RH_PJ.Models.temps;
using System.Security.Claims;

namespace RHPJ.Base
{
    public class BaseController : ControllerBase
    {
        protected UserModel user = new UserModel();
        protected static RH_PJContext db = new RH_PJContext();
        private  static BusinessBase _bus = new BusinessBase();
        protected static UnitOfWork _unitOfWork;
        public BaseController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _bus.Init(unitOfWork);
        }
        [HttpGet]
        [Route("ahihi")]
        public tbl_Account GetLogin()
        {
            string username = User.FindFirstValue("UserName");
            if (string.IsNullOrEmpty(username)) return null;
            var u = db.tbl_Accounts.FirstOrDefault(x => x.Account_Guid == username);
            return u;
        }


    }
}
