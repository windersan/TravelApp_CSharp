using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApp.DOMAIN;
namespace TravelApp.SERVICE
{
    public interface IAccountSvc : IService
    {
        void GenerateJSON(Account a);

        Account GenerateAccount();

        List<Transaction> GenerateTList();
    }
}
