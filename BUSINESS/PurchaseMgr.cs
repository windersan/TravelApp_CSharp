using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TravelApp.DOMAIN;
using TravelApp.SERVICE;

namespace TravelApp.BUSINESS
{
    class PurchaseMgr : Manager
    {
        public PurchaseMgr() { }



        public void ProcessPurchase(Purchase p, Account a, IList<Transaction> tt)
        {
            Factory factory = Factory.GetInstance();



            IAccountSvc AccountSvc =
               (IAccountSvc)factory.GetService(typeof(IAccountSvc).Name);
            ITransactionSvc TransactionSvc =
                (ITransactionSvc)factory.GetService(typeof(ITransactionSvc).Name);

            TransactionSvc.ProcessTransaction(p, tt);

           

            var entry = from e in a.Entries
                        where e.Currency == p.Currency
                        select e;
            //Subtract cost 
            if (entry.FirstOrDefault() != null)
            {
                entry.FirstOrDefault().Amount -= p.Cost;
            }
            
            //Display message if for some reason we don't have any of the currency
            else Console.WriteLine("ERROR: CANNOT EXCHANGE CURRENCY: " + p.Currency);

            AccountSvc.GenerateJSON(a);

        }


    }
}
