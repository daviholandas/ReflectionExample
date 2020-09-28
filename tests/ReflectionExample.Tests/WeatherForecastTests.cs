using System;
using System.Reflection;
using ReflectionExample.WebApi;
using Xunit;

namespace ReflectionExample.Tests
{
    public class WeatherForecastTests
    {
        [Fact]
        public void WeatherForest_SumOfTemperatures_ShouldReturnIntValue()
        {
            //Arrange
            WeatherForecast weather = new WeatherForecast();
            var reflectedWeather = typeof(WeatherForecast)
                .GetMethod("SumOfTemperatures", BindingFlags.NonPublic | BindingFlags.Instance);
            //Act
            var result = reflectedWeather.Invoke(weather, new object?[]{1, 2});
            var resultExpected = 3;
            //Assert
            Assert.Equal(resultExpected, result);

        }
    }
}
