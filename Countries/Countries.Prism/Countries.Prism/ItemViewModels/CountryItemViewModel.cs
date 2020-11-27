﻿using Countries.Prism.Entities;
using Countries.Prism.Views;
using Prism.Commands;
using Prism.Navigation;

namespace Countries.Prism.ViewModels
{
    public class CountryItemViewModel : Country
    {
        private readonly INavigationService _navigationService;
        private DelegateCommand _selectCountryCommand;

        public CountryItemViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public DelegateCommand SelectCountryCommand => _selectCountryCommand ??
            (_selectCountryCommand = new DelegateCommand(SelectProductAsync));

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
