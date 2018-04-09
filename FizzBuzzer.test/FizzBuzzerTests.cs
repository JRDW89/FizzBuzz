using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzer.test
{
    class FizzBuzzerTests
    {
            public void generateTest_IsDevisibleBy3()
            {
                    if(FizzBuzzer.generate(9) == "Fizz")
                {
                    Assert.Pass();
                }
                else
                {
                    Assert.Fail();
                }

            }

            public void generateTest_IsDevisibleBy5()
            {
                if (FizzBuzzer.generate(25) == "Buzz")
                {
                    Assert.Pass();
                }
                else
                {
                    Assert.Fail();
                }

            }
            public void generateTest_IsDevisibleBy3and5()
            {
                if (FizzBuzzer.generate(14) == "FizzBuzz")
                {
                    Assert.Pass();
                }
                else
                {
                    Assert.Fail();
                }

            }
            public void generateTest_IsDevisibleBy3and5()
            {
                if (FizzBuzzer.generate(2) == "2")
                {
                    Assert.Pass();
                }
                else
                {
                    Assert.Fail();
                }

            }

    }
}
