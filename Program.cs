//**********************************************************************
//*Практическая работа №3                                              *
//*Выполнил: Шмидт Е.А., группа 2-ИСП                                  *
//*Задание: cоставление программ разветвляющейся усложненной структуры.*
//**********************************************************************




using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая №3";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;

            int num1, num2, num3; //объявление переменных
            Console.WriteLine("Здравствуйте");
            Console.Write("Введите 1-ое число: "); //просим пользователя ввести значение
            num1 = Int32.Parse(Console.ReadLine()); // явное преобразование в тип int
            Console.Write("Введите 2-ое число: ");
            num2 = Int32.Parse(Console.ReadLine());
            Console.Write("Введите 3-ое число: ");
            num3 = Int32.Parse(Console.ReadLine());

            bool allpositiv = num1 > 0 && num2 > 0 && num3 > 0; //проверка условия "все числа положительные"

            switch (allpositiv)
            {
                case true: Console.WriteLine("Все числа положительные!"); break;
                case false:
                    Console.WriteLine("Данные числа не соответсвтуют условию, мешают выполнению программы: ");
                    switch (num1 == 0)
                    {
                        case true: Console.WriteLine(num1); break;
                    }
                    switch (num1 < 0)
                    {
                        case true: Console.WriteLine(num1); break;
                    }
                    switch (num2 == 0)
                    {
                        case true: Console.WriteLine(num2); break;
                    }
                    switch (num2 < 0)
                    {
                        case true: Console.WriteLine(num2); break;
                    }
                    switch (num3 == 0)
                    {
                        case true: Console.WriteLine(num3); break;
                    }
                    switch (num3 < 0)
                    {
                        case true: Console.WriteLine(num3); break;
                    }
                    break;
            }

            Console.ReadKey();
        }
    }
}
