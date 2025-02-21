using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeOperationsInCSharp
{
    class DateTimeOps
    {
        //1.Formatting DateTime
        //Problem:
        //Write a program that prints the current date and time in the following formats:
        // yyyy - MM - dd HH: mm: ss
        // MM / dd / yyyy
        // dddd, dd MMMM yyyy
        //Expected Output(example):
        //2025 - 02 - 14 15:30:00
        //02 / 14 / 2025
        //Friday, 14 February 2025
        public void formating()
        {
            string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
            Console.WriteLine($"Current date in the format of yyyy-MM-dd HH-mm-ss {currentDateTime}");
            string currentDate = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine("Current Date  in the format dddd dd MMMM yyyy " + currentDate);
        }

        //2.Adding and Subtracting Time
        //Problem:
        //Write a program to:
        //1.Print today’s date.
        //2.Add 10 days to the current date and display the new date.
        //3.Subtract 5 hours from the current time and display the result.
        public void AddFormating()
        {
            DateTime currentDate = DateTime.Now;
            DateTime newDate = currentDate.AddDays(10);
            Console.WriteLine($"CurrentDate is:{currentDate}");
            Console.WriteLine($"After Adding 10 days :{newDate}");
        }

        //3.Parsing Dates
        //Problem:
        //Given a string dateString = "14-Feb-2025", convert it into a DateTime object using DateTime.Parse().
        //Print the parsed date.
        //Also Use DateTime.TryParse() to ensure no errors occur if the string format is invalid.
        public void SubFormating()
        {
            DateTime currentDate = DateTime.Now;
            DateTime newDate = currentDate.AddDays(-10);
            Console.WriteLine($"CurrentDate is:{currentDate}");
            Console.WriteLine($"After Subtracting 10 days :{newDate}");
        }

        //4.Comparing Dates
        //Problem:
        //Create two DateTime objects:
        // date1 = 2025 - 02 - 14
        // date2 = 2025 - 02 - 20
        //Compare the two dates and print whether date1 is earlier, later, or the same as date2.
        public void DateConverting()
        {
            Console.WriteLine("Enter the date ");

            string userInput = Console.ReadLine();

            try
            {

                DateTime parsedDate = DateTime.Parse(userInput);


                Console.WriteLine("Parsed Date: " + parsedDate.ToString("dddd, dd MMMM yyyy"));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid date format. Please enter a valid date.");
            }
        }

        //5.Calculating the Difference Between Two Dates
        //Problem:
        //Write a program that calculates the number of days between two dates:
        // Start date: 2025 - 01 - 01
        // End date: 2025 - 02 - 14
        //Print the difference in days.
        public void DateCompare()
        {
            Console.Write("Enter the first date (yyyy-MM-dd): ");
            string input1 = Console.ReadLine();

            Console.Write("Enter the second date (yyyy-MM-dd): ");
            string input2 = Console.ReadLine();

            if (DateTime.TryParse(input1, out DateTime date1) && DateTime.TryParse(input2, out DateTime date2))
            {
                Console.WriteLine($"\nFirst Date: {date1:dddd, dd MMMM yyyy}");
                Console.WriteLine($"Second Date: {date2:dddd, dd MMMM yyyy}");

                if (date1 < date2)
                    Console.WriteLine("\nThe first date is before than the second date.");
                else if (date1 > date2)
                    Console.WriteLine("\nThe first date is after than the second date.");
                else
                    Console.WriteLine("\nBoth dates are the same.");
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter dates in yyyy-MM-dd format.");
            }

        }

        //6.Extracting Date and Time Components
        //Problem:
        //Print the following components of the current date and time:
        // Year
        // Month
        // Day
        // Hour
        // Minute
        // Second
        public void DateDifference()
        {
            Console.Write("Enter the first date (yyyy-MM-dd): ");
            string input1 = Console.ReadLine();

            Console.Write("Enter the second date (yyyy-MM-dd): ");
            string input2 = Console.ReadLine();

            if (DateTime.TryParse(input1, out DateTime date1) && DateTime.TryParse(input2, out DateTime date2))
            {
                int daysDifference = Math.Abs((date1 - date2).Days);
                Console.WriteLine($"The difference between the two dates is {daysDifference} days.");
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter dates in yyyy-MM-dd format.");
            }
        }

        //7.Time Zones and UTC Conversion
        //Problem:
        //1.Print the current local date and time.
        //2.Convert it to UTC using ToUniversalTime() and print the result.
        public void DateComponenets()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine($"Year: {now.Year}");
            Console.WriteLine($"Month: {now.Month}");
            Console.WriteLine($"Day: {now.Day}");
            Console.WriteLine($"Hour: {now.Hour}");
            Console.WriteLine($"Minute: {now.Minute}");
            Console.WriteLine($"Second: {now.Second}");
        }

        //8.Checking Leap Year
        //Problem:
        // Write a program that checks if a given year(e.g., 2024) is a leap year using DateTime.IsLeapYear().
        public void UtcDtaeConversion()
        {
            DateTime localTime = DateTime.Now;
            DateTime utcTime = localTime.ToUniversalTime();
            Console.WriteLine($"Local Time: {localTime}");
            Console.WriteLine($"UTC Time: {utcTime}");
        }

        //9.Display the First and Last Day of the Month
        //Problem:
        //Write a program that takes any date as input and displays the first and last day of that month.
        public void LeapYear()
        {
            Console.Write("Enter a year: ");
            int year;

            if (int.TryParse(Console.ReadLine(), out year))
            {
                if (DateTime.IsLeapYear(year))
                {
                    Console.WriteLine($"{year} is a Leap year");
                }
                else
                {
                    Console.WriteLine($"{year} is not  a Leap year");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid year.");
            }
        }

        //10.Add a Specific Time Duration
        //Problem:
        //Write a program that adds a TimeSpan of 2 hours, 30 minutes to the current time and prints the
        //result.
        public void DateMont()
        {
            Console.Write("Enter a date (yyyy-MM-dd): ");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime date))
            {

                DateTime firstDay = new DateTime(date.Year, date.Month, 1);
                DateTime lastDay = firstDay.AddMonths(1).AddDays(-1);


                Console.WriteLine($"First Day of the Month: {firstDay:yyyy-MM-dd}");
                Console.WriteLine($"Last Day of the Month: {lastDay:yyyy-MM-dd}");
            }
            else
            {
                Console.WriteLine("Invalid date format! Please enter in yyyy-MM-dd format.");
            }
        }
        public void AdditionTime()
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine($"Current Time: {currentTime:yyyy-MM-dd HH:mm:ss}");


            TimeSpan duration = new TimeSpan(2, 30, 0);

            DateTime newTime = currentTime.Add(duration);

            Console.WriteLine($"After Adding time {newTime}");
        }

        //11.Countdown Timer
        //Problem:
        //Given a future date(e.g., "2025-12-31"), calculate the number of days, hours, and minutes remaining
        //until that date.
        public void CountDown()
        {
            Console.Write("Enter a future date (yyyy-MM-dd HH:mm): ");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime futureDate))
            {
                DateTime currentDate = DateTime.Now;

                if (futureDate > currentDate)
                {
                    TimeSpan remainingTime = futureDate - currentDate;
                    int days = remainingTime.Days;
                    int hours = remainingTime.Hours;
                    int minutes = remainingTime.Minutes;
                    Console.WriteLine($"Time Remaining: {days} days, {hours} hours, {minutes} minutes");
                }
                else
                {
                    Console.WriteLine("Please enter a future date.");
                }
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter in yyyy-MM-dd HH:mm format.");
            }
        }
    }
}
