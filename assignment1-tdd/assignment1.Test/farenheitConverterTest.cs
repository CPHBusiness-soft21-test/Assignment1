using System;
using Xunit;

namespace assignment1.Test
{
    
    public class farenheitConverterTest
    {
        
        [Fact]
        public void temperatureConversionFarenheit(){
            var fc = new FarenheitConverter();
            int temp = 50;

            int result = fc.farenheitToCelcius(temp);

            Assert.Equal(result, 10);
        }

        [Fact]
        public void temperatureConversionCelcius(){
            var fc = new FarenheitConverter();
            int temp = 30;

            int result = fc.celciusToFarenheit(temp);

            Assert.Equal(result, 86);
        }
        
    }
}