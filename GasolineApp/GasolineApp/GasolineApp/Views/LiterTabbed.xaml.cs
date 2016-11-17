using GalaSoft.MvvmLight.Messaging;
using Xamarin.Forms;
using GasolineApp.ViewModel;

namespace GasolineApp.Views
{
    public partial class LiterTabbed
    {

        public LiterTabbed()
        {
            InitializeComponent();

            BindingContext = new LiterTabbedViewModel();
            
        }

        protected override bool OnBackButtonPressed()
        {
            Messenger.Default.Unregister(this);
            return base.OnBackButtonPressed();
        }


        private void listViewLitre_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; 
            }

            ((ListView)sender).SelectedItem = null;
        }
    }
}
