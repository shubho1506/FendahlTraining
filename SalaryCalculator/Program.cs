using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaxUtility.WelcomeMessage();

            Console.WriteLine("Enter name :");
            string name = Console.ReadLine();

            Console.Write("Enter CTC: ");
            decimal ctc = Convert.ToDecimal(Console.ReadLine());

            Employee emp = new Employee { Name = name, CTC = ctc };
            emp.ShowEmployeeDetails();

            SalaryTax taxCalculator = new SalaryTax(ctc);
            taxCalculator.CalculateIncomeTax();
            taxCalculator.DisplaySalaryDetails();

            Company.FinanceDepartment.TaxGuidelines();
        }
    }
}

public abstract class IncomeTaxCalculator
{
    public abstract void CalculateIncomeTax();
}

public class SalaryTax : IncomeTaxCalculator
{
    private decimal CTC;
    private decimal totalTax = 0;
    private decimal inHandSalary = 0;
    private const decimal standardDeduction = 75000;
    private const decimal rebateAmount = 60000;
    private const decimal rebateThreshold = 1200000;

    public SalaryTax(decimal ctc)
    {
        this.CTC = ctc;
    }

    public override void CalculateIncomeTax()
    {
        decimal taxableIncome = CTC - standardDeduction;

        if (taxableIncome <= rebateThreshold)
        {
            totalTax = 0;
        }
        else
        {
            totalTax -= rebateAmount;
            totalTax = totalTax < 0 ? 0 : totalTax;

            decimal[] taxSlabs = { 400000, 800000, 1200000, 1600000, 2000000, 2400000 };
            decimal[] taxRates = { 0.00m, 0.05m, 0.10m, 0.15m, 0.20m, 0.25m, 0.30m }; 
            decimal previousSlab = rebateThreshold;
            decimal slabTax = 0;


            for (int i = 0; i < taxSlabs.Length; i++)
            {
                if (taxableIncome > taxSlabs[i])
                {
                    slabTax = (taxSlabs[i] - previousSlab) * taxRates[i];
                    totalTax += slabTax;
                    previousSlab = taxSlabs[i];
                }
                else
                {
                    slabTax = (taxableIncome - previousSlab) * taxRates[i];
                    totalTax += slabTax;
                    break;
                }
            }
        }

        inHandSalary = CTC - totalTax;
    }

    public void DisplaySalaryDetails()
    {
        Console.WriteLine($"\n Your Total Tax Deduction : {totalTax} rs");
        Console.WriteLine($"Your In-Hand Salary : {inHandSalary} rs");
    }
}

public static class TaxUtility
{
    public static void WelcomeMessage()
    {
        Console.WriteLine("\nIncome Tax & Salary Calculator (As per New Regime) ");
    }
}

public partial class Employee
{
    public string Name { get; set; }
    public decimal CTC { get; set; }
}

public partial class Employee
{
    public void ShowEmployeeDetails()
    {
        Console.WriteLine($"\nEmployee Name : {Name}, CTC : {CTC} rs");
    }
}

public sealed class Manager : Employee
{
    public string Department { get; set; }
}

public class Company
{
    public class FinanceDepartment
    {
        public static void TaxGuidelines()
        {
            Console.WriteLine("Tax slabs updated for FY 2025-26.");
        }
    }
}
