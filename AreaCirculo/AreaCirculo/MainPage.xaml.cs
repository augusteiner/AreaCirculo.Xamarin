using System;
using Xamarin.Forms;

namespace AreaCirculo
{
    public partial class MainPage : ContentPage
    {
        public double? Radius { get; set; }
        public double? Area { get; set; }

        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        private void ButtonCalculate_Clicked(object sender, EventArgs e)
        {
            if (Radius.HasValue)
            {
                Area = Radius.Value * 2 * Math.PI;

                OnPropertyChanged(nameof(Area));
            }
        }
    }
}
