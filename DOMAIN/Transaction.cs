using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp.DOMAIN
{
    //This class is a base class for a financial entry
    public abstract class Transaction
    {
        


        
       
        
        protected string _date;
        
       
        

        public Transaction() { }


        




        

        public string Date
        {
            get
            {
                return _date;
            }

            set
            {
                _date = value;
            }
        }



        public abstract string ToString();
           
        
        
            
        
            
       

       

    }
}
