using SQLite;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace projectNeptun.Models
{
    public class Recipe
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string RecipeName { get; set; }

        public string Description { get; set; }

        public string Ingredients { get; set; }

        public string MainInfo { get; set; }

        public DateTime Date { get; set; }
    }
}
