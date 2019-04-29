using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public static class CustomerDB
    {
        
       
        const string path = "Customers.txt";

        //this method gets the list of customers form the file
        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>(); //Creating the list of Customer class which contains all fields/properties
            FileStream fs = null;
            StreamReader sr = null;
            string line;
            string[] fields;
            try
            {
               // FileStream allows to move data to and from the stream as arrays of bytes.
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read); //FileStream class to read from, write to, open, and close files on a file system
                // Stream is additional layer  between application &file.data first reads/ writes into the stream first in small chuncks before storing into the file
                sr = new StreamReader(fs); //StreamReader class is used to read to files. 
                
                while (!sr.EndOfStream)  //
                {
                    Customer c ;
                    
                    line = sr.ReadLine(); //streamline object assignes each line of record to "line" variable from file
                    fields = line.Split(','); //splits the record in individual piece of data by removing ',' between them

                    switch (fields[2]) // identify the customer type (as fileds[2] containts informtion on Customer Type  to create constructor accordingly
                    {
                        case "R": //if customer type is 'R' 
                            c = new Residential(fields[0], Int32.Parse(fields[1]), char.Parse(fields[2])); //Object "c" of Customer type now reads all parameters given by user in the form in the order
                            break; 
                        case "C":
                            c = new Commercial(fields[0], Int32.Parse(fields[1]), char.Parse(fields[2]));
                            break;
                        case "I":
                            c = new Industrial(fields[0], Int32.Parse(fields[1]), char.Parse(fields[2]));
                            break;
                        default:
                            c = new Residential(fields[0], Int32.Parse(fields[1]), char.Parse(fields[2]));
                            break;
                    }
                    c.CustomerCharge = double.Parse(fields[3]); //reads data @ fields[3] from the file, which is calculated value and assigns to Property to "c" object
                    customers.Add(c); //Adds customer object which is now contain data to list of "customers"

                }
            }
            catch (Exception ex)
            {
                throw ex; // let the form handle it
            }
            finally // close the file if open -finally block executes regardless of try method throws an error or not
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
            return customers;
        }

        //This method saves the customer data into the file
        public static void SaveCustomer(List<Customer> customers) 
        {
            FileStream fs = null; //sets Filestream object to null when the method starts executing
            StreamWriter sw = null;  //sets StreamWriter object to null when the method starts executing
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);  //open the file to write if file exists else create a new file
                sw = new StreamWriter(fs); //StreamWriter class is used to write in files.
               
                foreach (Customer c in customers) //foreach loops thru every record from the "customers" list and store it in object "c" of type Customer
                {
                    sw.WriteLine(c.ToText()); //calls the ToText method from Customer entity class to write into the file
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally // close the file if open - finally block executes regardless of try method throws an error or not
             {
                if (sw != null) sw.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
