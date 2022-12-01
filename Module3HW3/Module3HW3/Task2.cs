using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW3
{
    public class Task2
    {
        private int _result;
        public Func<int, bool> Calc(Func<int, int, int> powHandler, int x, int y)
        {
            _result = powHandler.Invoke(x, y);
            Func<int, bool> resultHandler = null;
            resultHandler += Result;
            return resultHandler;
        }

        public bool Result(int i)
        {
            int remainder = _result % i;
            if (remainder == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
