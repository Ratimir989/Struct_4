using System;

namespace Struct_4
{
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayCalculator();
            Console.ReadLine();
        }
        static void BirthdayCalculator()
        {
            Console.WriteLine("Введите дату вашего рождения в формате ГГГГ.ММ.ДД:");
            string[] birthday = Console.ReadLine().Split('.');
            try
            {
                DateTime date = new DateTime(Convert.ToInt32(birthday[0]), Convert.ToInt32(birthday[1]), Convert.ToInt32(birthday[2]));
                DateTime ng = new DateTime(DateTime.Now.Year, 12, 31);
                int ostDay = date.DayOfYear - DateTime.Now.DayOfYear;
                if (date.Year > DateTime.Now.Year)
                    throw new Exception();
                else if (ostDay < 0)
                {
                    ostDay = ng.DayOfYear - DateTime.Now.DayOfYear + date.DayOfYear;
                }
                Console.WriteLine($"До вашего следующего дня рождения осталось {ostDay} дней!");
            }
            catch
            {
                Console.WriteLine("Ошибка ввода, попробуйте ещё!");
                BirthdayCalculator();
            }
        }
    }
}
