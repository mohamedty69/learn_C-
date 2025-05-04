using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlearn
{
    public class Date
    {
        // make access modifier private to the fields to make user initiate them with constructor only
        private int day = 01;
        private int month = 01;
        private int year = 01;

        private static readonly int[] daysinyearis365 =  {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] daysinyearis366 = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        // constructor ==> <accessModifier> <ClassName/typeName> (<parameters>) 
        // {
        // <constructor body> series of statemnts
        // }
        public Date(int day, int month , int year) 
        {
            var isLeap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
            if (month <= 1 || month >= 12 && year > 1 || year < 9999 )
            {
                int[] days = isLeap ? daysinyearis366 : daysinyearis365;
                if (day <= 1 || day >= days[month])
                {
            // we use this when we need to access fields and we are in the same class
            //and we have a parameter with the same name as the field so we use this to distinguish
            //between the field and the parameter 
                this.day = day;
                this.month = month;
                this.year = year;      
                }

            }
        }
        public Date (int year) : this (01,01,year)
        {
            //this is overloading constructor that make a default values if i don`t need to pass it
        }
        public Date (int month , int year ) : this (01,month ,year)
        {
            
        }
        public string GetDate()
        {
            return $"{this.day.ToString().PadLeft(2, '0')}/{this.month.ToString().PadLeft(2, '0')}" +
                $"/{this.year.ToString().PadLeft(4,'0')}";
        }
    }
}
