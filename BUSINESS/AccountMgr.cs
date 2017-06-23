using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TravelApp.DOMAIN;
using TravelApp.SERVICE;

namespace TravelApp.BUSINESS
{
    class AccountMgr : Manager
    {


        public Account GenerateAccount()
        {
            Factory factory = Factory.GetInstance();
            IAccountSvc AccountSvc =
                   (IAccountSvc)factory.GetService(typeof(IAccountSvc).Name);

            Account account = AccountSvc.GenerateAccount();
            return account;

        }

        public IList<Transaction> GenerateTList()
        {
            Factory factory = Factory.GetInstance();
            IAccountSvc AccountSvc =
                   (IAccountSvc)factory.GetService(typeof(IAccountSvc).Name);

            IList<Transaction> tt = AccountSvc.GenerateTList();
            return tt;

        }


        public void Clear() {
            Factory factory = Factory.GetInstance();
            IAccountSvc AccountSvc =
                   (IAccountSvc)factory.GetService(typeof(IAccountSvc).Name);

            Account account = new Account();
            AccountSvc.GenerateJSON(account);


        }
    }
}
