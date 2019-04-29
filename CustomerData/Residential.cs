using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class Residential : Customer
    {
        const int RESIDENTIAL = 6; //Declaring Constant variable to assign value

        //Define Constructors
        public Residential(string s, int a, char t) : base(s, a, t) { }

        //This method calculates the bill for Residential type of Cusotmer based on Business Rule
        public override double calculateBill(int usage, int offPeak=0)
        {
            //calcualtes energy usage bill for residential customer
            double customerCharge;
            customerCharge = (double)(RESIDENTIAL + usage * 0.052);
            return customerCharge;
        }
    }
}
