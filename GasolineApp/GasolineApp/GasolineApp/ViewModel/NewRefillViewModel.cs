using GalaSoft.MvvmLight;
using GasolineApp.Model;
using GasolineApp.Services;
using GasolineApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GasolineApp.ViewModel
{
    public class NewRefillViewModel: ViewModelBase
    {
        public ICommand OnClickedVehicle { get; private set; }
        public ICommand buttonRefillClicked { get; }

        long mileage;
        public long Mileage
        {
            get
            {
                return mileage;
            }
            set
            {
                Set(ref mileage, value);
            }
        }
        decimal liter;
        public decimal Liter
        {
            get { return liter; }
            set
            {
                Set(ref liter, value);
            }
        }
        decimal pricePerLiter;
        public decimal PricePerLiter
        {
            get { return pricePerLiter; }
            set
            {
                Set(ref pricePerLiter, value);
            }
        }

        public NewRefillViewModel()
        {
            var navigation = new NavigationService();

            OnClickedVehicle = new Command(() =>
            {
                navigation.NavigateToNextPage(new VehiclesList());
            });

            buttonRefillClicked = new Command(() =>
            {
                Refill refillSend = new Refill();

                refillSend.Date = DateTime.Today;
                refillSend.Litres = liter;
                refillSend.Mileages = mileage;
                refillSend.PricePerLitre = pricePerLiter;
                refillSend.Price = pricePerLiter * liter;


                navigation.NavigateToNextPage(new Stat());
            });
        }

    }
}
