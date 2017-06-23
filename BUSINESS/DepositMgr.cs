using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TravelApp.DOMAIN;
using TravelApp.SERVICE;

namespace TravelApp.BUSINESS
{
    class DepositMgr : Manager
    {
        public DepositMgr() { }
       

        public void ProcessDeposit(Deposit d, Account a, IList<Transaction> tt) {
            Factory factory = Factory.GetInstance();
            IAccountSvc AccountSvc =
                   (IAccountSvc)factory.GetService(typeof(IAccountSvc).Name);
         

            ITransactionSvc TransactionSvc =
                (ITransactionSvc)factory.GetService(typeof(ITransactionSvc).Name);
         

            TransactionSvc.ProcessTransaction(d, tt);

           

            var entry = from e in a.Entries
                        where e.Currency == d.Currency
                        select e;
            //Add to the currency if it's already there
            if (entry.FirstOrDefault() != null)
            {
                entry.FirstOrDefault().Amount += d.Amt;
            }
            //If the currency isn't there yet, we must add it
            else {
                CurrEntry c = new CurrEntry(d.Amt, d.Currency);
                a.AddCurrency(c);
            }

            AccountSvc.GenerateJSON(a);
            Console.WriteLine();
            Console.WriteLine(d.ToString());
            Console.WriteLine();
        }


        
    }


}

