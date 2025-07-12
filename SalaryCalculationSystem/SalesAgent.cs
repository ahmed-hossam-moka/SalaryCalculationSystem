namespace SalaryCalculationSystem
{
    internal sealed class SalesAgent : Employee
    {
        public decimal TotalSales { get; set; }
        protected override decimal GrossAmount()
        {
            return base.GrossAmount() + (TotalSales * SystemConstants.Comission);
        }
        public override string ShowSalary()
        {
            return
                $"Empoyee:\t    #{Id} ({FullName()})\n"
                + $"Hours Logged:\t    {LoggedHours} hrs\n"
                + $"Hour Rate:\t    {HourRate} $/hr\n"
                + $"Basic Salary:\t    {BasicSalaryAmount().ToString("C")}\n"
                + $"OverTime({(SystemConstants.OverTimeRate / 10).ToString("P")}):  " +
                                                    $" {OverTimeSalaryAmount().ToString("C")}\n"
                + $"Total Seles:\t    {TotalSales.ToString("C")}\n"
                + $"Comission({(SystemConstants.Comission).ToString("P")}):   " +
                                $"{(TotalSales * SystemConstants.Comission).ToString("C")} \n"
                + $"Allowance:\t    {SystemConstants.Allowance.ToString("C")}\n"
                + $"Gross Pay:\t    {GrossAmount().ToString("C")}\n"
                + $"Tax Amount({SystemConstants.TaxAmount.ToString("P")}): {TaxAmount().ToString("C")}\n"
                + $"===========================\n"
                + $"Net Salary:\t    {NetSalaryAmount().ToString("C")}\n";
        }
    }
}
