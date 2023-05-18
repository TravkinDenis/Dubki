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
    public partial class company : ContentPage
    {
        public company()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            hh.Clicked += Hh_Clicked;
        }

        async void Hh_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync(new Uri("https://hh.ru/employer/5582812"));
        }
    }
}