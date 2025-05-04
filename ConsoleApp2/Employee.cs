using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{   // <classModifier> -> public, private, internal (default), protected
	// <classModifier> class <className>
	//{
	//	class block
	//}
	public class Employee
	{
		// <accessModifier> -> public, private, protected
		// costants -> <accessModifier> const <dataType> <constantName> = <value>; you must assign value to the constant
		//public const double TAX = 0.03;
		// <accessModifier> static <dataType> <constantName> = <value>; you must assign value to the constant
		public static double TAX = 0.03;
		// fields -> <accessModifier> <dataType> <fieldName> = <initialvalue>; you can don`t assign initial value to the field
		public string FirstName;
		public string LastName;
		public double Wage;
		public double LoggedHours;
		public Employee (int wage)
		{
            this.Wage = wage;
        }
		public void takeinfofromemp ()
        {
            Console.WriteLine("Enter First Name");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter Wage");
            Wage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Logged Hours");
            LoggedHours = Convert.ToDouble(Console.ReadLine());
        }
        // note that you use the fields by its name becouse we are into the same class	that 
        //contains the fields
        public string calculatesalary()
		{ 
			var salary = Wage * LoggedHours;
			var netsalary = salary - (salary * TAX);
			var TAXamount = TAX * 100;

			return $"\nFirst Name: {FirstName}" +
				   $"\nLast Name: {LastName}" +
				   $"\nWage: {Wage}" +
				   $"\nLogged Hours: {LoggedHours}" +
				   $"\nTAX Amount:{TAXamount}%" +
				   $"\nSalary: {Wage * LoggedHours}" +
				   $"\nNet Salary: {netsalary}";
		}
	}
	public class Player
	{
        private string fName;
        private string lName;
        private int playerNumber;
		// if you made a fields private and make a implicit constructor private you can`t
		// create an object from this class without make a method to create an object
		private Player() { }
        private Player (string fName , string lName , int playerNumber)
		{

		}
		public static Player CreatePlayer(string fName, string lName, int playerNumber)
		{

			return new Player( fName, lName, playerNumber);
        }
    }
}

