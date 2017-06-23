using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TravelApp.DOMAIN;
using TravelApp.SERVICE;

namespace TravelApp.BUSINESS
{
  
        public abstract class Manager
        {
            private Factory factory = Factory.GetInstance();

            protected IService GetService(String name)
            {
                return factory.GetService(name);
            }
        }

    
}
