using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Practice__Classes
{
    internal class Program
    {
        //Hongfei
        //Week_2_Practice__Classes
        //01/15/2024
        static void Main(string[] args)
        {
            Car car1= new Car();
            car1.Make = " Hoda";
            car1.Model = "CRV";
            car1.Year = 2024;
            car1.Color = "Black";
            car1.Mileage = 15;

            Bike bike1 = new Bike("Norco", "Moutain", "Brown", 29);
            Movie movie1 = new Movie("Wonka", "adventure", 2023, "PG");

            Console.WriteLine(" A car is "+(car1.Make)+" "+(car1.Model)+ " "+ (car1.Year)+ " " + (car1.Color) + " mileage is " + (car1.Mileage)+".");
            Console.WriteLine(" A bike is "+(bike1.Brand) +" "+(bike1.Mode)+ " "+(bike1.Color)+ " size is "+(bike1.Size)+".");
            Console.WriteLine(" A movie name is " + (movie1.Name) + "; the genre is "+ (movie1.Genre)+"; release year is "+ (movie1.Year) + "; the age restrictions is " + (movie1.Age)+ ".");
            Console.ReadKey();

        }
    }
}
