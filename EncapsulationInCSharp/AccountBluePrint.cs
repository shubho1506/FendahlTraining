using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInCSharp
{
    interface IAccountBluePrint
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        void DisplayDetails();
    }
}
