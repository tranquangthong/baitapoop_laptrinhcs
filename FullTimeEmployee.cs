namespace EmployeeManagement
{

    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, int paymentPerHour)
            : base(name, paymentPerHour)
        {
        }
        public override int calculateSalary()
        {
            const int WORKING_HOURS_PER_DAY = 8;
            const int WORKING_DAYS_PER_MONTH = 20;
            return paymentPerHour * WORKING_HOURS_PER_DAY * WORKING_DAYS_PER_MONTH;
        }
    }
}