using GasolineApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GasolineApp.Views
{
    public partial class NewRefill : ContentPage
    {
        public NewRefill()
        {
            
            InitializeComponent();
            this.Title = "Gasoline App";

            buttonRefill.BackgroundColor = Color.Green;
            buttonRefill.TextColor = Color.White;
            buttonRefill.FontSize = 30;

            labelPickedVehicle.FontSize = 20;

            BindingContext = new NewRefillViewModel();

        }
        async private void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VehiclesList());
        }

        async private void buttonRefill_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Stat());
        }
    }
}
