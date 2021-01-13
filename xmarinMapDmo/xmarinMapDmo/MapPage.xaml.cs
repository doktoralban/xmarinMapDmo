using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace xmarinMapDmo
{
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();

            CustomPin pin = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(41.02588959503038, 28.974647597264806),
                Label = "Galata Kulesi",
                Address = "Galata Kulesi İstanbul Türkiye",
                Name = "Galata Kulesi",
                Url = "www.istanbul.com.tr"
            };
            customMap.CustomPins = new List<CustomPin> { pin };
            customMap.Pins.Add(pin);
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(41.02588959503038, 28.974647597264806), Distance.FromKilometers(1.0)));
        }
    }
}
