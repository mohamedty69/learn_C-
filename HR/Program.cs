using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using FIFO.Models.AUTO.asia.japan;

namespace FIFO.project1
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");

			//var
			//var s = 0f;
			//var s1 = 0d;
			//var s2 = 0m;
			//var s3 = 0u;
			//var s4 = 0l;
			//var s5 = 0ul;
			//int onemellion = 1_000_000;
			//string fname = "John";
			//string lname = "Doe";

			//Console.WriteLine($" {onemellion} ");
			//Console.WriteLine($" {fname} {lname} ");
			//bool isTrue = true;
			//var x = 10;
			//var y = 10;
			//var z = x == y;
			//Console.WriteLine($" {z} ");
			//var total = 1000;
			//var vipthreshold = 900;
			//var isvip = total >= vipthreshold;
			//Console.WriteLine($" {isvip} ");

			// == with refrerence types
			//var x = 1;
			//var y = 1;
			// compare the value (value type)
			//var z = x == y;
			//======================================================

			// compare the reference (reference type)
			//var s1 = "hello";
			//var s2 = "hello";
			//var s3 = s1 == s2;
			//Console.WriteLine($" {z} ");
			//Console.WriteLine($" {s3} ");
			// in the refrence type, the value is stored in the heap and the reference is stored in the stack so if the reference is different, the clr will compare the value in the heap if the value is the same, it will return true
			// ternary operator
			//var total = 900;
			//var vipthreshold = 1000;            
			//var isvip = total >= vipthreshold ? true : false;
			// if total is greater than or equal to vipthreshold, assign true to isvip else assign false to isvip
			//Console.WriteLine($" {isvip} ");
			//======================================================

			//Array (refrence type)
			// declaration
			//string[] friends = new string[5];
			//friends[0] = "John";
			//friends[1] = "Doe";
			//friends[2] = "Jane";
			//friends[3] = "Smith";
			//friends[4] = "Doe";

			// initialization ==> declaration + assignment
			//string[] friendss = new string[] 
			//{ "John", 
			//	"Doe",
			//	"Jane",
			//	"Smith",
			//	"Doe"
			//};
			//var slice = friendss[0..2]; // slice the array git the first two elements
			//var slice2 = friendss[2..]; // skip the first two elements
			//var slice3 = friendss[2..^2]; // start from the end and get the last two elements
			//Console.WriteLine($" {slice3} ");
			// multidimensional array (rectangular array)
			//int[,] soduko = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
			// jagged array (array of arrays)
			//var jaggedArray = new int[][]
			//{
			//	new int[] { 1, 2, 3 },
			//	new int[] { 4, 5, 6 },
			//	new int[] { 7, 8, 9 }
			//};
			//======================================================

			//Expressions 
			//primary expression ==> expression that can be evaluated to a value
			//var amount = Math.Cos(30);
			//Math is type look up 
			//cos is a method 
			//void expression ==> expression that does not return a value
			//Console.WriteLine($" {amount} ");
			//binary expression ==> expression that has two operands
			//var x = 10;
			//var y = 20;
			//var z = x + y;
			//Console.WriteLine($" {z} ");
			//it is a binary expression because it has two operands (x and y) and one operator (+)

			//======================================================
			//null coalescing operator
			//string name = null;
			//name = name ?? "John Doe"; // if name is null, assign "John Doe" to name
			//Console.WriteLine($" {name} ");
			//null conditional operator ==> handle null reference exception
			//string name = null;
			//name = name.ToUpper(); // if name is null, it will throw a null reference exception
			// to handle this exception, we can use the null conditional operator
			//name = name?.ToUpper(); // if name is null, it will not throw an exception, it will return null

			//=====================================================
			//statment and block of statements
			// console.WriteLine("Hello World!"); ==> statement
			//{
			////Console.WriteLine("Hello World!");
			////Console.WriteLine("Hello");
			////Console.WriteLine("World");
			//} // block of statements that execute sequentially
			//1. int x; x=10; ==> declaration statement
			// Expression statement ==> statement that has an expression
			//1.change state 
			// var name = "Issam"
			//2. assignment statement
			// name = name + "A."
			//3. call something to change state
			// var name = "Issam"
			// name.ToLower()
			//4. increment or decrement
			// var x = 10;
			// ++x ==> increment x by 1
			//console.WriteLine($" {x} "); it will be 11
			// --x ==> decrement x by 1
			//console.WriteLine($" {x} "); it will be 10
			// x++ ==> increment x by 1 but it will change the value after the one statement
			// console.WriteLine($" {x} "); it will be 10
			// console.WriteLine($" {x} "); it will be 11
			// x-- ==> decrement x by 1 but it will change the value after the one statement
			// console.WriteLine($" {x} "); it will be 11
			// console.WriteLine($" {x} "); it will be 10

			//======================================================
			// selection statement
			// if statement and else if statement and switch statement
			// iteration statement
			// while 
			// int counter = 0;
			// while (counter < 10)
			// {
			// 	Console.WriteLine($" {counter} ");
			// 	counter++;
			// }
			// do while
			// int counter = 0;
			// do
			// {
			// 	Console.WriteLine($" {counter} ");
			// 	counter++;
			// } while (counter < 10); ==> will excute the block of code at least once after it will test the condition
			// for loop 
			//var current = 1;
			//var prev = 0;
			//for (int i = 0; i < 10; i++)
			//{
			//	Console.WriteLine($" {prev} ");
			//	var fibbonaci = current + prev;
			//	prev = current;
			//	current = fibbonaci;
			//}
			// foreach loop
			//foreach (char c in "full stack developer")
			//{
			//	Console.WriteLine($" {c} ");
			//}
			//var arr = new int[] { 1, 2, 3, 4, 5 };
			//foreach (var item in arr)
			//{
			//	Console.WriteLine($" {item} ");
			//}
			//======================================================
			// jump statement [break, continue, return , goto]
			//======================================================

			// data types as objects
			//int x = 10;
			//int16 y = 20; ==> short s ; 16 bits
			//int32 z = 30; ==> int i ; 32 bits
			//int64 w = 40; ==> long l ; 64 bits  
			// the [int16 ,int32 , int64] are the same as [short, int, long] are illus
			// implicit casting
			//when you to convert a smaller data type to a larger data type like :
			//int to long ===> int x = 10; long y = x; this will not throw an exception
			//but when you try to convert a larger data type to a smaller data type like:
			//long to int ===> long x = 10; int y = x; this will throw an exception called OverflowException so you need to use explicit casting
			//long x = 10;
			//int y = (int)x;

			//=======================================================
			// boxing and unboxing
			// boxing ==> convert a value type to a reference type
			//int x = 10; value type
			//object obj ; reference type
			//obj = x; // boxing ====> convert done implicitly
			// unboxing ==> convert a reference type to a value type
			//int y = (int)obj; // unboxing ====> convert done explicitly
			//=======================================================
			// convert from string to int
			//var str = "10";
			//we need to use parse() method to convert string to int
			//like this : int.Parse(); , double.Parse(); , decimal.Parse(); , float.Parse();
			//var x = int.Parse(str); ===> this will convert the string to int
			//but the value of the string should be a number otherwise it will throw an exception called FormatException
			//and the value must be in the range of the int type otherwise it will throw an exception called OverflowException
			//there is a function to check if the string is a number or not and it is called TryParse() and check if the value is in the range of the int type
			//int.TryParse(str, out int result); // this will return true if the string is a number and false if it is not
			//=======================================================
			//bit conversion
			//var x = 255;
			//var y = BitConverter.GetBytes(x); // this will convert the int to byte array
			//foreach(var item in y)
			//{
			//	var binary = Convert.ToString(item, 2).PadLeft(8, '0'); // this will convert the byte to binary
			//	Console.WriteLine($" {binary} ");
			//}
			//convert from string to byte 
			//var z = "Issam";
			//char[] chars = z.ToCharArray();
			//foreach (var l in chars)
			//{
			//	var output =$"ASSCI : {l} ==> {Convert.ToInt32(l)} " +
			//		$"Binary : {Convert.ToString(l,2).PadLeft(8,'0')}" +
			//		$" Hexadecimal : {Convert.ToInt64(l):x}";
			//	Console.WriteLine($" {output} ");
			//}
			// CONVERT FROM HEXADECIMAL TO CHAR
			//string[] hexvalues = {"49" , "73", "73", "61", "6D" };
			//foreach (var hexa in hexvalues)
			//{
			//	var i = Convert.ToInt32(hexa, 16);
			//	var charr = char.ConvertFromUtf32(i);
			//	Console.WriteLine($" {charr} ");
			//}
			//convert from hexa to int
			//var hex = "8E2";
			//var number = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
			//Console.WriteLine($" {number} ");
			// convert from int to hexa
			//var hex1 = Convert.ToString(number, 16);
			//Console.WriteLine($" {hex1} ");

			//====================================================================
			//  problem :
		}
	}
}