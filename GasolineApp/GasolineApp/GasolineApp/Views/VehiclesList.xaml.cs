using GalaSoft.MvvmLight.Messaging;
using GasolineApp.Model;
using GasolineApp.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using Xamarin.Forms;

namespace GasolineApp.Views
{
    public partial class VehiclesList : ContentPage
    {
        public VehiclesList()
        {
            InitializeComponent();
            Title = "Vehicles";

            BindingContext = new VehiclesViewModel();

            
        }

        private void listViewVehicle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            if (e.SelectedItem == null)
            {
                return; 
            }

            Messenger.Default.Send((Vehicle)e.SelectedItem);
            Navigation.PopAsync();
        }
    }
}
