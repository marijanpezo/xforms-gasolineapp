using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Messaging;
using GasolineApp.ViewModel;
using Xamarin.Forms;

namespace GasolineApp.Views
{
    public partial class MileageTabbed : ContentPage
    {
        public MileageTabbed()
        {
            InitializeComponent();
            BindingContext=new MileageTabbedViewModel();
        }

        private void ListViewMileage_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }

            ((ListView)sender).SelectedItem = null;
        }

        protected override bool OnBackButtonPressed()
        {
            Messenger.Default.Unregister(this);
            return base.OnBackButtonPressed();
        }
    }
}
