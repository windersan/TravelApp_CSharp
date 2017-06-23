using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp.DOMAIN
{
    //This class is to encapsulate an Account together with multiple Transactions

    //This class was primarily built for unit testing during development.
    class User
    {
        
        public List<Transaction> _transactions;
        public Account _account;

        internal List<Transaction> Transactions
        {
            get
            {
                return _transactions;
            }

            set
            {
                _transactions = value;
            }
        }

        internal Account Account
        {
            get
            {
                return _account;
            }

            set
            {
                _account = value;
            }
        }

        public User() {
            _transactions = new List<Transaction>();


        }

        public void AddTransaction(Transaction t) {
            Transactions.Add(t);
        }

        public void DeleteTransaction(Transaction t) {
            Transactions.Remove(t);
        }

        public string ToString() {
            string str = "Transactions: \n";
            foreach (Transaction t in Transactions)
            {
                str = str + t.ToString();
            }
            return str;

        }
    }
}
