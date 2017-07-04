using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CabRental.Web.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
