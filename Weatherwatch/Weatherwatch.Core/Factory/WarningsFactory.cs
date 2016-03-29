using Weatherwatch.Core.Objects;

namespace Weatherwatch.Core.Factory
{
    public class WarningsFactory : IFactory
    {
        private readonly Storage _storage;

        public WarningsFactory()
        {
            _storage = Storage.GetInstance();
        }

        public void Create()
        {
            _storage.AddWarning(new Warning("Emmen, The Netherlands", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.06279.json"));
            _storage.AddWarning(new Warning("Meppen, Germany", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.10304.json"));
            _storage.AddWarning(new Warning("Groningen, The Netherlands", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.06280.json"));
            _storage.AddWarning(new Warning("Leeuwarden, The Netherlands", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.06270.json"));
            _storage.AddWarning(new Warning("Den Helder, The Netherlands", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.06235.json"));
            _storage.AddWarning(new Warning("Amsterdam, The Netherlands", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.06240.json"));
            _storage.AddWarning(new Warning("Rotterdam, The Netherlands", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.06344.json"));
            _storage.AddWarning(new Warning("Enschede, The Netherlands", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.06290.json"));
            _storage.AddWarning(new Warning("Nijmegen, The Netherlands", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.06375.json"));
            _storage.AddWarning(new Warning("Tilburg, The Netherlands", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.06350.json"));
            _storage.AddWarning(new Warning("Middelburg, The Netherlands", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.06310.json"));
            _storage.AddWarning(new Warning("Maastricht, The Netherlands", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.06380.json"));
            _storage.AddWarning(new Warning("London, England", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.03772.json"));
            _storage.AddWarning(new Warning("Glasgow, Schotland", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.03140.json"));
            _storage.AddWarning(new Warning("Berlin, Germany", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.10389.json"));
            _storage.AddWarning(new Warning("Munich, Germany", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.10866.json"));
            _storage.AddWarning(new Warning("Paris, France", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.07156.json"));
            _storage.AddWarning(new Warning("Madrid, Spain", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.08221.json"));
            _storage.AddWarning(new Warning("Lissabon, Portugal", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.08536.json"));
            _storage.AddWarning(new Warning("Vienna, Austria", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.11034.json"));
            _storage.AddWarning(new Warning("Helsinki, Finland", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.02974.json"));
            _storage.AddWarning(new Warning("Stockholm, Sweden", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.02485.json"));
            _storage.AddWarning(new Warning("Göteborg, Sweden", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.02513.json"));
            _storage.AddWarning(new Warning("Oslo, Norway", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.01488.json"));
            _storage.AddWarning(new Warning("Genua, Italy", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.16120.json"));
            _storage.AddWarning(new Warning("Arezzo, Italy", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.16172.json"));
            _storage.AddWarning(new Warning("Catania, Italy", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.16460.json"));
            _storage.AddWarning(new Warning("Interlaken, Switserland", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.06734.json"));
            _storage.AddWarning(new Warning("Alicante, Spain", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.08360.json"));
        }
    }
}
