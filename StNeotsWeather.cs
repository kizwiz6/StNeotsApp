using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StNeotsApp
{
    /// <summary>
    /// Weather implementation
    /// </summary>
    public class StNeotsWeather : IStNeotsWeather
    {
        public double GetTemperature()
        {
            return 14.5;
        }
    }
}
