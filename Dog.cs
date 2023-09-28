using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab_4
{
    internal class Dog : IComparable<Dog>
    {
        int id;
        string breed;
        string sex;
        double price;
        int age;
        public Dog(int id, string breed, string sex, double price, int age)
        {
            ID = id;
            Breed = breed;
            Sex = sex;
            Age = age;
            if(sex == "female" && age == 2)
                Price = price + (price * 0.25);
            else 
                Price = price;


        }
        public int ID
        {
            get
            { 
                return id; 
            }
            set 
            {
                if (value <= 0)
                    value = 1;
                else 
                    id = value;
            }
        }

        public string Breed
        {
            get { return breed; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Breed cannot be empty or whitespace.");
                }
                breed = value;
            }
        }
        public string Sex
        {
            get { return sex; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Sex cannot be empty or whitespace.");
                }
                sex = value;
            }
        }
        public double Price {
            get
            {
                return price;
            } 
            set
            {
                if (value <= 0)
                    price = 1000;
                else
                    price = value;
            } 
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                    age = 0;
                else
                    age = value;
            }
        }
        public int CompareTo(Dog other)
        {
            if (this.ID < other.ID)
                return -1;
            else if (this.ID > other.ID)
                return 1;
            else
                return 0;
        }
        public override string ToString()
        {
            return $"ID: {ID} \t Breed: {Breed} \t Sex: {Sex} \t Age: {Age} \t Price: {Price}";
        }
    }
}
