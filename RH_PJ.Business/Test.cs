

using RH_PJ.Base;

namespace RH_PJ.Business
{
    public class Test: BusinessBase
    {
      
        public static object Get()
        {
            var u = _unitOfWork.AccountsRepository.GetAll();
            return u;
        }
    }
}