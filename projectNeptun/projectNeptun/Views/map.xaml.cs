using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectNeptun.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class map : ContentPage
    {
        public map()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            mapp.Clicked += Mapp_Clicked;
        }

        async void Mapp_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync(new Uri("https://www.google.com/maps/search/%D0%B4%D1%83%D0%B1%D0%BA%D0%B8+%D0%BF%D1%80%D0%BE%D0%B4%D1%83%D0%BA%D1%82%D1%8B/@50.6159747,36.7428508,10z"));
        }
    }
}