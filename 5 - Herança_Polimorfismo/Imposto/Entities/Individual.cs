using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imposto.Entities;

namespace Imposto.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }
        
        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0.0;
            if (AnualIncome < 20000.0)
            {
                tax += AnualIncome * 0.15;
            }
            else
            {
                tax += AnualIncome * 0.25;
            }

            if (HealthExpenditures > 0.0)
            {
                tax -= HealthExpenditures * 0.5;
            }

            return tax;
        }
    }
}
