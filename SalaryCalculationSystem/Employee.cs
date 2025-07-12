namespace SalaryCalculationSystem
{
    internal abstract class Employee
    {
        public string Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public decimal HourRate { get; set; }
        public int ExpectedHours { get; set; }
        public int LoggedHours { get; set; }

        protected string FullName() { return $"{Fname} {Lname}"; }
        private int overHours()
        {
            int flag = LoggedHours - ExpectedHours;
            return  Math.Max(flag, 0);
        }

        protected decimal BasicSalaryAmount()
        {

            return HourRate * (LoggedHours - overHours()) ;
        }

        protected decimal OverTimeSalaryAmount()
        {
            return overHours() * HourRate * SystemConstants.OverTimeRate ;
        }

        protected virtual decimal GrossAmount()
        {
            return BasicSalaryAmount() + OverTimeSalaryAmount();
        }

        protected decimal TaxAmount()
        {
            return GrossAmount() * SystemConstants.TaxAmount;
        }

        protected decimal NetSalaryAmount()
        {
            return GrossAmount() - TaxAmount();
        }

        public abstract string ShowSalary();

    }
}
