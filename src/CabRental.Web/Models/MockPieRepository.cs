using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CabRental.Web.Models
{
    public class MockPieRepository: IPieRepository
    {
        public IEnumerable<Pie> Pies
        {
            get
            {
                return new List<Pie>
                {
                    new Pie {PieId = 1,Name="Strawberry Pie",Price=15.67M,ShortDescription="strawberry pie",LongDescription="long strawberry pie",AllergyInformation="TEST",ImageUrl="TEST",ImageThumbnailUrl="TestThumbnail",IsPieOfTheWeek=true,InStock=true,CategoryId=1,Category=new Category{ CategoryId=1,CategoryName="FruitPies",Description="All-Fruit-Pies"} },
                    new Pie {PieId = 2,Name="Grapes Pie",Price=15.67M,ShortDescription="Grapes pie",LongDescription="long Grapes pie",AllergyInformation="TEST",ImageUrl="TEST",ImageThumbnailUrl="TestThumbnail",IsPieOfTheWeek=true,InStock=true,CategoryId=2,Category=new Category{ CategoryId=2,CategoryName="Cheese cakes",Description="Cheese all the way" } },
                    new Pie {PieId = 3,Name="Apple Pie",Price=15.67M,ShortDescription="Apple pie",LongDescription="long Apple pie",AllergyInformation="TEST",ImageUrl="TEST",ImageThumbnailUrl="TestThumbnail",IsPieOfTheWeek=true,InStock=true,CategoryId=3,Category = new Category{ CategoryId=3,CategoryName="Seasonal Pies",Description="All season pies"} }
                };

            }
        }

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            throw new System.NotImplementedException();
        }
    }
}
