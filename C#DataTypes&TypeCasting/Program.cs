using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace C_DataTypes_TypeCasting
{
    internal class Program
    {
        enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main(string[] args)
        {

            //Task 1 : Declare and initialize variables using the
            //following data types & Print their values to the console.
            //- int, float, double, decimal string, bool
            Console.WriteLine("Declaring and initializing variables ");
            int numberI = 100;
            Console.WriteLine("Integer : " + numberI);
            float numberF = 100.10f;
            Console.WriteLine("Float : " + numberF);
            double numberD = 1000000000.12;
            Console.WriteLine("Double : " + numberD);
            decimal numberDc = 3 / 2;
            Console.WriteLine("Decimal : " + numberDc);
            string str = "Shubhodeep";
            Console.WriteLine("String : " + str);
            bool answer = true;
            Console.WriteLine("Boolean : " + answer);
            Console.ReadLine();

            //Task 2 : Print minimum, maximum and default values
            //for various datatypes.
            Console.WriteLine("Printing Maximum, Minimum and Default values of datatypes(Signed and Unsigned) ");
            Console.WriteLine($"byte     -> Min: {byte.MinValue}, Max: {byte.MaxValue}, Default: {default(byte)}");
            Console.WriteLine($"signedbyte    -> Min: {sbyte.MinValue}, Max: {sbyte.MaxValue}, Default: {default(sbyte)}");
            Console.WriteLine($"short    -> Min: {short.MinValue}, Max: {short.MaxValue}, Default: {default(short)}");
            Console.WriteLine($"unsignedshort   -> Min: {ushort.MinValue}, Max: {ushort.MaxValue}, Default: {default(ushort)}");
            Console.WriteLine($"int      -> Min: {int.MinValue}, Max: {int.MaxValue}, Default: {default(int)}");
            Console.WriteLine($"unsignedint     -> Min: {uint.MinValue}, Max: {uint.MaxValue}, Default: {default(uint)}");
            Console.WriteLine($"long     -> Min: {long.MinValue}, Max: {long.MaxValue}, Default: {default(long)}");
            Console.WriteLine($"unsignedlong    -> Min: {ulong.MinValue}, Max: {ulong.MaxValue}, Default: {default(ulong)}");
            Console.WriteLine($"float    -> Min: {float.MinValue}, Max: {float.MaxValue}, Default: {default(float)}");
            Console.WriteLine($"double   -> Min: {double.MinValue}, Max: {double.MaxValue}, Default: {default(double)}");
            Console.WriteLine($"decimal  -> Min: {decimal.MinValue}, Max: {decimal.MaxValue}, Default: {default(decimal)}");
            Console.WriteLine($"char     -> Min: {(int)char.MinValue}, Max: {(int)char.MaxValue}, Default: {default(char)}");
            Console.WriteLine($"bool     -> Default: {default(bool)}");
            Console.WriteLine($"string   -> Default: {default(string)}");
            Console.ReadLine();

            //Difference between default values if the 
            //datatypes are made nullable.

            Console.WriteLine("Nullable datatypes with default values ");
            int? a = default;
            Console.WriteLine("Integer : " + a);
            float? b = default;
            Console.WriteLine("Float : " + b);
            double? c = default;
            Console.WriteLine("Double : " + c);
            decimal? d = default;
            Console.WriteLine("Decimal : " + d);
            char? e = default;
            Console.WriteLine("Character : " + e);
            Console.ReadLine();

            //Task 4 : Write a program using enum to print the day of week in text,
            //if input is provided as a number.
            //Example : If input is 4, expected output is Thursday!
            Console.WriteLine("Printing Day of the week");
            Console.Write("Enter the number : ");
            int day = (Convert.ToInt32(Console.ReadLine()))%7;
            Console.WriteLine("The day of the week is : " + (DaysOfTheWeek)day);
            Console.ReadLine();

            //Problem statements for type casting in C# 1.Convert an Integer to a Double:Declare an int variable and assign a value.Convert it to a double using implicit casting.Print both values.
            Console.WriteLine("Converting an Integer to a Double");
            int num = 10;
            Console.WriteLine("Integer num : "+num);
            double numd = num;
            Console.WriteLine("Double num :" +numd);
            Console.ReadLine();

            //2.Convert a Character to an Integer(ASCII Value): Declare a char variable(e.g., 'A').Convert it to an int to get its ASCII value. Print the result.
            Console.WriteLine("Convert a Character to an Integer(ASCII Value)");
            char ch = 'a';
            Console.WriteLine("Character :"+ch);
            int charNum = ch;
            Console.WriteLine("Ascii value of the character :" + charNum);
            Console.ReadLine();

            //3.Convert a Double to an Integer:Declare a double variable with a decimal value.Explicitly cast it to an int.Print both values and observe the data loss.
            Console.WriteLine("Convert a Double to an Integer");
            double charNumd = 10023.78;
            Console.WriteLine("Double :"+charNumd);
            int charNumI = (int)charNumd;
            Console.WriteLine("Integer casting of double :"+charNumI);
            Console.ReadLine();

            //4.Truncate a Float Value:Declare a float variable with a decimal value.Convert it to an int using explicit casting.Print both values and note the truncated decimal.
            Console.WriteLine("Truncate a Float Value");
            float charNumF = 10.78f;
            Console.WriteLine("Float :" + charNumF);
            int charNumFI = (int)charNumF;
            Console.WriteLine("Integer casting of Float :" + charNumFI);
            Console.ReadLine();

            //5.Convert a String to an Integer:Declare a string variable with a numeric value(e.g., "100").Convert it to an int using Convert.Print the result.
            Console.WriteLine("Convert a String to an Integer");
            string str1 = "1506";
            Console.WriteLine("String :" + str1);
            int strI = Convert.ToInt32(str1);
            Console.WriteLine("Integer casting of string :" + strI);
            Console.ReadLine();

            //6.Convert a Boolean to an Integer:Declare a bool variable(true or false).Convert it to an int using Convert.Print the result(true → 1, false → 0).
            Console.WriteLine("Convert a Boolean to an Integer");
            bool ans = true;
            Console.WriteLine("Boolean :" + str1);
            int ansI = Convert.ToInt32(ans);
            Console.WriteLine("Integer casting of boolean :" + ansI);
            Console.ReadLine();

            //7.Convert a String to an Integer using Parse():Declare a string with a numeric value.Convert it to an int using int.Parse().Print the result.
            Console.WriteLine("Convert a String to an Integer using Parse()");
            string strNum = "2001";
            Console.WriteLine("string :" + strNum);
            int strNumI = int.Parse(strNum);
            Console.WriteLine("Integer casting of string :" + strNumI);
            Console.ReadLine();

            //8.Handle Non - Numeric String using TryParse():Declare a string variable with a non - numeric value(e.g., "ABC").
            //Try to convert it to an int using int.TryParse().Print whether the conversion was successful.
            Console.WriteLine("Handle Non - Numeric String using TryParse()");
            string strNum2 = "sds";
            Console.WriteLine("string :" + strNum2);
            Console.WriteLine("Integer casting of non-numeric string :" + int.TryParse(strNum2,out int result));
            Console.ReadLine();

            //9.User Input Conversion:Read a number from the console as a string.Convert it to double using Convert.ToDouble().Multiply the number by 10 and print the result.
            Console.WriteLine("User Input Conversion");
            Console.WriteLine("Enter a number : ");
            string userInput = Console.ReadLine();
            double numberDouble = Convert.ToDouble(userInput)*10;
            Console.WriteLine("Result : "+numberDouble);
            Console.ReadLine();


            //10.Temperature Converter(Celsius to Fahrenheit):Take a user input in string format for temperature in Celsius.
            //Convert it to double and apply the formula.Display the converted temperature in Fahrenheit.
            Console.WriteLine("Celsius to Farenheit Conversion");
            Console.WriteLine("Please enter the tempreture in celsius : ");
            string celsius = Console.ReadLine();
            Console.WriteLine($"The tempreture in Celsius is :{Convert.ToDouble(celsius)} and Farenheit is {CelsiusToFahrenheitConversion(Convert.ToDouble(celsius))}");
        }

        public static double CelsiusToFahrenheitConversion(double celsius)
        {
            return (double)(celsius * 9 / 5) + 32; ;
        }
    }
}

