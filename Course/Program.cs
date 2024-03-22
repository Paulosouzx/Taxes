using Course.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine();
            Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or Company (i/c)? ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();

                if(resp == 'i') { 
                Console.Write("Annual Income: ");
                double annualIncome = double.Parse(Console.ReadLine());
                    Console.Write("Health expenditures: ");
                double healthExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, annualIncome, healthExpenditures));
                }
                else if (resp == 'c')
                {
                    Console.Write("Annual Income: ");
                    double annualIncome = double.Parse(Console.ReadLine());
                    Console.Write("Number of employees: ");
                    int emp = int.Parse(Console.ReadLine());
                    list.Add(new Company(name,annualIncome, emp));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            foreach (TaxPayer taxPayer in list) 
            {
                Console.WriteLine(taxPayer.Name + ": $" + taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadKey();
        }
    }
}
