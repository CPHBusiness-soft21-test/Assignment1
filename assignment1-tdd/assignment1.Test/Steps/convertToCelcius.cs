//For opgaven givet i timen, ikke relevant for opgaven. 
// Gav en masse problemer at køre BDD, har arbejdet i VSCode. 
// Kunne få første test til at køre med BDD, problemet opstod i det at der skulle oprettes endnu en test.

using System;
using TechTalk.SpecFlow;
using Xunit;

namespace assignment1.Test
{
    [Binding]
    public class ConvertToCelcius
    {
        private readonly ScenarioContext _scenarioContext;

        private int num = 50;

        public ConvertToCelcius(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"a natural number farenheit temperature")]
        public void Givenanaturalnumber()
        {
            Assert.True(num % 1 == 0);
        }

        [When(@"inserted into farenheit converter")]
        public void Wheninsertedintoconverter()
        {
            var fc = new FarenheitConverter();
            this.num = fc.farenheitToCelcius(num);
        }

        [Then(@"first temperature is converted to celcius")]
        public void Thenfirsttemperatureisconvertedtocelcius()
        {
            Assert.Equal(10, num);
        }
    }
}