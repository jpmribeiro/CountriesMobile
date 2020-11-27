using Countries.Prism.Entities;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Countries.Prism.ViewModels
{
    public class CountryDetailsViewModel : ViewModelBase
    {
        private Country _country;

        public CountryDetailsViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Country";
        }

        public Country Country
        {
            get => _country;
            set => SetProperty(ref _country, value);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("country"))
            {
                Country = parameters.GetValue<Country>("country");
                Title = Country.Name;
            }
        }

    }
}
