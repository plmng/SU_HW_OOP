namespace pr1_HumanStudentWorker
{
    public class Worker: Human
    {
        public Worker(string firstName, string lastName, decimal salary, int hours ) : base(firstName, lastName)
        {
            this.WeekSalary = salary;
            this.WorkHoursPerDay = hours;
        }

        public decimal WeekSalary { get; set; }

        public int WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            var moneyPerHour = this.WeekSalary/(this.WorkHoursPerDay*5);
            return moneyPerHour;
        }
    }
}
