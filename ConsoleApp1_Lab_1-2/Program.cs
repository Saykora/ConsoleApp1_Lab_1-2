namespace ConsoleApp1_Lab_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Створення об'єкта автомобіля
            Car myCar = new Car("Toyota", "Camry", 2020, "Червоний", 15000);

            // Виведення інформації про автомобіль
            myCar.DisplayInfo();

            // Оновлення пробігу
            myCar.UpdateMileage(20000);

            // Виведення оновленої інформації про автомобіль
            myCar.DisplayInfo();
        }
    }
}
