using System;
using Mazepin.Homework4.Interfaces;
using Mazepin.Homework4.Models;
using Mazepin.Homework4.Managers;


namespace Mazepin.Homework4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var bear = new Bear
            {
                Name = "Bear",
                Age = 15,
            };

            var cat = new Cat
            {
                Name = "Cat",
                Age = 1,
            };

            var dog = new Dog
            {
                Name = "Dog",
                Age = 2,
            };

            IZooManager zooManager = new ZooManager();
            zooManager.Animals.Add(cat);
            zooManager.Animals.Add(dog);
            zooManager.Animals.Add(bear);

            cat.Say();
            dog.Eat();

            zooManager.Show();

            ICanInteract canInteract = new ZooManager();
            canInteract.YouCanInteractWithIt();

            Console.ReadKey();
        }
    }


}

