using Countries.Prism.Entities;
using Countries.Prism.Services;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Essentials;


namespace Countries.Prism.ViewModels
{
    public class CountriesPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IApiService _apiService;

        private bool _isLoading;

        private string _search;
        private List<Country> _myCountries;
        private DelegateCommand _searchCommand;

        private ObservableCollection<CountryItemViewModel> _countries;

        public CountriesPageViewModel(INavigationService navigationService, IApiService apiService) : base(navigationService)
        {
            _navigationService = navigationService;
            _apiService = apiService;
            Title = "Country";
            LoadCountriesAsync();

        }

        public DelegateCommand SearchCommand => _searchCommand ?? (_searchCommand = new DelegateCommand(ShowCountries));


        public string Search
        {
            get => _search;
            set
            {
                SetProperty(ref _search, value);
                ShowCountries();
            }
        }

        public bool IsLoading
        {
            get => _isLoading;
            set => SetProperty(ref _isLoading, value);
        }

        public ObservableCollection<CountryItemViewModel> Countries
        {
            get => _countries;
            set => SetProperty(ref _countries, value);
        }

        private async void LoadCountriesAsync()
        {
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await App.Current.MainPage.DisplayAlert("Error", "Connection Error", "Accept");
                return;
            }

            IsLoading = true;

            string url = App.Current.Resources["UrlAPI"].ToString();
            Response response = await _apiService.GetListAsync<Country>(url, "/rest", "/v2");

           
            if (!response.IsSuccess)
            {
                await App.Current.MainPage.DisplayAlert("Error", response.Message, "Accept");
                return;
            }

            IsLoading = false;
            _myCountries = (List<Country>)response.Result;
            ShowCountries();

        }

        private void ShowCountries()
        {
            if (string.IsNullOrEmpty(Search))
            {
                Countries = new ObservableCollection<CountryItemViewModel>(_myCountries.Select(country =>
                new CountryItemViewModel(_navigationService)
                {
                    Flag = country.Flag,
                    Name = !string.IsNullOrEmpty(country.Name) ? country.Name : "Not Available",
                    NativeName = !string.IsNullOrEmpty(country.NativeName) ? country.NativeName : "Not Available",
                    Capital = !string.IsNullOrEmpty(country.Capital) ? country.Capital : "Not Available",
                    Region = !string.IsNullOrEmpty(country.Region) ? country.Region : "Not Available",
                    Subregion = !string.IsNullOrEmpty(country.Subregion) ? country.Subregion : "Not Available",
                    Gini = country.Gini,
                    Area = country.Area,
                    Population = country.Population,
                    Languages = country.Languages,
                    Currencies = country.Currencies,
                    Alpha2Code= country.Alpha2Code,
                    borders = country.borders,
                })
                    .ToList());
            }
            else
            {
                Countries = new ObservableCollection<CountryItemViewModel>(_myCountries.Select(country =>
                 new CountryItemViewModel(_navigationService)
                 {
                     Flag = country.Flag,
                     Name = !string.IsNullOrEmpty(country.Name) ? country.Name : "Not Available",
                     NativeName = !string.IsNullOrEmpty(country.NativeName) ? country.NativeName : "Not Available",
                     Capital = !string.IsNullOrEmpty(country.Capital) ? country.Capital : "Not Available",
                     Region = !string.IsNullOrEmpty(country.Region) ? country.Region : "Not Available",
                     Subregion = !string.IsNullOrEmpty(country.Subregion) ? country.Subregion : "Not Available",
                     Gini = country.Gini,
                     Area = country.Area,
                     Population = country.Population,
                     Languages =country.Languages,
                     Currencies = country.Currencies,
                     Alpha2Code = country.Alpha2Code,
                     borders = country.borders,

                 })
                    .Where(c => c.Name.ToLower().Contains(Search.ToLower()))
                    .ToList());
            }
        }
    }
}
