using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TravelApp.DOMAIN;
using TravelApp.SERVICE;

namespace TravelApp.BUSINESS
{
    class ExchangeMgr : Manager
    {
        public ExchangeMgr() { }


        


        public void ProcessExchange(Exchange d, Account a, IList<Transaction> tt)
        {
            Factory factory = Factory.GetInstance();



            IAccountSvc AccountSvc =
               (IAccountSvc)factory.GetService(typeof(IAccountSvc).Name);
            ITransactionSvc TransactionSvc =
                (ITransactionSvc)factory.GetService(typeof(ITransactionSvc).Name);

            TransactionSvc.ProcessTransaction(d, tt);

            

            var entry = from e in a.Entries
                        where e.Currency == d.OutCurr
                        select e;
            //Add to the currency if it's already there
            if (entry.FirstOrDefault() != null)
            {
                entry.FirstOrDefault().Amount += d.OutAmt;
            }
            //If the currency isn't there yet, we must add it
            else
            {
                CurrEntry c = new CurrEntry(d.OutAmt, d.OutCurr);
                a.AddCurrency(c);
            }

            var entry2 = from e2 in a.Entries
                         where e2.Currency == d.InCurr
                         select e2;
            if (entry2.FirstOrDefault() != null)
            {
                entry2.FirstOrDefault().Amount -= d.InAmt;
              
            }
            //Display message if for some reason we don't have any of the input currency
            else Console.WriteLine("ERROR: CANNOT EXCHANGE CURRENCY: " + d.InCurr);

            AccountSvc.GenerateJSON(a);

        }




    }
}
