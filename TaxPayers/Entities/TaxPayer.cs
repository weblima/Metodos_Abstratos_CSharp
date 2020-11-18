﻿namespace TaxPayers.Entities {
   abstract class TaxPayer {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer() {
        }
        public TaxPayer(string name, double anualIncome) {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }

  
}
