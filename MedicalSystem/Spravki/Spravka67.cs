using MedicalSystem.Interfaces;
using MedicalSystem.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalSystem.Spravki
{
    internal class Spravka67 : ISpravka
    {
        public string GetShortInfo()
        {
            return $"{SpravkaName}: {CalculatePrice()}";
        }

        public int ValidMonths { get; set; }

        public Spravka67(int validMonths)
        {
            ValidMonths = validMonths;
        }
        public string SpravkaName { get; set; }
        public Patient Patient { get; set; }
        public decimal Price { get; set; }

        public decimal CalculatePrice()
        {
            return Price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Patient: {Patient.Name} {Patient.Surname}");
            Console.WriteLine($"Справка: {SpravkaName}");
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine($"Действует: {ValidMonths} мес.");
            Console.WriteLine($"Группа крови: {Patient.BloodType}");
        }
    }
}
