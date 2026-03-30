using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Unitest
{
    
    public class Calculator
    {
        [Fact]
        public void Test()
        {
            var equals = true;
            Assert.True(equals);

            var num1 = 12.1;
            var num2 = 12.1;

            Assert.IsType<double>(num1);  
            Assert.IsType<double>(num2);
                

        }
    }
}
