using System.Collections.Generic;

namespace Weatherwatch.Core.Objects
{
    //Classes to get warnings from WeatherUnderground API
    public class Features
    {
        public int alerts { get; set; }
    }

    public class Response
    {
        public string version { get; set; }
        public string termsofService { get; set; }
        public Features features { get; set; }
    }

    public class RootObject
    {
        public Response response { get; set; }
        public string query_zone { get; set; }
        public List<object> alerts { get; set; }
    }
}
