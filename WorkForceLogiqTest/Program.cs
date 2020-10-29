using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkForceLogiqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string strInput = "", strOperation="",strReverse="-r",strLength ="-l",strReverseOutput="";

            // Display title for C# console application.
            Console.WriteLine("Console Application to show length and reverse string in C#\r");
            Console.WriteLine("--------------------------------------------------------------\n");

            // Ask the user to input the string.
            Console.WriteLine("Please enter the string, word or sentence, and then press Enter:\n");
            strInput = Convert.ToString(Console.ReadLine());

            // Ask the user to input the -r or -l parameter.
            Console.WriteLine("\nPlease enter the parameter (–r) or (–l), and then press Enter:\n");
            strOperation = Convert.ToString(Console.ReadLine());

            //For (-r) reverse parmeters
            if (strOperation.ToLower().Equals(strReverse))
            {
                int length = 0;
                length = strInput.Length - 1;
                while (length >= 0)
                {
                    strReverseOutput = strReverseOutput + strInput[length];
                    length--;
                }
                //Displaying the reverse word  
                Console.WriteLine("\n\nReverse string is: " + strReverseOutput);
                Console.ReadLine();
            }

            //For (-l) length parmeters
            if (strOperation.ToLower().Equals(strLength.ToLower()))
            {   
                //Displaying the string length.  
                Console.WriteLine("\nThe length of string is: " + strInput.Length);
                Console.ReadLine();
            }
        }
    }
}
