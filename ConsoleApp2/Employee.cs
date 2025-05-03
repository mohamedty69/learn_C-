using System;
using System.Collections.Generic;
using System.Linq;
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
	}
}
