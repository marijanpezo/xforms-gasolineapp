using GasolineApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GasolineApp.Services
{
    class NavigationService : INavigationService
    {
        public async void NavigateToNextPage(Page page)
        {
            var currentPage = GetCurrentPage();

            await currentPage.Navigation.PushAsync(page);
        }

        private Page GetCurrentPage()
        {
            var currentPage = Application.Current.MainPage.Navigation.NavigationStack.LastOrDefault();

            return currentPage;
        }
    }
}
