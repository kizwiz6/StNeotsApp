﻿internal class Program
{
    private static void Main(string[] args)
    {
        var history = new StNeotsHistory();
        var events = history.GetImportantEvents();
        Console.WriteLine("Important events in St. Neots history:");
        foreach (var ev in events)
        {
            Console.WriteLine(ev);
        }

        var places = new StNeotsPlaces();
        Console.WriteLine("\nPopular places in St. Neots:");
        foreach (var place in places.GetPlaces())
        {
            Console.WriteLine(place.Name);
        }

        var info = new StNeotsInformation();
        Console.WriteLine("\nInformation about St.Neots:");
        Console.WriteLine(info.GetInformation());

        var demographics = new StNeotsDemographics();
        Console.WriteLine("\nDemographics of St. Neots:");
        Console.WriteLine(demographics.GetDemographics());

        var weather = new StNeotsWeather();
        Console.WriteLine("\nCurrent weather in St. Neots:");
        Console.WriteLine(weather.GetCurrentWEather());

        Console.ReadLine();
    }
}