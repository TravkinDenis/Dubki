using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using projectNeptun.Data;
using System.IO;

namespace projectNeptun
{
    public partial class App : Application
    {
        static RecipesDB recipesDB;

        public static RecipesDB RecipesDB
        {
            get
            {
                if (recipesDB == null)
                {
                    recipesDB = new RecipesDB(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RecipesDatabase.db3"));
                }
                return recipesDB;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new menu();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
