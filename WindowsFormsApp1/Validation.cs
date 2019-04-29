using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class Validator  //collection of static validation methods
    {
        /// <summary>
        /// Checks if content of the textbox is non-empty.
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="name"></param>
        /// <returns>Is it valid</returns>
        public static bool IsProvided(TextBox tb, string name)
        {
            bool result = true; //set it to true until becomes false
            if (tb.Text == "") //if textbox is empty
            {
                result = false;
                MessageBox.Show(name + " has to be entered");

                tb.Focus();
            }
            return result;
        }

        public static bool IsNonNegativeInt(TextBox tb,string name)
        {
            bool result = true;
            int val; //for TryParse
            if (!Int32.TryParse(tb.Text, out val)) //Not an int
            {
                result = false;
                MessageBox.Show(name + " has to be whole number");
                tb.SelectAll(); //highlight text on the box for easy replacememnt
                tb.Focus();

            } else if (val < 0) //negative
            {
                result = false;
                MessageBox.Show(name + " has to be positive");
                tb.SelectAll(); //highlight text on the box for easy replacememnt
                tb.Focus();
            }

            return result;
        }

        public static bool IsNonNegativeDbl(TextBox tb, string name)
        {
            bool result = true;
            double val; //for TryParse
            if (!Double.TryParse(tb.Text, out val)) //Not an int
            {
                result = false;
                MessageBox.Show(name + " has to be number");
                tb.SelectAll(); //highlight text on the box for easy replacememnt
                tb.Focus();

            }
            else if (val < 0) //negative
            {
                result = false;
                MessageBox.Show(name + " has to be positive or zero");
                tb.SelectAll(); //highlight text on the box for easy replacememnt
                tb.Focus();
            }

            return result;
        }

        //This method checks the uniqueness of Account# of the customer 
        public static bool IsUnique(TextBox tb, string name, ListView list)
        {
            bool result = true;
       
            foreach(ListViewItem line in list.Items)   //assigning an item frm the listbox to the line varibale 
            {
      
                if (line.Text.Contains(tb.Text))  //checking if any line contains the ac# given by username then gives errorr message.
                {
                    result = false;
                    MessageBox.Show(name + "already exists in the system");
                    tb.SelectAll(); //highlight text on the box for easy replacememnt
                    tb.Focus();
                }
            }
            return result;
        }

    }
}
