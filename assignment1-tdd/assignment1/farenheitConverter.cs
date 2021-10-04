using System;

namespace assignment1
{
    public class FarenheitConverter
    {
        public int farenheitToCelcius(int farenheit){
            //First implementation. 
            //if(farenheit == 50){
            //    return 10;
            //}
            //throw new NotImplementedException("Not implemented yet.");

            //refactored
            return (farenheit - 32) * 5 / 9;
        }

        public int celciusToFarenheit(int celcius){
            //first implementation.
            // if(celcius == 30){
            //     return 86;
            // }
            // throw new NotImplementedException("Not implemented.");

            //refactored
            return (celcius * 9) / 5 + 32;
        }
    }
}
