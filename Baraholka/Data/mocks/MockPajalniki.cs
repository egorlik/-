using Baraholka.Data.interfaces;
using Baraholka.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Baraholka.Data.mocks
{
    public class MockPajalniki : IAllPajalniki
    {
        private readonly IpajalnikiCategory _categoryPajalniki = new MockCategory();
        public IEnumerable<Pajalki> Pajalniki
        {
            get {
                return new List<Pajalki> {
                    new Pajalki { name = "TS100", shortDesc = "Мощность 6 Ватт\nРазогрев до плавления припоя за 3 секунды", LongDesc = "Мощность до 65Вт", img = "http://easyelectronics.ru/img/Instrument/TS100/TS100-inhand.JPG", price = 50, IsFavourite = true, available = true, Category = _categoryPajalniki.AllCategories.First()}
                };
            }
        }
        public IEnumerable<Pajalki> getFavPajalki { get; set; }
        IEnumerable<Pajalki> IAllPajalniki.Pajalniki { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Pajalki getObjectPajalki(int pajalkiID)
        {
            throw new NotImplementedException();
        }
    }
}
