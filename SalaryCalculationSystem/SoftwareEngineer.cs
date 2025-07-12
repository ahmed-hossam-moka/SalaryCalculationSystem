namespace SalaryCalculationSystem
{
    internal sealed class SoftwareEngineer : Employee
    {
        public int StoryPointCompleted { get; set; }
        protected override decimal GrossAmount()
        {
            return (StoryPointCompleted>=SystemConstants.MinStoryPointCompleted)?
                base.GrossAmount() + SystemConstants.TraningAllowance + SystemConstants.Bonus:
                base.GrossAmount() + SystemConstants.TraningAllowance;
        }
        public override string ShowSalary()
        {
            return
                $"Empoyee:\t    #{Id} ({FullName()})\n"
                + $"Hours Logged:\t    {LoggedHours} hrs\n"
                + $"Hour Rate:\t    {HourRate} $/hr\n"
                + $"Basic Salary:\t    {BasicSalaryAmount().ToString("C")}\n"
                + $"OverTime({(SystemConstants.OverTimeRate /10).ToString("P")}):   " +
                           $"{OverTimeSalaryAmount().ToString("C")}\n"
                + $"Traning Allowance:  {SystemConstants.TraningAllowance.ToString("C")}\n"
                + $"Bonus:\t\t    {((StoryPointCompleted >= SystemConstants.MinStoryPointCompleted) ?
                                    SystemConstants.Bonus.ToString("C") : 0.ToString("C") )}\n"
                + $"Gross Pay:\t    {GrossAmount().ToString("C")}\n"
                + $"Tax Amount({SystemConstants.TaxAmount.ToString("P")}): {TaxAmount().ToString("C")}\n"
                + $"===========================\n"
                + $"Net Salary:\t    {NetSalaryAmount().ToString("C")}\n";
        }
    }
}
