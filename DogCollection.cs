using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class DogCollection
    {
        List<Dog> dogs;
        public DogCollection()
        {
            dogs = new List<Dog>();
        }
        public void AddDog(Dog dog)
        {
            dogs.Add(dog);
        }

        public void ShowBySex(string sex)
        {
            foreach(var dog in dogs)
            {
                if(dog.Sex == sex)
                {
                    Console.WriteLine(dog.ToString());
                }
            }
        }
        public void ShowAllDogs()
        {
            foreach (var dog in dogs)
            {
                Console.WriteLine(dog.ToString());
            }
        }
        public void SortByID()
        {
            dogs.Sort();
        }
    }
}
