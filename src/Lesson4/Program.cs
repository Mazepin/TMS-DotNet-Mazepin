using System;

namespace Lesson4
{
    
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start;
            DateTime end;

            //while (true)
            //{
            //    DateTime.TryParse(Console.ReadLine(), out start);
            //    end = DateTime.Parse(Console.ReadLine());

            //    if (start <= end)
            //    {
            //        break;
            //    }

            //    Console.WriteLine("Ошибка! Попробуйте снова");
            //}

            DateTime.TryParse(Console.ReadLine(), out start);
            end = DateTime.Parse(Console.ReadLine()); // 0001.01.01 - 9999.12.12

            if (start > end)
            {
                DateTime temp;
                temp = start;
                start = end;
                end = temp;
            }

            var dayOfWeek = Console.ReadLine();

            var list = GetDaysByUserInput(start, end, dayOfWeek);

            ChangeSomething((ListWrapper<DateTime>)list);

            Console.ReadKey();
        }

        private static void ChangeSomething(ListWrapper<DateTime> dateTimes)
        {
            var qqq = dateTimes.Clone();

            var newDateTimes = new List<DateTime>();
            foreach (var date in dateTimes)
            {
                newDateTimes.Add(date);
            }

            newDateTimes.Clear();
        }

        private static List<DateTime> GetDaysByUserInput(DateTime start, DateTime end, string dayOfWeek)
        {
            var filterdDays = new List<DateTime>();
            while (end >= start)
            {
                if (start.DayOfWeek.ToString() == dayOfWeek)
                {
                    filterdDays.Add(start);
                }

                start = start.AddDays(1);
            }

            foreach (var day in filterdDays)
            {
                Console.WriteLine(day.Date);
            }

            Console.WriteLine("---");
            Console.WriteLine(filterdDays.Count);

            return filterdDays;
        }
    }
}