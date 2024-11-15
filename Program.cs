using System.Diagnostics.Metrics;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace Assignment2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write content to the file
            (string firstName, string lastName) = WriteFile(@"C:\MSSA-Prac\Test.txt");

            //Read content from the file by calling ReadFile method   
            ReadFile(@"C:\MSSA-Prac\Test.txt");

            Calculator(firstName, lastName);
        }

        //Read content from a file & display i tto conscole
        //The param name = path => Is the path to the file to be read
        static public void ReadFile(string path)
        {
            string line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                var sr = new StreamReader(path);
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
            }
            catch (Exception e)
            {
                //Display errors that occur
                Console.WriteLine("Exception: " + e.Message);
            }

            Console.WriteLine("\nPress ENTER to continue to Assignment 2_3_2");
            Console.ReadLine();
        }

        //Write content to a file
        //The param name = path => Is the path to the file to be written
        static public (string firstName, string lastName) WriteFile(string path)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("         Assignment2_3_1");
            Console.WriteLine("=================================\n\n");
            Console.WriteLine("Welcome to the File Transcriber where we'll demonstrate the capabilities of the StreamWriter class!\nPlease enter your information below and prepared to be amazed!\n");

            Console.WriteLine("First Name: ");
            string firstName = Console.ReadLine().ToUpper();
            Console.WriteLine("\nLast Name: ");
            string lastName = Console.ReadLine().ToUpper();
            Console.WriteLine("\nAge: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("\nAddress: ");
            string address = Console.ReadLine();
            Console.WriteLine("\nCity: ");
            string city = Console.ReadLine().ToUpper();
            Console.WriteLine("\nState: ");
            string state = Console.ReadLine().ToUpper();
            Console.WriteLine("\nZip Code: ");
            string zipCode = Console.ReadLine();

            try
            {
                Console.Clear();
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(path);
                //Write the first line of text
                sw.WriteLine($"Hello {firstName} it's nice to meet you!!\n\nAccording to our records, you are:\n\nFull Name: {firstName} {lastName}\nAge: {age} years old\nCurrent Address:\n{address}\n{city}, {state}\n{zipCode}");
                //Close the file & save changes
                sw.Close();

            }
            catch (Exception e)
            {
                //Display errors that occur during file writing
                Console.WriteLine("Exception: " + e.Message);
            }
            return (firstName, lastName);
        }

        static public void Calculator(string firstName, string lastName)
        {
            Console.Clear();
            //Assignment2_3_2
            Console.WriteLine("=================================");
            Console.WriteLine("         Assignment2_3_2");
            Console.WriteLine("=================================");
            //2.Design a tip calculator: enter the bill total, tip % and display grand total after adding tip.
            Console.WriteLine("\n\n**Tip Calculator!**\n");

            //1. Enter Bill total
            Console.WriteLine("Enter the Bill total: ");
            double billTotal = Convert.ToDouble(Console.ReadLine());

            //2. Enter tip %
            Console.WriteLine("\nEnter the tip %: ");
            double tipPercent = Convert.ToDouble(Console.ReadLine());

            //3. Calculate tip amount
            double tipAmount = Math.Round(billTotal * (tipPercent / 100), 2);

            //4. Calculate total
            double total = Math.Round(billTotal + tipAmount, 2);

            //5. Display results
            Console.WriteLine("\nTip Total: " + tipAmount);
            Console.WriteLine("\nTotal   : " + total);
            Console.WriteLine("=================");
            Console.WriteLine("\nPress ENTER to continue");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Good Luck {firstName} {lastName}!\nYou're now a bit smarter than a 5th grader, and {total} bucks short of a 5th grader's salary!!\n\nPress ENTER to continue");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("SUCKER!!!");

            Console.WriteLine("Press any key to EXIT");
            Console.ReadKey(intercept: true);
        }
    }

}
