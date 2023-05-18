using projectNeptun.Models;
using projectNeptun.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectNeptun.Views
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public partial class NewRecipePage : ContentPage
    {
        public string ItemId
        {
            set
            {
                LoadRecipe(value);
            }
        }

        private async void LoadRecipe(string value)
        {
            try 
            {
                int id = Convert.ToInt32(value);

                Recipe recipe = await App.RecipesDB.GetRecipeAsync(id);
                BindingContext = recipe;
            }
            catch
            {

            }
        }

        public NewRecipePage()
        {
            InitializeComponent();

            BindingContext = new Recipe();
        }
        private async void ButtonSave_Click(object sender, EventArgs e)
        {
            Recipe recipe = (Recipe)BindingContext;
            recipe.Date = DateTime.UtcNow;

            if (!string.IsNullOrWhiteSpace(recipe.RecipeName))
            {
                await App.RecipesDB.SaveNoteAsync(recipe);
            }
            if (!string.IsNullOrWhiteSpace(recipe.Description))
            {
                await App.RecipesDB.SaveNoteAsync(recipe);
            }
            if (!string.IsNullOrWhiteSpace(recipe.Ingredients))
            {
                await App.RecipesDB.SaveNoteAsync(recipe);
            }
            if (!string.IsNullOrWhiteSpace(recipe.MainInfo))
            {
                await App.RecipesDB.SaveNoteAsync(recipe);
            }

            await Shell.Current.GoToAsync("..");
        }
        private async void ButtonDelete_Click(object sender, EventArgs e)
        {
            Recipe recipe = (Recipe)BindingContext;

            await App.RecipesDB.DeleteRecipeAsync(recipe);
            await Shell.Current.GoToAsync("..");
        }
    }
}