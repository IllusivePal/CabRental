using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CabRental.Web.Models
{
    public class MockCategoryRepository:ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryId=1,CategoryName="FruitPies",Description="All-Fruit-Pies"},
                    new Category{CategoryId=2,CategoryName="Cheese cakes",Description="Cheese all the way"},
                    new Category{CategoryId=3,CategoryName="Seasonal Pies",Description="All season pies"},
                    new Category{CategoryId=4,CategoryName="Juicy Fruit",Description="All Juicy Pies"},
                };
            }
        }
    }
}
