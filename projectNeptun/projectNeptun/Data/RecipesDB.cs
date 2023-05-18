using projectNeptun.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace projectNeptun.Data
{
    public class RecipesDB
    {
        readonly SQLiteAsyncConnection db;

        public RecipesDB(string connectionString)
        {
            db = new SQLiteAsyncConnection(connectionString);

            db.CreateTableAsync<Recipe>().Wait();
        }

        public Task<List<Recipe>> GetRecipeAsync()
        {
            return db.Table<Recipe>().ToListAsync();
        }

        public Task<Recipe> GetRecipeAsync(int id)
        {
            return db.Table<Recipe>()
                                    .Where(i => i.Id == id)
                                    .FirstOrDefaultAsync();
        }

        public Task<int> SaveNoteAsync(Recipe recipe)
        {
            if (recipe.Id != 0)
            {
                return db.UpdateAsync(recipe);
            }
            else
            {
                return db.InsertAsync(recipe);
            }
        }

        public Task<int> DeleteRecipeAsync(Recipe recipe)
        {
            return db.DeleteAsync(recipe);
        }
    }
}
