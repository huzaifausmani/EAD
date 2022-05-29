using System;
using Microsoft.AspNetCore.Mvc;

namespace webapp.ViewComponents
{
    [ViewComponent(Name = "WeatherSummary")]
    public class WeatherSummary: ViewComponent
    {
        public string Invoke()
        {
            return "This is weather summary from simple View component that returns just a string.";
        }
    }
}
