using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib.Test
{

    public class CalculatorTest
    {
        [Fact]
        public void AddTest()
        {
            var calculator = new Calculator();

            var result = calculator.Add(7, 10);
            Assert.Equal(17, result);


        }

    }
}
