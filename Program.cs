using System;

namespace Module_11._7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрос ввода имени
            Console.Write("Enter your name: ");
            // Объявление и инициализация переменной name, получение информации с консоли в переменную
            string name = Console.ReadLine();
            // Запрос ввода возраста
            Console.Write("Enter your age: ");
            // Объявление и инициализация переменной age, получение информации с консоли в переменную
            string age = Console.ReadLine();
            // Вывод полученной информации о имени и возрасте на консоль
            Console.WriteLine("Your name is {0} and age is {1}", name, age);
            // Запрос ввода даты рождения
            Console.Write("Enter your birthdate: ");
            // Объявление и инициализация переменной birthdate, получение информации с консоли в переменную
            var birthdate = Console.ReadLine();
            // Вывод полученной информации о дате рождения на консоль
            Console.WriteLine("Your birthdate is " + birthdate);
            // Предотвращение закрытия окна консоли
            Console.ReadKey();
        }
    }
}
