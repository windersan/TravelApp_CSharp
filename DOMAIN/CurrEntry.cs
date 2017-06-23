using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp.DOMAIN
{
    //This class represents tokens such as "$10" or "€2,100.23"
    public class CurrEntry
    {

        private double _amount ;
        private string _currency;


        public CurrEntry() { }

        public CurrEntry(double f, string s)
        {
            this.Amount = f;
            this.Currency = s;
        }


        public double Amount
        {
            get
            {
                return _amount;
            }

            set
            {
                _amount = value;
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

        public bool Validate() {
            if (_currency == null) return false;
            return true;
        }

        public override string ToString() {
            string str = "{ " + _amount + " ; " + _currency + " }";
            return str;
        }

    }
}
