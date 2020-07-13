using System;
using Xunit;
using SimpleAPI.Controllers;


namespace SimpleAPI.Test
{
    public class UnitTest1
    {


        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void GetReturnMyName()
        {

            var returnValue = controller.Get("eric");
            Assert.Equal("eric2", returnValue.Value);


        }
    }
}
