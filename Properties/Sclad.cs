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
            new Tovar("Супер контик","Конти-Рус",200,35),
            new Tovar("Мишка на севере","Крубская",500,15),
            new Tovar("Трюфели","Крубская",300,15),
        };

        public static List<Tovar> GetTovars()
        {
            return tovars;
        }
        public static void changeTovars(List<Tovar> array)
        {
            tovars = array;
        }
    }
}
