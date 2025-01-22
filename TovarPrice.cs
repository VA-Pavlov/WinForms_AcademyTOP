using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_AcademyTOP
{
    public class TovarPrice
    {
        public Tovar Tovar { get; set; }
        public int Count { get; set; }

        public TovarPrice(Tovar tovar, int count)
        {
            Tovar = tovar;
            Count = count;
        }
        public override string ToString()
        {
            return $"{Tovar.Name} * {Count} - {Count*Tovar.Price}";
        }
    }
}
