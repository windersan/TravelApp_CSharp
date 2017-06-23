using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp.DOMAIN
{
    
    class Purchase : Transaction
    {

        private double _cost;
        private string _category;
        private string _description;
        
        private string _currency;
        private string _city;
        private string _country;

        public Purchase() { }


        public Purchase(double cost, string category, string description, string
            date, string currency, string city, string country)
        {

            _cost = cost;
            _category = category;
            _description = description;
            _date = date;
            _currency = currency;
            _city = city;
            _country = country;
        }


        public double Cost
        {
            get
            {
                return _cost;
            }

            set
            {
                _cost = value;
            }
        }

        public string Category
        {
            get
            {
                return _category;
            }

            set
            {
                _category = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
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

        public string City
        {
            get
            {
                return _city;
            }

            set
            {
                _city = value;
            }
        }

        public string Country
        {
            get
            {
                return _country;
            }

            set
            {
                _country = value;
            }
        }

        public bool Validate()
        {
            if (_category == null) return false;
            if (_description == null) return false;
            if (_date == null) return false;
            if (_currency == null) return false;
            if (_city == null) return false;
            if (_country == null) return false;
            return true;
        }

        public override string ToString()
        {
            string str = "{ " + _cost + " ; " + _category + " ; " + _description + " ; "
                + _date + " ; " + _currency + " ; " + _city + " ; " + _country + " }\n";
            return str;
        }

    }
}
