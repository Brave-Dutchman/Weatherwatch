using Weatherwatch.Core.Objects;

namespace Weatherwatch.Core.Factory
{
    public class WarningsFactory
    {
        private readonly Storage _storage;

        public WarningsFactory()
        {
            _storage = Storage.GetInstance();
        }

        public void Create()
        {
            _storage.AddWarning(new WarningLocation("Emmen, The Netherlands", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.06279.json"));
            _storage.AddWarning(new WarningLocation("Meppen, Germany", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.10304.json"));
            _storage.AddWarning(new WarningLocation("Groningen, The Netherlands", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.06280.json"));
            _storage.AddWarning(new WarningLocation("Leeuwarden, The Netherlands", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.06270.json"));
            _storage.AddWarning(new WarningLocation("Den Helder, The Netherlands", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.06235.json"));
            _storage.AddWarning(new WarningLocation("Amsterdam, The Netherlands", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.06240.json"));
            _storage.AddWarning(new WarningLocation("Rotterdam, The Netherlands", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.06344.json"));
            _storage.AddWarning(new WarningLocation("Enschede, The Netherlands", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.06290.json"));
            _storage.AddWarning(new WarningLocation("Nijmegen, The Netherlands", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.06375.json"));
            _storage.AddWarning(new WarningLocation("Tilburg, The Netherlands", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.06350.json"));
            _storage.AddWarning(new WarningLocation("Middelburg, The Netherlands", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.06310.json"));
            _storage.AddWarning(new WarningLocation("Maastricht, The Netherlands", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.06380.json"));
            _storage.AddWarning(new WarningLocation("London, England", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.03772.json"));
            _storage.AddWarning(new WarningLocation("Glasgow, Schotland", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.03140.json"));
            _storage.AddWarning(new WarningLocation("Berlin, Germany", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.10389.json"));
            _storage.AddWarning(new WarningLocation("Munich, Germany", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.10866.json"));
            _storage.AddWarning(new WarningLocation("Paris, France", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.07156.json"));
            _storage.AddWarning(new WarningLocation("Madrid, Spain", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.08221.json"));
            _storage.AddWarning(new WarningLocation("Lissabon, Portugal", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.08536.json"));
            _storage.AddWarning(new WarningLocation("Vienna, Austria", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.11034.json"));
            _storage.AddWarning(new WarningLocation("Helsinki, Finland", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.02974.json"));
            _storage.AddWarning(new WarningLocation("Stockholm, Sweden", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.02485.json"));
            _storage.AddWarning(new WarningLocation("Göteborg, Sweden", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.02513.json"));
            _storage.AddWarning(new WarningLocation("Oslo, Norway", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.01488.json"));
            _storage.AddWarning(new WarningLocation("Genua, Italy", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.16120.json"));
            _storage.AddWarning(new WarningLocation("Arezzo, Italy", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.16172.json"));
            _storage.AddWarning(new WarningLocation("Catania, Italy", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.16460.json"));
            _storage.AddWarning(new WarningLocation("Interlaken, Switserland", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.06734.json"));
            _storage.AddWarning(new WarningLocation("Alicante, Spain", "http://api.wunderground.com/api/488284ebe34e2e82/alerts/q/zmw:00000.1.08360.json"));
        }
    }
}
