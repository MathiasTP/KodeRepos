using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Where2Drink_01.Views.BarViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GuldhornPage : ContentPage
    {
        public GuldhornPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        private int GridHeight = 200;
        private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            Shell.SetTabBarIsVisible(this, false);
            if (ScrollViewet.ScrollY > 0)
            {
                if (GridHeight < 40)
                {
                    return;
                }

                GridHeight = GridHeight - 2;
                Griddet.HeightRequest = GridHeight;

            }
            if (ScrollViewet.ScrollY < 50)
            {
                Griddet.HeightRequest = 210;
                Shell.SetTabBarIsVisible(this, true);
            }
        }
    }
}