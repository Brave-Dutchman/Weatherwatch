using Weatherwatch.Core.Objects;

namespace Weatherwatch.Core
{
    public class RadarFactory : IFactory
    {
        private readonly Storage _storage;

        public RadarFactory()
        {
            _storage = Storage.GetInstance();
        }
        
        public void Create()
        {
            _storage.AddRadar(new Radar("rain", "http://www.buienradar.nl/image?type=zozw"));
            _storage.AddRadar(new Radar("thunder", "http://www.buienradar.nl/image?type=zozw"));
            _storage.AddRadar(new Radar("hail", "http://www.buienradar.nl/image?type=zozw"));
            _storage.AddRadar(new Radar("warning_NWC", "http://www.buienradar.nl/image?type=zozw"));
            _storage.AddRadar(new Radar("warning_knmi", "http://www.buienradar.nl/image?type=zozw"));
            _storage.AddRadar(new Radar("windmap_knmi", "http://www.buienradar.nl/image?type=zozw"));
            _storage.AddRadar(new Radar("lightning_map_europe", "http://www.buienradar.nl/image?type=zozw"));
            _storage.AddRadar(new Radar("temperaturemap_knmi", "http://www.buienradar.nl/image?type=zozw"));
        }
    }

    public interface IFactory
    {
        void Create();
    }
}
