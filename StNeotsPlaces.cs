using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StNeotsApp
{
    /// <summary>
    /// Place class
    /// </summary>
    public class StNeotsPlaces
    {
        public Place[] GetPlaces()
        {
            return new[]
            {
                new Place { Name = "St. Neots Museum" },
                new Place { Name = "The Priory Centre" },
                new Place { Name = "Eynesbury Manor" },
                new Place { Name = "St. Neots Folk Museum" },
                new Place { Name = "The Riverside Park" }
            };
        }
    }
}
