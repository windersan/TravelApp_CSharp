using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApp.DOMAIN;

namespace TravelApp.SERVICE
    
{
    public interface ITransactionSvc : IService

    {
        

        void ProcessTransaction(Transaction t, IList<Transaction> tt);
    }
}

