using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Lab_1_2
{
    internal class Car
        {
    // Властивості автомобіля
    public string Make { get; set; } // Марка
        public string Model { get; set; } // Модель
        public int Year { get; set; } // Рік випуску
        public string Color { get; set; } // Колір
        public double Mileage { get; set; } // Пробіг

        // Конструктор за замовчуванням
        public Car() { }

        // Конструктор з параметрами
        public Car(string make, string model, int year, string color, double mileage)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            Mileage = mileage;
        }

        // Метод для виведення інформації про автомобіль
        public void DisplayInfo()
        {
            Console.WriteLine($"Марка: {Make}, Модель: {Model}, Рік: {Year}, Колір: {Color}, Пробіг: {Mileage} км");
        }

        // Метод для оновлення пробігу
        public void UpdateMileage(double newMileage)
        {
            if (newMileage >= Mileage)
            {
                Mileage = newMileage;
                Console.WriteLine("Пробіг оновлено.");
            }
            else
            {
                Console.WriteLine("Новий пробіг не може бути меншим за поточний.");
            }
        }
     }
}
