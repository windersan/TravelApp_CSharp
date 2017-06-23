using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp.DOMAIN
{
    //This class is for storing total currency amounts
    public class Account
    {
        private List<CurrEntry> entries;


        public Account(){
            Entries = new List<CurrEntry>();
           
        }

        public List<CurrEntry> Entries
        {
            get
            {
                return entries;
            }

            set
            {
                entries = value;
            }
        }




        //Function to add a new currency to the account. 
        public void AddCurrency(CurrEntry c) {
            Entries.Add(c);
        }

        //Functon to delete a given currency from the account.
        public void DeleteCurrency(string s)
        {
            var entry = from e in Entries
                          where e.Currency == s
                          select e;
           
           Entries.Remove(entry.FirstOrDefault());
            
        }


        public override string ToString() {
            string str = "Currencies { ";
            foreach (CurrEntry c in Entries) {
                str = str + c.Amount + " " + c.Currency + " " ;
            }
            str = str + "}";
            return str;
        }


        public string Print()
        {
            string str = "Currencies@ ";
            foreach (CurrEntry c in Entries)
            {
                str = str + c.Amount + " " + c.Currency + " " + "@ ";
            }
           
           str = str.Replace("@",  System.Environment.NewLine);
            return str;
        }



    }
}
