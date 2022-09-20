using System;

namespace HomeW0rk2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Palindrome
            int number = 0;
            while (true)
            {
                Console.Write("Введите число: ");
                if (int.TryParse(Console.ReadLine(), out number))
                    break;
                else
                    Console.WriteLine("Неверное число.");
            }
            int oldValue = number;
            int newValue = 0;
            while (number > 0)
            {
                int dig = number % 10;
                newValue = newValue * 10 + dig;
                number = number / 10;
            }
            if (newValue == oldValue)
                Console.WriteLine("Число является палиндромом");
            else
                Console.WriteLine("Число не является палиндромом");
            Console.Write("Нажмите любую клавишу...");
            Console.ReadKey();
            #endregion
        }
    }
}






