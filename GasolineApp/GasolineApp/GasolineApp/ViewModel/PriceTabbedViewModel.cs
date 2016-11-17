using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Messaging;
using GasolineApp.Model;

namespace GasolineApp.ViewModel
{
    public class PriceTabbedViewModel
    {
        public List<Refill> refills { get; private set; }


        public PriceTabbedViewModel()
        {
            if (refills == null)
            {
                refills = new List<Refill>();
            }

            Messenger.Default.Register<Refill>(this, (refillSend) =>
            {
                refills.Add(refillSend);
            });
        }
    }
}
