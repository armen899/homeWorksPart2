using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(DateTime.IsLeapYear(2024));
            //Console.WriteLine(DateTime.MinValue);
            //Console.WriteLine(DateTime.DaysInMonth(2023, 2));

            MyDate date = new MyDate(8, 7, 2024);

            if (date.IsValidDate())
            {
                Console.WriteLine($"Date {date.Day}/{date.Month}/{date.Year} is valid.");

                MyDate nextDate = date.NextDay();

                Console.WriteLine($"Next date: {nextDate.Day}/{nextDate.Month}/{nextDate.Year}");
            }
            else
            {
                Console.WriteLine($"Date {date.Day}/{date.Month}/{date.Year} is not valid.");
            }
        }
    }

    public struct MyDate
    {
        public int Day;
        public int Month;
        public int Year;

        public MyDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public bool IsValidDate()
        {
            if (Day < 1 || Day >31)
            {
                return false;
            }

            if (Year < 1)
            {
                return false;
            }

            if (Month < 1 || Month > 12)
            {
                return false;
            }

            int lastDay = DateTime.DaysInMonth(Year, Month);
            if (Day > lastDay)
            {
                return false;
            }

            return true;
        }

        public MyDate NextDay()
        {
            int lastDays = DateTime.DaysInMonth(Year, Month);

            if (Day < lastDays)
            {
                return new MyDate(Day + 1, Month, Year);
            }
            else
            {
                int nextMonth = Month + 1;
                int nextYear = Year;

                if (nextMonth > 12)
                {
                    nextMonth = 1;
                    nextYear++;
                }

                return new MyDate(1, nextMonth, nextYear);
            }
        }
    }
}
