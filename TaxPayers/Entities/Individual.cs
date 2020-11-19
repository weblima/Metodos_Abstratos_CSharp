using System;
using System.Collections.Generic;
using System.Text;

namespace TaxPayers.Entities {
    class Individual : TaxPayer {

        public Double HealthExpenditures { get; set; }

        public Individual() {

        }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome) {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax() {

            double IndividualTax = (AnualIncome * 0.25);

            if (AnualIncome < 20000.00) {
                IndividualTax = (AnualIncome * 0.15);
            }
           
            if (HealthExpenditures > 0) {
                IndividualTax -= (HealthExpenditures * 0.5);
            }

            return IndividualTax;
        }
    }
}
