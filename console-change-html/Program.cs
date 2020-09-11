/*
Given the starting point in the following code listing, you'll add code to extract,
    replace, and remove portions of the input's value to produce the desired output.

Input:
    const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
Output:
    Quantity: 5000
    Output: <h2>Widgets &reg;</h2><span>5000</span>

*/
using System;

namespace console_change_html
{
    class Program
    {
        static void Main(string[] args)
        {
           const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";

            // Your work here
            string spanOpeningTag = "<span>";
            string spanClosingTag = "</span>";
            string [] tagsToRemove = {"<div>","</div>"};            
            int spanOpeningTagIndex = input.IndexOf(spanOpeningTag);            
            int spanClosingTagIndex = input.IndexOf(spanClosingTag, spanOpeningTagIndex);            
            int quantityLength = spanClosingTagIndex  - (spanOpeningTagIndex + spanOpeningTag.Length);         
            quantity = input.Substring(spanOpeningTagIndex + spanOpeningTag.Length, quantityLength);

            Console.WriteLine($"{"Quantity",-9}: {quantity}");

            output = input;
            foreach (string tag in tagsToRemove)
            {    
                int tagIndexToRemove = output.IndexOf(tag);                        
                output = output.Remove(tagIndexToRemove, tag.Length);                
            }            

            output = output.Replace("&trade", "&reg");

            Console.WriteLine($"{"Output",-9}: {output}");
        }
    }
}
