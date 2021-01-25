using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {   
            // DateTime
            // определение дня недели по введенной дате

            
            var userdate = Console.ReadLine();
            bool userdayOfweek = DateTime.TryParse(userdate, out DateTime day);
            if (userdayOfweek == true)
            {
                Console.WriteLine(day.DayOfWeek);
                    }
            else
            { Console.WriteLine(" Неверный формат ( dd-mm-yyyy) " ); 
                    }
            Console.ReadLine();


            // дальше можно не смотреть, это я для себя
            Console.WriteLine();
            Console.WriteLine(DateTime.Now); // выводит сегодняшнюю дату и время
            Console.WriteLine(DateTime.Today); // выводит только сегодняшнюю дату
            
            DateTime date1 = new DateTime(1983, 11, 15); 
            Console.WriteLine(date1.AddDays(3)); // добавляет 3 дня
            Console.WriteLine(date1.AddHours(12)); // добавляет 12 часов
            Console.WriteLine(date1.AddMonths(6)); // добавляет 6 месяцев
            Console.ReadKey();
                
        }
    }
}
