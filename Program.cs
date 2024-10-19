using System;

 namespace Constructor
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day:");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the month:");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the year:");
            int year = int.Parse(Console.ReadLine());

            Date d1 = new Date(day,month,year);

            Console.WriteLine(d1.GetDate());
        }


    }

    public class Date
    {
     private static readonly int[] DaysMonths365 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
     private static readonly int[] leap_year366  =  {0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
     
     private readonly int year =01;
     private readonly int month = 01;
     private readonly int day = 01;


        public  Date(int day , int month , int year )
        {
           var isLeap = year % 4 == 0 && (year % 100 != 0) || (year % 400 == 0);
            if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
            {
                int[] days = isLeap ? leap_year366 : DaysMonths365;
                if (day >= 1 && day <= days[month])
                {
                    this.year = year;
                    this.month = month;
                    this.day = day;
                }
                else
                {
                    Console.WriteLine("Invalid day for the given month.");
                }
            }
            else
            {
                Console.WriteLine("Invalid month or year.");
            }
        }
        

        public Date(int year) : this (01,01,year)
        {
        }

        public Date(int month , int year) : this(01, month, year)
        {
        }

        public string GetDate()
        {
            return $"{day.ToString().PadLeft(2, '0')}/{month.ToString().PadLeft(2, '0')}/{year.ToString().PadLeft(4, '0')}";
        }
    }
}