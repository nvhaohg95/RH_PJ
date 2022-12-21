using RH_PJ.Models;


namespace RH_PJ.Base
{
   public class BusinessBase
    {
        protected static RH_PJContext db = new RH_PJContext();
        protected static UnitOfWork _unitOfWork;

        public virtual void Init(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
