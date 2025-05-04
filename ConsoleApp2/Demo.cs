using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlearn
{
	// Methods syntax (simple)
	// <accessModifier> <DataType/void> <methodName>(<parameters>)
	// {
	// <method body>
	// }
	public class Demo
	{
        // age is a parameter
        //      public void dosomething(int age , double salary)
        //{
        //	age = age + 3;
        //}
        //method signature (name + parameters type + parameter order)
        //public void dosomething(int age , double salary)
        //{
        //          age = age + 3;
        //      }
        //this does not work because the method signature is the same (same name and same parameters with
        // same type and order , (order) ==> معناها ترتيب )

        //method overloading (same name but different parameters, and it is way of polymorphism)

        //imgine that we have a company that need to promote the employees with salar and another
        //pormotion salary and fly ticket and another one with salary and  fly ticket and room in hotel
        //public void pormote  (int salary)
        //{
        //    Console.WriteLine("Pormotion with salary");
        //    Console.WriteLine($"Salary: {salary}");
        //}
        //public void pormote(int salary, string flyticket)
        //{
        //    Console.WriteLine("Pormotion with salary and fly ticket");
        //    Console.WriteLine($"Salary: {salary}");
        //    Console.WriteLine($"Fly ticket: {flyticket}");
        //}
        //public void pormote(int salary, string flyticket, string room)
        //{
        //    Console.WriteLine("Pormotion with salary and fly ticket and room");
        //    Console.WriteLine($"Salary: {salary}");
        //    Console.WriteLine($"Fly ticket: {flyticket}");
        //    Console.WriteLine($"Room: {room}");
        //}

        //expression body method
        //public bool IsEven(int number) => number % 2 == 0;

        // local method 
        //public void printeven(int[] nums)
        //{
        //    // local method that reference to the method that contains it only
        //    bool ISEven(int number) => number % 2 == 0;
        //    foreach (var num in nums)
        //    {
        //        if (ISEven(num))
        //        {
        //            Console.WriteLine($"The number {num} is even");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"The number {num} is not even");
        //        }
        //    }
        //}
        // static method work with static method or local method 
        //public static void printeven(int[] nums)
        //{
        //    // local method that reference to the method that contains it only
        //    foreach (var num in nums)
        //    {
        //        if (ISEven(num)) // gives error becouse the method ISEven is not static
        //        {
        //            Console.WriteLine($"The number {num} is even");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"The number {num} is not even");
        //        }
        //    }
        //    // you can also make ISEven local method and it will work (it is best way) like :
        //    //bool ISEven(int number) => number % 2 == 0;
        //}
        //public static bool ISEven(int number) => number % 2 == 0;


    }
}
