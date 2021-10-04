using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace assignment1.Test
{
    public class romanNumeralsTest
    {
        [Fact]
        public void intToNumeral()
        {
            var rm = new romanNumerals();
            string result = rm.ToRoman(10);
            Assert.Equal("X", result);
        }
    }
}