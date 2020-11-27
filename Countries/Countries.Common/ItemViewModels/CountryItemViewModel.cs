using Countries.Web.Data.Entities;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Countries.Common.ItemViewModels
{
    public class CountryItemViewModel : Country
    {
        private readonly INavigationService _navigationService;
        private DelegateCommand _selectProductCommand;

        public CountryItemViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public DelegateCommand SelectProductCommand => _selectProductCommand ??
            (_selectProductCommand = new DelegateCommand(SelectProductAsync));

        private async void SelectProductAsync()
        {
            NavigationParameters parameters = new NavigationParameters
            {
               { "country", this }
            };

            await _navigationService.NavigateAsync(nameof(CountryDetails), parameters);
        }

    }
}
