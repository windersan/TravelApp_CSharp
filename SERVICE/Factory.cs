using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using TravelApp.DOMAIN;
using System.Collections.Specialized;

namespace TravelApp.SERVICE
{
    class Factory
    {
        
        

        

        private Factory() { }
        private static Factory factory = new Factory();
        public static Factory GetInstance() { return factory; }


       

        public IService GetService(string name){
           
            Object obj = null;
            
           try
            {
               Type type = Type.GetType(GetImplName(name));
          
                obj = Activator.CreateInstance(type);

                
            }
            catch (Exception e)
            {
               Console.WriteLine("Exception occured: {0}", e);
                
                throw e;
            }



            
            return (IService)obj;

        }
        public string GetImplName(string servicename){
            NameValueCollection settings = ConfigurationSettings.AppSettings;
           
            return settings.Get(servicename);

        }







        public ITransactionSvc GetTransactionSvc(){
            return new TransactionSvcJSONImpl();
        }

        public IAccountSvc GetAccountSvc() {
            return new AccountSvcJSONImpl();
        }

    }
}
