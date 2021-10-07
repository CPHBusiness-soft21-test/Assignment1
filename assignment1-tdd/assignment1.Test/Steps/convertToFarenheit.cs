// Gav en masse problemer at køre BDD, har arbejdet i VSCode. 
// Kunne få første test til at køre med BDD, problemet opstod i det at der skulle oprettes endnu en test.


using System;
using TechTalk.SpecFlow;
using Xunit; 

namespace assignment1.Test
{
    [Binding]
    public class ConvertToFarenheit
    {
        private readonly ScenarioContext _scenarioContext;
        private int num = 30;

        public ConvertToFarenheit(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
			
        [Given(@"a natural number celcius temperature")]
        public void Givenanaturalnumber()
        {
            Assert.True(num % 1 == 0);
        }

        [When(@"inserted into celcius converter")]
        public void Wheninsertedintoconverter()
        {
            var fc = new FarenheitConverter();
            this.num = fc.celciusToFarenheit(num);
        }

        [Then(@"first temperature is converted to farenheit")]
        public void Thenfirsttemperatureisconvertedtofarenheit()
        {
            Assert.Equal(86, num);
        }

		}
	}