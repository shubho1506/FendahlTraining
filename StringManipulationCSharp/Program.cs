using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringManipulationTask();
            StringBuilderTask();

        }

        static void StringBuilderTask()
        {
            StringBuilder sb = new StringBuilder("Hello");
            sb.Append(" World"); // Appends " World"
            sb.Insert(5, ",");  // Inserts "," after "Hello"
            sb.Replace("World", "C#"); // Replaces "World" with "C#"
            sb.Remove(6, 1); // Removes the ","

            Console.WriteLine(sb.ToString()); // Output: Hello C#

            int iterations = 10000;

            // Using string
            Stopwatch sw1 = Stopwatch.StartNew();
            string str = "";
            for (int i = 0; i < iterations; i++)
            {
                str += i; // Creates a new string object every time
            }
            sw1.Stop();
            Console.WriteLine($"String time: {sw1.ElapsedMilliseconds}ms");

            // Using StringBuilder
            Stopwatch sw2 = Stopwatch.StartNew();
            StringBuilder sb1 = new StringBuilder();
            for (int i = 0; i < iterations; i++)
            {
                sb1.Append(i); // Modifies the same object
            }
            sw2.Stop();
            Console.WriteLine($"StringBuilder time: {sw2.ElapsedMilliseconds}ms");
        }

        static void StringManipulationTask()
        {
            Console.WriteLine("Problem problem statements for String Handling in C# ");

            Console.WriteLine("Reverse a String");
            string str = Console.ReadLine();
            Console.WriteLine(reverseString(str));
            Console.ReadLine();

            Console.WriteLine("Count Vowels in a String");
            string str1 = Console.ReadLine();
            Console.WriteLine(countVowels(str1));
            Console.ReadLine();

            Console.WriteLine("Palindrome Check");
            string str2 = Console.ReadLine();
            Console.WriteLine(palindromeCheck(str2));
            Console.ReadLine();

            Console.WriteLine("Find All Substrings");
            string str3 = Console.ReadLine();
            allSubstrings(str3);
            Console.ReadLine();

            Console.WriteLine("Character Frequency Count");
            string str4 = Console.ReadLine();
            charFrequencyCount(str4);
            Console.ReadLine();

            Console.WriteLine("Replace a Character in a String");
            ReplaceCharacter();
            Console.ReadLine();

            Console.WriteLine("String Comparison(Case - Insensitive)");
            string str6 = Console.ReadLine();
            string str7 = Console.ReadLine();
            Console.WriteLine(stringComparison(str6, str7));
            Console.ReadLine();

            Console.WriteLine("Longest Word in a Sentence");
            string str8 = Console.ReadLine();
            Console.WriteLine(LongestWordInString(str8));
            Console.ReadLine();

            Console.WriteLine("Remove Whitespace from a String");
            string str9 = Console.ReadLine();
            Console.WriteLine(removeWhiteSpace(str9));
            Console.ReadLine();

            Console.WriteLine("Check for Anagrams");
            string str10 = Console.ReadLine();
            string str11 = Console.ReadLine();
            Console.WriteLine(checkAnagrams(str10, str11));
            Console.ReadLine();

            Console.WriteLine("Count Words in a Sentence");
            string str12 = Console.ReadLine();
            Console.WriteLine(countWords(str12));
            Console.ReadLine();

            Console.WriteLine("Split a Sentence into Words");
            string str13 = Console.ReadLine();
            sentenceIntoWords(str13);
            Console.ReadLine();

        }

        //1.Reverse a String
        //Problem:
        //Write a method that takes a string as input and returns the reversed string.
        //Example:
        //Input: "hello"
        //Output: "olleh"
        static string reverseString(string str)
        {
            string reversed = new string(str.Reverse().ToArray());
            return reversed;
        }

        //2.Count Vowels in a String
        //Problem:
        //Write a method that counts the number of vowels(a, e, i, o, u) in a given string.
        //Example:
        //Input: "Hello World"
        //Output: 3
        static int countVowels(string str)
        {
            int count = 0;
            foreach(char ch in str)
            {
                if(ch=='a'||ch=='e'|| ch == 'i' || ch == 'o' || ch == 'u')
                {
                    count++;
                }
            }
            return count;
        }

        //3.Palindrome Check
        //Problem:
        //Write a method to check if a string is a palindrome (reads the same backward as forward).
        //Example:
        //        Input: "racecar"
        //Output: true
        static bool palindromeCheck(string str)
        {
            string reverse = new string(str.Reverse().ToArray());
            return str.Equals(reverse);
        }

        //4.Find All Substrings
        //Problem:
        //            Write a method that prints all possible substrings of a given string.
        //            Example:
        //Input: "abc"
        //Output: "a", "b", "c", "ab", "bc", "abc"
        static void allSubstrings(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j <= str.Length; j++)
                {
                    Console.WriteLine(str.Substring(i, j - i));
                }
            }
        }

        //5.Character Frequency Count
        //Problem:
        //            Write a method to count the frequency of each character in a string.
        //            Example:
        //Input: "hello"
        //Output: h: 1, e: 1, l: 2, o: 1
        static void charFrequencyCount(string str)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            Console.WriteLine("Character Frequency:");
            foreach (var item in charCount)
            {
                Console.WriteLine($"'{item.Key}' : {item.Value}");
            }
        }

        //6.Replace a Character in a String
        //Problem:
        //            Write a method to replace all occurrences of a specified character in a string with another character.
        //Example:
        //        Input: "banana", replace 'a' with 'o'
        //Output: "bonono"
        static void ReplaceCharacter()
        {
            Console.WriteLine("Enter the string:");
            string s = Console.ReadLine() ?? "";
            Console.WriteLine("Enter the character to replace:");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Enter the character to replace with:");
            char rch = Console.ReadKey().KeyChar;
            Console.WriteLine();
            char[] charArray = s.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == ch)
                {
                    charArray[i] = rch;
                }
            }
            Console.WriteLine(new string(charArray));
        }

        //7.String Comparison(Case - Insensitive)
        //Problem:
        //            Write a method that compares two strings in a case -insensitive manner.
        //            Example:
        //Input: "hello", "HELLO"
        //            Output: true
        static bool stringComparison(string str1, string str2)
        {
            return string.Equals(str1,str2,StringComparison.OrdinalIgnoreCase);
        }

        //8.Find the Longest Word in a Sentence
        //            Problem:
        //                Write a method that takes a sentence as input and returns the longest word in the sentence.
        //Example:
        //            Input: "The quick brown fox jumps"
        //            Output: "jumps"
        static string LongestWordInString(string str)
        {
            string[] words = str.Split(' '); 
            string longest = "";
            foreach (string word in words)
            {
                if (word.Length > longest.Length)
                {
                    longest = word;
                }
            }
            return longest;
        }

        //9.Remove Whitespace from a String
        //            Problem:
        //                Write a method to remove all leading and trailing whitespace from a string.
        //                Example:
        //Input: " hello world "
        //            Output: "hello world"
        static string removeWhiteSpace(string str)
        {
            return str.Trim();
        }

        //10.Check for Anagrams
        //Problem:
        //Write a method that checks if two strings are anagrams of each other(contain the same characters in
        //different orders).
        //Example:
        //            Input: "listen", "silent"
        //            Output: true
        static bool checkAnagrams(string str1,string str2)
        {
            if (str1.Length != str2.Length) return false;
            char[] charArray1 = str1.ToLower().ToCharArray();
            char[] charArray2 = str2.ToLower().ToCharArray();
            Array.Sort(charArray1);
            Array.Sort(charArray2);
            return new string(charArray1) == new string(charArray2);
        }

        //11.Count Words in a Sentence
        //            Problem:
        //                Write a method that counts the number of words in a given sentence.
        //                Example:
        //Input: "C# is fun"
        //            Output: 3
        static int countWords(string str)
        {
            string[] words = str.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        //12.Split a Sentence into Words
        //            Problem:
        //                Write a method that splits a sentence into words and prints each word on a new line.
        //                Example:
        //Input: "C# is great!"
        //Output:
        //                C#
        //                is
        //                great!
        static void sentenceIntoWords(string str)
        {
            string[] words = str.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
