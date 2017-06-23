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
    class AccountSvcJSONImpl : IAccountSvc
    {
        public AccountSvcJSONImpl() { }

        public void GenerateJSON(Account a){
            Console.WriteLine("ACCOUNT: " + a);
            string jsonOutput = JsonConvert.SerializeObject(a);
            ///,Newtonsoft.Json.Formatting.Indented, new JsonSerializerSettings
            /// {
            ///    TypeNameHandling = TypeNameHandling.All
            ///  });
              
            Console.WriteLine("JSON: " + jsonOutput);
            File.WriteAllText("Account.JSON", jsonOutput);
            
        }

        


        public Account GenerateAccount() {

            string JSON;
            Account account = new Account();

            try
            {
                
                JSON = System.IO.File.ReadAllText("Account.JSON");
                account = JsonConvert.DeserializeObject<Account>(JSON);
                return account;

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Not found");
            }
            catch (IOException)
            {
                Console.WriteLine("IO");
            }
            catch(Exception e){
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }

            return account;
           



            
            
        }



        public List<Transaction> GenerateTList()
        {
            List<Transaction> tt =  new List<Transaction>();

            try
            {
                
                string JSON = System.IO.File.ReadAllText("Transactions.JSON");

                

                tt = JsonConvert.DeserializeObject<List<Transaction>>(JSON, new JsonSerializerSettings
                 {
                     TypeNameHandling = TypeNameHandling.All
                 });
               // Console.WriteLine("IN JSON BLOCK");
                return tt;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Not found");
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

            return tt;

        }



    }
}
