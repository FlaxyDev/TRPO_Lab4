using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				DogCollection dogs = new DogCollection();
				dogs.AddDog(new Dog(2, "test2", "male", 500, 3));
                dogs.AddDog(new Dog(3, "test3", "female", 500, 2));
                dogs.AddDog(new Dog(1, "test1", "male", 700, 3));
                
                dogs.ShowAllDogs();
                Console.WriteLine();

                dogs.ShowBySex("male");
                Console.WriteLine();

                dogs.SortByID();
                dogs.ShowAllDogs();
            }
			catch (Exception e)
			{

				Console.WriteLine($"You got an error: {e.Message}");
			}
        }
    }
}
