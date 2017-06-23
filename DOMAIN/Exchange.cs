using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp.DOMAIN
{
    //An exchange of currencies
    class Exchange : Transaction
    {
        private double _inAmt;
        private string _inCurr;
        private double _outAmt;
        private string _outCurr;

        public Exchange() { }
        public Exchange(double in_amt, string in_curr, double out_amt, string out_curr,
            string date) {
            InAmt = in_amt;
            InCurr = in_curr;
            OutAmt = out_amt;
            OutCurr = out_curr;
            _date = date;
        }

        public double InAmt
        {
            get
            {
                return _inAmt;
            }

            set
            {
                _inAmt = value;
            }
        }

        public string InCurr
        {
            get
            {
                return _inCurr;
            }

            set
            {
                _inCurr = value;
            }
        }

        public double OutAmt
        {
            get
            {
                return _outAmt;
            }

            set
            {
                _outAmt = value;
            }
        }

        public string OutCurr
        {
            get
            {
                return _outCurr;
            }

            set
            {
                _outCurr = value;
            }
        }

        public override string ToString() {
            string str = "{ " + InAmt + " ; " + InCurr + " ; " +
                + OutAmt + ";" + OutCurr + ";" + _date + " }\n";
            return str;
        }
    }
}
