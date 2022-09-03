using System;
using System.Configuration;

namespace DesignPatternsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaxCalculatorFactory factory = new TaxCalculatorFactory();

            BillingSystem billingSystem = new BillingSystem(factory.CreateTaxCalculator());
            billingSystem.GenerateBill();
        }
    }


    class TaxCalculatorFactory
    {
        public ITaxCalculator CreateTaxCalculator()
        {
            // read the config file for tax calculator class
            string taxClassName = ConfigurationManager.AppSettings["TAX"];
            // using reflextion
            Type theType = Type.GetType(taxClassName);
            return (ITaxCalculator)Activator.CreateInstance(theType);
            //return new APTaxCalculator();
        }
    }

    class BillingSystem
    {
        private ITaxCalculator taxCalc;
        public BillingSystem(ITaxCalculator tax)
        {
            this.taxCalc = tax;
        }
        public void GenerateBill()
        {
            // find the total of all the items
            double totalAmount = 5600.00;
            // calculate any discounts
            double discount = 250.00;
            // calculate taxes
            //ITaxCalculator taxCalc = new KATaxCalculator();
            double tax = taxCalc.CalculateTax(totalAmount - discount);
            double finalBillAmount = totalAmount - discount + tax;
            Console.WriteLine($"Total bill amount is {finalBillAmount}");
            // generate final bill
            // print the bill

        }
    }
    // Tax Calculator Strategy
    interface ITaxCalculator
    {
        double CalculateTax(double amount);
    }

    class TSTaxCalculator : ITaxCalculator
    {
        public double CalculateTax(double amount)
        {
            // Telangana Tax calculator
            int cst = 120;
            int tst = 100;
            int es = 50;
            int lt = 70;
            double tax = cst + tst + es + lt;

            Console.WriteLine("Using TS Tax Calculator");
            return tax;
        }
    }


    class APTaxCalculator : ITaxCalculator
    {
        public double CalculateTax(double amount)
        {
            // AP Tax calculator
            int cst = 120;
            int apst = 150;
            int kkt = 70;
            int lt = 170;
            double tax = cst + apst + kkt + lt;
            Console.WriteLine("Using AP Tax Calculator");
            return tax;
        }
    }

    class KATaxCalculator : ITaxCalculator
    {
        public double CalculateTax(double amount)
        {
            double tax = 45 + 67 + 36 + 89;
            Console.WriteLine("Using KA tax calculator");
            return tax;
        }
    }



    class USTaxCalculatorAdaptor : ITaxCalculator
    {
        public double CalculateTax(double amount)
        {
            USTaxCalculator us = new USTaxCalculator();
            double tax = us.ComputeTax((float)amount);
            Console.WriteLine("Using US Tax Calculator");
            return tax;
        }
    }

    class USTaxCalculator
    {
        public float ComputeTax(float amount)
        {
            return 45 + 23 + 67 + 12;
        }
    }
}
