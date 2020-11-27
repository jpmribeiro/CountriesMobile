using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Countries.Prism.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CountryDetails : ContentPage
    {
        public CountryDetails()
        {
            InitializeComponent();
        }
    }
}