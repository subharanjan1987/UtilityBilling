using CustomerData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCityPowerCompany : Form
    {
        List<Customer> customerList; //customerList is a collection of all Customers
        double res = 0;  //declaring variables with public scope
        double com = 0;
        double ind = 0;

        public frmCityPowerCompany()
        {
            InitializeComponent();

        }
        
         private void frmCityPowerCompany_Load(object sender, EventArgs e)
        {
            rdResidential.Focus(); //residentail customer radio button gets focused when application form loads
            pnlIndustrial.Visible = false; //panel which contains industrial customer specific fileds gets invisible
            try
            {
                //Get all customes  thru GetCustomer() method defined in CustomerList Class and store it in customerList.
                customerList = CustomerDB.GetCustomers();
                DisplayCustomers(); //Get each customer in new line to display in listbox in form by calling this method    
                totalChargeByCustomer();  //Calculates total Bill amount of all Customers in the list by their type
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while reading customer data: " + ex.Message, ex.GetType().ToString());
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
           
                //Residential Customer energy bill Calculation when residental customer radio button is selected
                if (rdResidential.Checked == true)
                {
                    if (Validator.IsProvided(txtKwh, "Energy Usage") && Validator.IsNonNegativeInt(txtKwh, "Energy usage") && Validator.IsNonNegativeDbl(txtKwh, "usage"))
                    {
                        Customer c = new Residential(null, 0, '0'); //passing null and 0 in the constructors as  we don't want to save the object in the list yet
                        int input = Convert.ToInt32(txtKwh.Text); //converting user input into integer
                        double restotalBill = c.calculateBill(input); //calling the function which calculates residential bill
                        txtChargeAmt.Text = restotalBill.ToString("c"); //displaying result with $ currancy
                    }
                }
                //Commercial customer energy bill calculation when commercial customer radio button is selected
                if (rdCommercial.Checked == true)
                {
                    if (Validator.IsProvided(txtKwh, "Energy Usage") && Validator.IsNonNegativeInt(txtKwh, "Energy usage") && Validator.IsNonNegativeDbl(txtKwh, "usage"))
                    {
                        Customer c = new Commercial(null, 0, '0'); //passing null and 0 in the constructors as  we don't want to save the object in the list yet
                    int input = Convert.ToInt32(txtKwh.Text); //converting user input into integer
                        double comtotalBill = c.calculateBill(input);  //calling the function which calculates commercial bill
                        txtChargeAmt.Text = comtotalBill.ToString("c"); //displaying result with $ currancy
                    }
                }
          

            //Industrial  customer energy bill calculation when indutrial customer radio button is selected
            if (rdIndustrial.Checked == true)
            {
                if (Validator.IsProvided(txtOnPeak, "Energy Usage") && Validator.IsNonNegativeInt(txtOnPeak, "Energy usage") && Validator.IsNonNegativeDbl(txtOnPeak, "Energy usage") &&
                    Validator.IsProvided(txtOffPeak, "Energy Usage") && Validator.IsNonNegativeInt(txtOffPeak, "Energy usage") && Validator.IsNonNegativeDbl(txtOffPeak, "Energy usage"))
                    
                {
                    Customer c = new Industrial(null, 0, '0');//passing null and 0 in the constructors as  we don't want to save the object in the list yet
                    int onpeak = Convert.ToInt32(txtOnPeak.Text); //converting user input into integer
                    int offpeak = Convert.ToInt32(txtOffPeak.Text); //converting user input into integer
                    double indTotalBill = c.calculateBill(onpeak, offpeak);  //calling the function which calculates industrial bill
                    txtChargeAmt.Text = indTotalBill.ToString("c"); //displaying result with $ currancy
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears all fields.
            txtKwh.Clear();
            txtOffPeak.Clear();
            txtOnPeak.Clear();
            txtChargeAmt.Clear();
            rdResidential.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); //close the application
        }

        //clicking residential customer radio button follows below business rule
        private void rdResidential_CheckedChanged(object sender, EventArgs e)
        {
                txtKwh.Text = "";  //makes energy usage text box clear
                txtChargeAmt.Text = ""; //makes total bill amount text box clear
                txtKwh.Visible = true; //makes energy usage text box visible
                lblkwh.Visible = true; //makes energy usage label visible
                pnlIndustrial.Visible = false; //makes panel which contains industrial customer specific fileds invisible
            
        }

        //clicking commercial customer radio button follows below business rule
        private void rdCommercial_CheckedChanged(object sender, EventArgs e)
        {
            txtKwh.Text = ""; //makes energy usage text box clear
            txtChargeAmt.Text = ""; //makes total bill amount text box clear
            txtKwh.Visible = true; //makes energy usage text box visible
            lblkwh.Visible = true; //makes energy usage label visible
            pnlIndustrial.Visible = false; //makes panel which contains industrial customer specific fileds invisible
        }

        //clicking industrial customer radio button follows below business rule
        private void rdIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            txtOnPeak.Text = ""; //makes onpeak energy usage text field clear
            txtOffPeak.Text = ""; //makes offpeak energy usage text field clear
            txtChargeAmt.Text = ""; //makes total bill amount text box clear
            txtKwh.Visible = false; //makes energy usage text box invisible
            lblkwh.Visible = false; //makes energy usage text box invisible
            pnlIndustrial.Visible = true; //makes panel which contains industrial customer specific fileds visible
        }
    
           //Below event of clicking Add Customer button adds customer in the list, calculates total bill amt of customer by their type, count total # of customer and calculate total bill of all customers in list
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer c = null;
            if (Validator.IsProvided(txtCustName, "Customer Name") && Validator.IsProvided(txtCustName, "Account Number") && Validator.IsNonNegativeInt(txtAccountNo, "Account Number") && Validator.IsUnique(txtAccountNo, "Account#", lstCustomers))
            {
                if (rdResidential.Checked)
                {
                    c = new Residential(txtCustName.Text, Convert.ToInt32(txtAccountNo.Text), 'R'); //creating Residential customer object
                    c.CustomerCharge = c.calculateBill(int.Parse(txtKwh.Text)); //Calculatinga a bill amt of  Residential customer
                    res += c.CustomerCharge;    //Adding new bill charge of residential customer to the existing bill amount of Residential customers
                    txtResidentialType.Text = res.ToString("c");
                  
                }
                if (rdCommercial.Checked)
                {
                    c = new Commercial(txtCustName.Text, Convert.ToInt32(txtAccountNo.Text), 'C'); // creating Commercial customer object
                    c.CustomerCharge = c.calculateBill(int.Parse(txtKwh.Text)); //Calculatinga a bill amt of Commercial customer
                    com += c.CustomerCharge; //Adding new bill charge of Commercial customer to the existing bill amount of Commercial customers
                    txtCommercialType.Text = com.ToString("c");

                }
                if (rdIndustrial.Checked)
                {
                    c = new Industrial(txtCustName.Text, Convert.ToInt32(txtAccountNo.Text), 'I');  // creating Industrial customer object
                    c.CustomerCharge = c.calculateBill(int.Parse(txtOnPeak.Text), (int.Parse(txtOffPeak.Text))); //Calculating a bill amt of Industrial customer
                    ind += c.CustomerCharge;  //Adding new bill charge of industrial customer to the existing bill amount of industrial customers
                    txtIndutrialType.Text = ind.ToString("c");
                }
                customerList.Add(c);
                DisplayCustomers();
              
                

            }
        }

        //Saving Customers in the file upon form closing event
        private void frmCityPowerCompany_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CustomerDB.SaveCustomer(customerList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving Customers: " + ex.Message,
                    ex.GetType().ToString());
            }
        }
        //Display Customers in the file upon form closing event
        private void DisplayCustomers()
        {
            lstCustomers.Items.Clear();
            foreach (Customer c in customerList)
                   lstCustomers.Items.Add(c.ToString()); // calls ToString() from Customer
            txtTotalCustomers.Text = customerList.Count.ToString(); // display count
            txtTotalCharge.Text = totalCharge().ToString("c"); // display total inventory value
        }

        //Calculating Total Bill Amount of all Customers in the List
        private double totalCharge()
        {
            double sum = 0;
            foreach (Customer c in customerList)  //Looping thru each customer list and storing each item in c
               sum += c.CustomerCharge;   //Keeps on adding Customer charge in the sum variable until the end of the list of customers
            return sum;  
        }

        //Calculating Total Bill Amount of all Customers by their Type  in the List
        private void totalChargeByCustomer()
        {
            
            foreach(Customer c in customerList)  //Looping thru each customer list and storing each item in c
            {
                switch (c.CustomerType)   //Switch on Customer Type property of Customer Object as it contains Customer Type of 'R','C','I'
                {
                    case 'R':                       //if customer Type is Residential
                        res += c.CustomerCharge;   //then, adds Customer bill Amount to res variable, keeps on doing untl end of the Customer list
                        break;              
                    case 'C':                       //if customer type is Commercial
                        com += c.CustomerCharge;    //then, adds Customer bill Amount to com variable, keeps on doing untl end of the Customer list
                        break;
                    case 'I':                         //if customer type is Industrial
                        ind += c.CustomerCharge;    //then, adds Customer bill Amount to ind variable, keeps on doing untl end of the Customer list
                        break;
                }
            }
                
        txtResidentialType.Text = res.ToString("c");
        txtCommercialType.Text = com.ToString("c");
        txtIndutrialType.Text = ind.ToString("c");
        }
  
    }//class
}//naespace
