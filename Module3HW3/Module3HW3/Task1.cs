using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW3
{
    public class Task1
    {
        public Task1()
        {
            ShowHandler = Starter.Show;
        }

        public Action<bool> ShowHandler { get; }

        public static int Pow(int x, int y)
        {
            var res = x * y;
            Console.WriteLine("Pow: " + res);
            return res;
        }
    }
}
