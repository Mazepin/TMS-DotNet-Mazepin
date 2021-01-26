using System;
using System.Collections.Generic;
using System.Text;

namespace Mazepin.Homework4.Models
{
    public class Dog : AnimalsClass<int>
    {
        public void Eat()
        {
            Console.WriteLine("What does the dog eat?");
        }
    }
}
