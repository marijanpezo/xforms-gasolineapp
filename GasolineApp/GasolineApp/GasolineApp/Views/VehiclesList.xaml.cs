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

            buttonPick.FontSize = 30;
            buttonPick.BackgroundColor = Color.Blue;
            buttonPick.TextColor = Color.White;

            BindingContext = new VehiclesViewModel();


        }
    }
}
