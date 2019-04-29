using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class Industrial : Customer
    {
        const int ONPEAKRATE = 76; //Declaring Constant variable to assign value
        const int OFFPEAKRATE = 40; //Declaring Constant variable to assign value


        //Define Constructors
        public Industrial(string s, int a, char t) : base(s, a, t) { }

        //This method calculates the bill for Industrial type of Cusotmers based on Business Rule
        public override double calculateBill(int usage, int offpeak)
        {
            //calculate energy usage bill fo industrial customer

            double onPeakBill;
            double offPeakBill;
            double customerCharge;

            if (usage >= 0 && usage <= 1000)
            {
                onPeakBill = ONPEAKRATE;
            }
            else { onPeakBill = (double)(ONPEAKRATE + (usage - 1000) * 0.065); }
            if (offpeak >= 0 && offpeak <= 1000)
            {
                offPeakBill = OFFPEAKRATE;
            }
            else { offPeakBill = (double)(OFFPEAKRATE + (offpeak - 1000) * 0.028); }

            customerCharge = onPeakBill + offPeakBill;
            return customerCharge;
        }
    }
}
