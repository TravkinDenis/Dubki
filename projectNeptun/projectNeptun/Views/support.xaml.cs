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
    public partial class support : ContentPage
    {
        public support()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            vk.Clicked += Vk_Clicked;
            odnoklassniki.Clicked += Odnoklassniki_Clicked;
            poto.Clicked += Poto_Clicked;
        }

        private void Poto_Clicked(object sender, EventArgs e)
        {
            Clipboard.SetTextAsync("info@dubki-produkty.ru");
        }

        async void Odnoklassniki_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync(new Uri("https://vk.com/dubki.produkty"));
        }

        async void Vk_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync(new Uri(" https://ok.ru/dubki.produkty"));
        }

       

    }
}