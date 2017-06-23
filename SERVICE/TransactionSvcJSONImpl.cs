using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TravelApp.DOMAIN;

namespace TravelApp.SERVICE
{
    class TransactionSvcJSONImpl : ITransactionSvc
    {
        public TransactionSvcJSONImpl() { }

        //Add a transaction to the transaction list and update the JSON
        //Here we are serializing the entire list of transactions
        public void ProcessTransaction(Transaction t, IList<Transaction> tt)
        {
            tt.Add(t);


            string jsonOutput = JsonConvert.SerializeObject(tt,  Newtonsoft.Json.Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });


            try
            {
                File.WriteAllText("Transactions.JSON", jsonOutput);
            }
            catch (IOException)
            {
                Console.WriteLine("IO");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
        }

    }
}
