using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using GasolineApp.Model;
using System.Collections.Generic;
using GasolineApp.Data;

namespace GasolineApp.ViewModel
{
    public class LiterTabbedViewModel: ViewModelBase
    {
        public List<Refill> refills { get; private set; } = new List<Refill>();
        //public RefillDatabase refillDatabase;

        private decimal sumLiter;
        public decimal SumLiter
        {
            get { return sumLiter; }
            set { Set(ref sumLiter, value); }
        }

        public LiterTabbedViewModel()
        {
//            if (refills == null)
//            {
//                refills = new List<Refill>();
//            }
//            else
//            {
//                
//            }

            //            refillDatabase = new RefillDatabase();
            //            var refillsDatabse = refillDatabase.GetRefills();
            //
            //            refills = (List<Refill>) refillsDatabse;
            

            Messenger.Default.Register<Refill>(this, (refillSend) =>
            {
                refills.Add(refillSend);
                foreach (var litre in refills)
                {
                    sumLiter += litre.Litres;
                }
            });


            
        }

    }
}
