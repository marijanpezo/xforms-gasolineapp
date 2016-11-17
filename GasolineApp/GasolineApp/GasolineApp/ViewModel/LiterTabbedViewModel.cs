using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using GasolineApp.Model;
using System.Collections.Generic;
using GasolineApp.Data;

namespace GasolineApp.ViewModel
{
    public class LiterTabbedViewModel: ViewModelBase
    {
        public List<Refill> refills { get; private set; }
        //public RefillDatabase refillDatabase;
        
        public LiterTabbedViewModel()
        {
            if (refills == null)
            {
                refills = new List<Refill>();
            }
            
//            refillDatabase = new RefillDatabase();
//            var refillsDatabse = refillDatabase.GetRefills();
//
//            refills = (List<Refill>) refillsDatabse;

            Messenger.Default.Register<Refill>(this, (refillSend) =>
            {
                refills.Add(refillSend);
            });

            
        }

    }
}
