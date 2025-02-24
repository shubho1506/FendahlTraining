using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExamples
{
    class BankLoanInterestRates
    {
        internal double getInterestRates(string loanType)
        {
            if (loanType == "Home")
                return 10;
            return 15;
        }
    }
}
