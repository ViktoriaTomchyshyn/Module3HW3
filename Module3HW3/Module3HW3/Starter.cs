using System;
using System.IO;

namespace Module3HW3
{
    public class Starter
    {
        public static void Run()
        {
            var task1 = new Task1();
            var task2 = new Task2();
            Func<int, int, int> powHandler = Task1.Pow;
            int x = 8;
            int y = 5;
            int i = 4;
            Console.WriteLine("Numbers to pow: " + x + "*" + y);
            var resHandler = task2.Calc(powHandler, x, y);
            Console.WriteLine("Number to divide: " + i);
            var result = resHandler.Invoke(i);
            task1.ShowHandler.Invoke(result);
        }

        public static void Show(bool checker)
        {
            if (checker)
            {
                Console.WriteLine("Number was divided without remainder.");
            }
            else
            {
                Console.WriteLine("Number was divided with remainder.");
            }
        }
    }
}
