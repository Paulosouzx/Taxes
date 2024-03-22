using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployes { get; set; }

        public Company() 
        {
        }

        public Company(string name, double annualIncome, int numberOfEmployes) : base(name, annualIncome)
        {
            NumberOfEmployes = numberOfEmployes;
        }

        public override double Tax()
        {
            if (NumberOfEmployes > 10) 
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }
    }
}
