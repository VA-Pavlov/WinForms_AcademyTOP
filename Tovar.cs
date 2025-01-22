using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_AcademyTOP
{
    public class Tovar
    {
        public string Name { get; set; }
        public string Proisvoditel {  get; set; }
        public int ValueInSclad {  get; set; }
        public decimal Price { get; set; }

        public Tovar() { }
        public Tovar(string name, string proisvoditel, int valueInSclad, decimal price)
        {
            Name = name;
            Proisvoditel = proisvoditel;
            ValueInSclad = valueInSclad;
            Price = price;
        }
        
        public override string ToString()
        {
            return $"{Name} Производитель: {Proisvoditel}, Цена: {Price}руб. - {ValueInSclad} шт.";
        }
    }
}
