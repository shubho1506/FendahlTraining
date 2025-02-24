using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExamples
{
    //2. Bank Loan Interest Calculation
    //Scenario: A bank offers different types of loans with varying interest rates.
    //•	Overload CalculateInterest() to: 
    //1.	Calculate interest for a personal loan
    //2.	Calculate interest for a home loan with a special discount
    //3.	Calculate interest for a custom loan with extra parameters
    class LoanAccount
    {
        internal long LoanNumber { get; set; }
        internal string LoanHolderName { get; set; }
        internal string LoanType { get; set; }
        internal double PrincipleAmount { get; set; }

        public LoanAccount(long loanNumber, string loanHolderName, string loanType, double principleAmount)
        {
            LoanNumber = loanNumber;
            LoanHolderName = loanHolderName;
            LoanType = loanType;
            PrincipleAmount = principleAmount;
        }
    }
}
