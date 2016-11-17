using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Messaging;
using GasolineApp.Model;

namespace GasolineApp.ViewModel
{
    public class MileageTabbedViewModel
    {
        public List<Refill> refills { get; private set; }


        public MileageTabbedViewModel()
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
