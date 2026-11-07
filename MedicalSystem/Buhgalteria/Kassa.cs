using System;
using System.Collections.Generic;
using System.Text;
using MedicalSystem.Interfaces;

namespace MedicalSystem.Buhgalteria
{
    internal class Kassa
    {
        public void PrintCheck(List<ISpravka> spravki)
        {
            foreach (ISpravka spravka in spravki)
            {
                Console.WriteLine(spravka.GetShortInfo());
            }

            Console.WriteLine($"Итого: {Total(spravki)}");
        }

        public decimal Total(List<ISpravka> spravkas)
        {
            decimal total = 0;
            foreach (var spravka in spravkas)
            {
                total += spravka.CalculatePrice();
            }
            return total;
        }
    }
}
