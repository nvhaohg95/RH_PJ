using RH_PJ.Models;
using System;
using System.Threading.Tasks;

namespace RH_PJ.Base
{
    public class UnitOfWork : IDisposable
    {
        public RH_PJContext DbContext { get; }

        public IRepository<tbl_Account> AccountsRepository { get; }
        public IRepository<tbl_AccountInfo> AccountInfoRepository { get; }

        public UnitOfWork(RH_PJContext context,
             IRepository<tbl_Account> accs,
             IRepository<tbl_AccountInfo> acc_info)
        {
            DbContext = context;
            AccountsRepository = accs;
            AccountsRepository.DbContext = DbContext;

            AccountInfoRepository = acc_info;
            AccountInfoRepository.DbContext = DbContext;    
        }

        public int SaveChanges()
        {
            var iResult = DbContext.SaveChanges();
            return iResult;
        }

        public async Task<int> SaveChangesAsync()
        {
            var iResult = await DbContext.SaveChangesAsync();
            return iResult;
        }

        public void Dispose()
        {
            DbContext.Dispose();
        }
    }
}
