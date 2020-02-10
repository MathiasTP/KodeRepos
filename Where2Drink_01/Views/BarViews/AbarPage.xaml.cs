using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Where2Drink_01.Models;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Where2Drink_01.Views.BarViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbarPage : ContentPage
    {

        public string AboutBar { get; } = "Abar ligger ved åen og er stedet for de unge, hvor der er fyldt med gode priser!";

        public string OpenTime { get; } = "Onsdag - 18:00-02:00\n" +
                                          "Torsdag - 18:00-05:00\n" +
                                          "Fredag - 18:00-05:00\n" +
                                          "Lørdag - 18:00-05:00\n";
        public AbarPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        Pin Abarpin = new Pin()
        {
            Label = "Australian Bar",
            Address = "Ved Åen",
            Type = PinType.Place,
            Position = new Position(56.154991, 10.209857)
        };

        private int GridHeight = 200;
        private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            Shell.SetTabBarIsVisible(this, false);
            if (ScrollViewet.ScrollY > 0)
            {
                if(GridHeight<40)
                {
                    return;
                }
                
                GridHeight = GridHeight - 2;
                Griddet.HeightRequest = GridHeight;
                
            }
            if(ScrollViewet.ScrollY < 50)
            {
                Griddet.HeightRequest = 210;
                Shell.SetTabBarIsVisible(this, true);
            }
        }
    }
}