/*
Our writers have decided on the following example marketing copy.
Here's the desired output (using fictitious customer account data).
Use your new found knowledge of string formatting to build an application
    that can merge and format the appropriate content given the example output above.
Pay particular attention to the white space and make sure you accurately represent this exact format using C#.

Output:
-------
Dear Mr. Jones,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75 %.

Our new product, Glorious Future offers a return of 13.13 %.  Given your current volume, your potential profit would be ¤63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75 %   ¤55,000,000.00      
Glorious Future     13.13 %   ¤63,000,000.00  
*/
using System;

namespace console_marketing_format
{
    class Program
    {
        static void Main(string[] args)
        {
            string customerName = "Mr. Jones";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            // Your logic here

            Console.WriteLine("Here's a quick comparison:\n");

            string comparrisonMessage = "";

            // Your logic here

            Console.WriteLine(comparrisonMessage);
        }
    }
}
