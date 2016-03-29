using Weatherwatch.Core.Objects;

namespace Weatherwatch.Core.Factory
{
    public class RadarFactory
    {
        private readonly Storage _storage;

        public RadarFactory()
        {
            _storage = Storage.GetInstance();
        }
        
        public void Create()
        {
            _storage.AddRadar(new Radar("rain", "http://www.buienradar.nl/image?type=zozw"));
            _storage.AddRadar(new Radar("thunder", "http://www.buienradar.nl/image?type=lightningzozw&fn=buienradarnl-1x1-ani550-1uurbliksem.gif"));
            _storage.AddRadar(new Radar("hail", "http://www.buienradar.nl/image?type=hailzozw&fn=buienradarnl-1x1-hail-ani550.gif"));
            _storage.AddRadar(new Radar("warning_NWC", "http://alarm.noodweercentrale.nl/images/map/nederland_index.png"));
            _storage.AddRadar(new Radar("warning_knmi", "http://www.knmi.nl/waarschuwingen_en_verwachtingen/images/waarschuwing_land.png"));
            _storage.AddRadar(new Radar("windmap_knmi", "http://www.knmi.nl/actueel/images/windbftgmt.png"));
            _storage.AddRadar(new Radar("temperaturemap_knmi", "http://www.knmi.nl/actueel/images/tempgmt.png"));
            _storage.AddRadar(new Radar("lightning_map_europe", "http://images.lightningmaps.org/blitzortung/europe/index.php?map=0"));
        }
    }
}
