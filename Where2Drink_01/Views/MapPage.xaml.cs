using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Where2Drink_01.Views.BarViews;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Where2Drink_01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {

        public MapPage()
        {
            InitializeComponent();
            Mappet.Pins.Add(Abarpin);
            Mappet.Pins.Add(GuldhornPin);
            Mappet.Pins.Add(HeidisPin);

            Abarpin.MarkerClicked += async (s, args) =>
            {
                args.HideInfoWindow = true;
                string pinName = ((Pin)s).Label;
                await Application.Current.MainPage.Navigation.PushModalAsync(new AbarPage());
                
            };

            GuldhornPin.MarkerClicked += async (s, args) =>
            {
                args.HideInfoWindow = true;
                string pinName = ((Pin)s).Label;
                await Application.Current.MainPage.Navigation.PushModalAsync(new GuldhornPage());

            };

            HeidisPin.MarkerClicked += async (s, args) =>
            {
                args.HideInfoWindow = true;
                string pinName = ((Pin)s).Label;
                await Application.Current.MainPage.Navigation.PushModalAsync(new HeidisPage());

            };
        }

        Pin Abarpin = new Pin()
        {
            Label = "Australian Bar",
            Address = "Ved Åen",
            Type = PinType.Place,
            Position = new Position(56.154991, 10.209857)
        };

        Pin GuldhornPin = new Pin()
        {
            Label = "Guldhornene",
            Address = "Ved Åen",
            Type = PinType.Place,
            Position = new Position(56.158897, 10.206834)
        };

        Pin HeidisPin = new Pin()
        {
            Label = "Heidis BierBar",
            Address = "Ved Åen",
            Type = PinType.Place,
            Position = new Position(56.158966, 10.206375)
        };
        
    }
}