using System;

namespace Module_9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lastNames = { "Дмитрий", "Станислав", "Роман", "Александр", "Андрей" };
            NumberReader numberReader = new NumberReader();
            numberReader.NumberEnteredEvent += SortNames;

            while (true)
            {

                try
                {
                    numberReader.Read(lastNames);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверное значение.");
                }
                catch (WrongNumberException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        static void SortNames(int number, string[] arr)
        {
            Array.Sort<string>(arr);

            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine("Отобран A-Я:");
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Отобран Я-А:");
                        Array.Reverse(arr);                
                        break;
                    }
            }

            foreach (string ln in arr)
            {
                Console.WriteLine(ln);
            }
        }
    }

}
