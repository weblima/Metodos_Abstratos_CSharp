
namespace TaxPayers.Entities {
    class Company : TaxPayer {

        public int NumberOfEmproyees { get; set; }

        public Company() {

        }
        public Company(string name, double anualIncome, int numberOfEmproyees) : base(name, anualIncome) {
            NumberOfEmproyees = numberOfEmproyees;
        }

        public override double Tax() {
            return 1;
        }
    }
}
