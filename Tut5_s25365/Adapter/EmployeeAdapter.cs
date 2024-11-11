// In case you need some guidance: https://refactoring.guru/design-patterns/adapter
namespace Tut5_s25365.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem _billingSystem = new();
        public void ProcessCompanySalary(string[,] employeesArray)
        {
            List<Employee> employeesList = new();
            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                var employee = new Employee(Convert.ToInt32(employeesArray[i, 0]),
                    employeesArray[i, 1],
                    employeesArray[i, 2],
                    Convert.ToDecimal(employeesArray[i,3]));
                
                employeesList.Add(employee);
            }
            _billingSystem.ProcessSalary(employeesList);
        }
    }
}
