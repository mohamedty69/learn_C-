using ConsoleApp2;
using OOPlearn;

namespace FIFO.OOPlearn
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//object (Instance) syntax 
			//Declaration  <type> <objectName> ;
			//assignment <objectName> = new <type>();
			//object initialization <type > <objectName> = new <type>();
			//note: you can use the same name for the object and the class
			//note : if you want to access a constant , you must use the class name like :
			// Employee.TAX

			//Employee e1 = new Employee();
			//Employee[] emps = new Employee[2];
			//Employee.TAX = 0.05; // changing the value of the constant
			//Console.WriteLine("First Employee");
			//Console.WriteLine("Enter First Name");
			//e1.FirstName = Console.ReadLine();
			//Console.WriteLine("Enter Last Name");
			//e1.LastName = Console.ReadLine();
			//Console.WriteLine("Enter Wage");
			//e1.Wage = Convert.ToDouble(Console.ReadLine());
			//Console.WriteLine("Enter Logged Hours");
			//e1.LoggedHours = Convert.ToDouble(Console.ReadLine());
			//emps[0] = e1; // assigning the first employee data to the array by assigning the object to the array
			//Employee e2 = new Employee();
			//Console.WriteLine("Second Employee");
			//Console.WriteLine("Enter First Name");
			//e2.FirstName = Console.ReadLine();
			//Console.WriteLine("Enter Last Name");
			//e2.LastName = Console.ReadLine();
			//Console.WriteLine("Enter Wage");
			//e2.Wage = Convert.ToDouble(Console.ReadLine());
			//Console.WriteLine("Enter Logged Hours");
			//e2.LoggedHours = Convert.ToDouble(Console.ReadLine());
			//emps[1] = e2;
			//foreach (var emp in emps)
			//{
			//	var salary = emp.Wage * emp.LoggedHours;
			//	var netsalary = salary - (salary * Employee.TAX);
			//	var TAXamount = Employee.TAX * 100;
			//	Console.WriteLine($"First Name: {emp.FirstName}");
			//	Console.WriteLine($"Last Name: {emp.LastName}");
			//	Console.WriteLine($"Wage: {emp.Wage}");
			//	Console.WriteLine($"Logged Hours: {emp.LoggedHours}");
			//	Console.WriteLine($"TAX Amount:{TAXamount}%");
			//	Console.WriteLine($"Salary: {emp.Wage * emp.LoggedHours}");
			//	Console.WriteLine($"Net Salary: {netsalary}");
			//	Console.WriteLine("=====================================");
			//}

			//================================================================
			//note : you call the method from a class so you must use object (instance) to call the method
			Demo d1 = new Demo();
			d1.doSomething();
		}
	}
}