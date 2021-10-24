using System;

namespace lekcija3._1
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var car = new Car();
            car.PlaySound();

            var item = new Item(10, 20, 30);
            item.ShowInfo();

            var dob = new DateTime(2000, 1, 1);
            var person = new Person("Adam", "Lambert", dob, "Sport", "men");
            person.SayHello();
        }
    }
}
