using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using projectNeptun.Views;
using projectNeptun.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectNeptun.Views
{
    public partial class MyRecipesPage : ContentPage
    {
        public MyRecipesPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            collectionView.ItemsSource = await App.RecipesDB.GetRecipeAsync();

            base.OnAppearing();
        }

        //public async void AddNewRecipe_Click(object sender, EventArgs e)
        //{
        //    await Shell.Current.GoToAsync(nameof(NewRecipePage));
        //}
        public async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                Recipe recipe = (Recipe)e.CurrentSelection.FirstOrDefault();
                //await Shell.Current.GoToAsync(
                //    $"{nameof(NewRecipePage)}?{nameof(NewRecipePage.ItemId)}={recipe.Id.ToString()}");
            }
        }
    }
}