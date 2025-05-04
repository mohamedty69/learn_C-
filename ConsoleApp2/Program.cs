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
            //Demo d1 = new Demo();
            //int age;
            // 18 is an argument ==> that send in the call
            //d1.dosomething(age);
            //        Console.WriteLine(age); // output is 18 becouse the value is passed by value
            // if you want to pass the value by reference you must use the ref keyword
            //d1.dosomething(ref age);
            //Console.WriteLine(age); // output is 21 becouse the value is passed by reference
            // note if you want to pass the value by reference you must use the ref keyword in
            // the method signature and in the method call and make sure that the
            // parameter is not a constant or a variable and you initialize it before
            //d1.dosomething(out age); // when you use out you don`t need to initialize the variable
            //but you need to initialize it in the method
            //d1.pormote(1000);
            //d1.pormote(1000, "America");
            //d1.pormote(1000, "America", "Room 101");
            //Console.WriteLine($"{d1.IsEven(7)}");
            //int[] number = new int[] { 1, 2, 3, 4, 5 };
            //d1.printeven(number);
            //         Console.WriteLine($"The number {number} is even");
            //Employee[] emps = new Employee[2]; 
            //Employee e1 = new Employee();
            //         e1.takeinfofromemp();
            //emps[0] = e1;
            //Employee e2 = new Employee();
            //         e2.takeinfofromemp();
            //         emps[1] = e2;
            //         foreach (var emp in emps)
            //{
            //	Console.WriteLine(emp.calculatesalary());
            //}
            // can`t access the fields directly because they are private like this :
            //d1.Day = 1;
            //d1.Month = 12;
            //d1.Year = 2022;

            // you can access the fields by using the constructor
            //Date d1 = new Date(1,12,1999);
            //Console.WriteLine(d1.GetDate());

            // there is a way that called object initializer like this:
            //Employee e2 = new Employee
            //{
            //    FirstName = "AAhmed",
            //    LastName = "Ramy",
            //    LoggedHours = 0,
            //    Wage = 0
            //};
            //another way to use object initializer is to use the constructor
            //Employee e2 = new Employee(1000)
            //{
            //    FirstName = "Ahmed",
            //    LastName = "Ramy",
            //    LoggedHours = 0,
            //    Wage = 0
            //};
            //e2.takeinfofromemp();
            //Console.WriteLine(e2.calculatesalary());
            //Player p1 = Player.CreatePlayer("Ahmed", "Ramy", 1);
        }
    }
}