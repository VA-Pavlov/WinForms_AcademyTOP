using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_AcademyTOP.Properties
{
    public static class Sclad
    {
        private static List<Tovar> tovars = new List<Tovar>()
        {
            new Tovar("Супер контик","Конти",200,35)
        };

        public static List<Tovar> GetTovars()
        {
            return tovars;
        }
    }
}
