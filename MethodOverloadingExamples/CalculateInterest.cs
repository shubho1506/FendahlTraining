using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExamples
{
    class CalcInterest
    {
        BankLoanInterestRates rate = new BankLoanInterestRates();
        internal void CalculateInterest(LoanAccount account, double time)
        {
            Console.WriteLine($"{account.LoanHolderName} your {account.LoanType} Loan has been approved !!!");
            Console.WriteLine($"Your Loan Account Number is {account.LoanNumber}");
            Console.WriteLine($"The total interest will be {(account.PrincipleAmount * (rate.getInterestRates(account.LoanType)) * time) / 100}");
        }

        internal void CalculateInterest(LoanAccount account, double discountRate,double time)
        {
            Console.WriteLine($"{account.LoanHolderName} your {account.LoanType} Loan has been approved !!!");
            Console.WriteLine($"Your Loan Account Number is {account.LoanNumber}");
            Console.WriteLine($"The total interest will be {(account.PrincipleAmount * (rate.getInterestRates(account.LoanType)-discountRate) * time) / 100}");
        }

        internal void CalculateInterest(LoanAccount account, string type, double interest, double time)
        {
            Console.WriteLine($"{account.LoanHolderName} your {account.LoanType} Loan has been approved !!!");
            Console.WriteLine($"Your Loan Account Number is {account.LoanNumber}");
            Console.WriteLine($"The total interest will be {(account.PrincipleAmount * interest * time) / 100}");
        }

    }
}
