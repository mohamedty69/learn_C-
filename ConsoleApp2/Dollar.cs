using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlearn
{
    public class Dollar
    {
        public decimal amount; // ===> in this status that called backing field because it is used to store the value of the property but acn`t be accessed directly in the main method
        //syntax to make a property 
        //why we use property to access the field when we make it private
        //syntax of property ==> <accessModifier> <datatype (same as field)> <propertyName(same as field)> { get{ } set{ } }

        //note: Validate the field value in the property setter and constructor
        public decimal Amount
        {
            get
            { 
                return this.amount;
            }
            private set 
            {
                this.amount = ProcessValue(value);
            }
        }
        // we can make a property without backing field like this:
        public bool IsZero () => this.amount == 0;
        //we can make initializer for the property like this:
        public decimal ConversionFactor { get; set; } = 1.99m;
        public Dollar(decimal amount) 
        {
            this.amount = ProcessValue(amount);
        }
        public decimal ProcessValue(decimal Value) => Value < 0 ? 0 : Value;
        // this is a method that will be used to process the value of the property becouse we did the set private
        public void AddAmount(decimal Value)
        {
            this.Amount=Value;
        }

    }
}
