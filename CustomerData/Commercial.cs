using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class Commercial:Customer
    {
        const int COMMERCIAL = 60;  //Declaring Constant variable to assign value
       
        //Define Constructor
        public Commercial(string s, int a, char t) : base(s, a, t) { }
    

        //This method calculates the bill for Commercial type of Cusotmer based on Business Rule
        public override double calculateBill(int usage, int offPeak=0)
        {
            //calculates energy usage bill for commercial customer
            double customerCharge;
            if (usage > 0 && usage <= 1000)
            {
                customerCharge = COMMERCIAL;
            }
            else { customerCharge = (double)(COMMERCIAL + (usage - 1000) * 0.045); }
            return customerCharge;
        }
    }
}
