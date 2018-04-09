using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzzer
    {
        public string generate(int i)
        {
            string str = "";

            if (i % 3 == 0)
            {
                str = "Fizz";
            }
            else if (i % 5 == 0)
            {
                str = "Buzz";
            }
            else if (i % 3 == 0 && i % 5 == 0)
            {
                str = "FizzBuzz"
            }
            else if(i % 3 != 0 && i % 5 != 0)
            {
                str = i.toString();
            }

            return str;
        }
    }
}
