using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
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
using GasolineApp.Data;
using Xamarin.Forms;

namespace GasolineApp.ViewModel
{
    public class NewRefillViewModel : ViewModelBase
    {
        public ICommand OnClickedVehicle { get; private set; }
        public ICommand buttonRefillClicked { get; private set; }

        private Refill refillSend = new Refill();

        //public RefillDatabase refillDatabase;


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
            if (refillSend != null)
            {
                refillSend = new Refill();
            }
            refillSend = new Refill();


            var navigation = new NavigationService();

            Messenger.Default.Register<Vehicle>(this, vehicle =>
            {
                refillSend.Vehicle = vehicle;
            });


            OnClickedVehicle = new Command(() =>
            {
                navigation.NavigateToNextPage(new VehiclesList());
            });

            buttonRefillClicked = new Command( () =>
            {
                
                //refillDatabase= new RefillDatabase();

                refillSend.Date = DateTime.Today;
                refillSend.Litres = liter;
                refillSend.PricePerLitre = pricePerLiter;
                refillSend.Price = pricePerLiter * liter;
                refillSend.Mileages = 0;
                refillSend.Mileages = mileage - refillSend.Vehicle.Mileage;

                

                //refillDatabase.AddRefill(refillSend);

                navigation.NavigateToNextPage(new Stat());



                Messenger.Default.Send(refillSend);
                Messenger.Default.Unregister(this);

            });
        }

    }
}
