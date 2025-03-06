namespace EmployeeManagement
{
    public abstract class Employee : IEmployee
    {
        protected string name;
        protected int paymentPerHour;

        public Employee(string name, int paymentPerHour)
        {
            this.name = name;
            this.paymentPerHour = paymentPerHour;
        }

        public string getName()
        {
            return name;
        }

        public abstract int calculateSalary();
        public void setName(string name)
        {
            this.name = name;
        }
        public void setPaymentPerHour(int paymentPerHour)
        {
            this.paymentPerHour = paymentPerHour;
        }

        public int getPaymentPerHour()
        {
            return paymentPerHour;
        }
    }
}