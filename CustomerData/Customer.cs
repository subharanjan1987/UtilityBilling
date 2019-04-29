using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public abstract class Customer 
    {
        //Define Properties which are auto-implemented
        //gets and sets corresponding private instance variables  under the hood
        public string CustomerName
        { get; set; }    
        public int CustomerAC
        { get; set; }
        public char CustomerType
        { get; set; }
        public double CustomerCharge //this property value is set by calculated value from the calculateBill method
        { get; set; } 

        //defining Constructor
        public Customer (string s, int a, char t)  //passing parametes to get and set customername,customerA/C and customer type
        {
            CustomerName = s;  
            CustomerAC = a;
            CustomerType = t;
         }

        //Declaring Methods -
        //Abstract method cant'be defined but must be overridden by child classes with same method signatures
        public abstract double calculateBill(int usage, int x=0);


        public override string ToString() // overriding toString() method to read record line from file
        {
            return CustomerName + "," + CustomerAC.ToString() + "," + CustomerType.ToString() + "," + CustomerCharge.ToString("c");
        }
        public string ToText() // to write a record line in a text file
        {
            return CustomerName + "," + CustomerAC.ToString() + "," + CustomerType.ToString() + "," + CustomerCharge.ToString();
        }
    }
}
