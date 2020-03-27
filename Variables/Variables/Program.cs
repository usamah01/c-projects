 using System;

namespace Variables
{
    public class Employee
    {
        int _empId = 0;
        string _firstName = String.Empty;
        string _lastName = String.Empty;
        decimal _salaryAmount = 0;
        char _gender = '\0';
        bool _isExisting = false;

        public Employee(int empId, string firstName, string lastName, decimal salaryAmount, char gender, bool isExisting)
        {
            _empId = empId;
            _firstName = firstName;
            _lastName = lastName;
            _salaryAmount = salaryAmount;
            _gender = gender;
            _isExisting = isExisting;

        }
        public void UpdateSalaryAmount (decimal salaryAmount)
 
        {
            _salaryAmount = salaryAmount;
        }

        public string EmployeeData()
        {
        string employeeData = $"empId: {_empId}, firstName: {_firstName}, salary Amount {_salaryAmount}";

        return employeeData;
        }

    }   

    class Program
    {
        static void Main(string[] args)
        {
            int empId = 0;
            string firstName = String.Empty;
            string lastName = String.Empty;
            decimal salaryAmount = 0;
            char gender = '\0';
            bool isExisting = true;

            Console.WriteLine("Please enter the Employee ID");

            empId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the Employee's first name");

            firstName = Console.ReadLine();

            Console.WriteLine("Please enter the Employee's last name");

            lastName = Console.ReadLine();

            Console.WriteLine("Please input the salary of the Employee");

            salaryAmount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the gender of the Employee, 'M' for Male and 'F' for Female");

            gender = Convert.ToChar(Console.ReadLine()); 
            Console.WriteLine("True or False, the Employee is an existing member of the Company?");

            isExisting = Convert.ToBoolean(Console.ReadLine());

            Employee employee = new Employee(empId, firstName, lastName, salaryAmount, gender, isExisting);

            Console.Clear();

            Employee employeeCopy = employee;

            Console.WriteLine("Employee data " + employee.EmployeeData());

            Console.WriteLine();

            Console.WriteLine("Employee copy data " + employeeCopy.EmployeeData());

            Console.WriteLine();

        Console.WriteLine("Please update the employee's salary amount");

        employee.UpdateSalaryAmount(Convert.ToDecimal(Console.ReadLine()));

        string dividerText = "After salary update";

        Console.WriteLine(new String('-',dividerText.Length));
        Console.WriteLine(dividerText);
        Console.WriteLine(new String('-', dividerText.Length));

        Console.WriteLine("Employee data " + employee.EmployeeData());

        Console.WriteLine();

        Console.WriteLine("Employee copy data " + employeeCopy.EmployeeData());


        }
    }
}
