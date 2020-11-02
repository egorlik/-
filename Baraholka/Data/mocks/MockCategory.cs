using Baraholka.Data.interfaces;
using Baraholka.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Baraholka.Data.mocks
{
    public class MockCategory : IpajalnikiCategory
    {
        public IEnumerable<Category> AllCategories => new List<Category>//Тут добавлять категории
        {
            new Category { categoryName = "Электрические паяльники", desc = "Сетевое оборудование"},
            new Category { categoryName = "Газовые паяльники", desc = "Независимое оборудование" }
            //new Category { categoryName = "...", desc = "..." } Для добавления новой категории
            //new Category { categoryName = "...", desc = "..." } Для добавления новой категории
        };
    }
}
