using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Baraholka.Data.Models
{
    public class Pajalki
    {
        public int id { set; get; } //Айди товара
        public string name { set; get; } // Имя товара
        public string shortDesc { set; get; } //Короткое описание товара
        public string LongDesc { set; get; } //Длинное описание товара
        public string img { set; get; }//Сысылки на картинки
        public ushort price { set; get; }//Цена товара
        public bool IsFavourite { set; get; }//Будет ли высвечиватся на главное странице
        public bool available { set; get; }//Доступен ли товар к продаже
        public int categoryID { set; get; }//Категория
        public virtual Category Category { set; get; }
    }
}
