using Baraholka.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Baraholka.Data.interfaces
{
    public interface IpajalnikiCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
