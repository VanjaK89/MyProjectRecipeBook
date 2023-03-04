using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectRecipeBook.Models
{
    internal class IngridientsDBContext:DbContext
    {
        public DbSet<Ingridients> IngridientsList { get; set; } 
        
        
    }

}
