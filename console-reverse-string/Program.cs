/*
Write the code necessary to reverse the letters of each word in place and display the result.
In other words, don't just reverse every letter in the variable pangram.
Instead, you'll need to reverse just the letters in each word,
    but print the reversed word in it's original position in the message.

    string pangram = "The quick brown fox jumps over the lazy dog";
*/
using System;

namespace console_reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string pangram = "The quick brown fox jumps over the lazy dog";
            string[] words = pangram.Split(' ');
            string[] newPangram = new string[words.Length];


            for (int i = 0, size = words.Length; i < size; i++)
            {
                char[] word = words[i].ToCharArray();
                Array.Reverse(word);
                newPangram[i] = String.Join("", word);
            }

            Console.WriteLine("\nOriginal string: " + String.Join(" ",pangram));
            Console.WriteLine("Reversed string: " + String.Join(" ",newPangram) + "\n");
        }
    }
}
