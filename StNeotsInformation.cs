using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StNeotsApp
{
    /// <summary>
    /// Information class
    /// </summary>
    public class StNeotsInformation
    {
        private readonly IStNeotsDemographics _demographics;
        private readonly IStNeotsWeather _weather;

        public StNeotsInformation(IStNeotsDemographics demographics, IStNeotsWeather weather)
        {
            _demographics = demographics;
            _weather = weather;
        }

        public string GetInfromation()
        {
            return $"St. Neots is a town in Cambridgeshire with a population of {{_demographics.GetPopulation()}} people. The current temperature is {{_weather.GetTemperature()}}°C.\";";
        }
    }
}
