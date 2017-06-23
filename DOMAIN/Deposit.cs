using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp.DOMAIN
{
    class Deposit : Transaction
    {
       
        private double _amt;
        private string _currency;

        public Deposit() { }
        public Deposit(double amt, string curr, string date) {
            _amt = amt;
            _currency = curr;
          
            _date = date;
        }

        public double Amt
        {
            get
            {
                return _amt;
            }

            set
            {
                _amt = value;
            }
        }

        public string Currency
        {
            get
            {
                return _currency;
            }

            set
            {
                _currency = value;
            }
        }

        

        public override string ToString()
        {
            string str = "{ " + _amt + " ; " + _currency + ";" + _date + " }\n";
            return str;
        }


    }
}
