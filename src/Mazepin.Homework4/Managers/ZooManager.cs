using System;
using System.Collections.Generic;
using System.Text;
using Mazepin.Homework4.Interfaces;
using Mazepin.Homework4.Models;


namespace Mazepin.Homework4.Managers
{

    public class ZooManager : IZooManager, ICanInteract
    {
        public List<AnimalsClass<int>> Animals { get; set; } = new List<AnimalsClass<int>>();

        public void Show()
        {
            foreach (var animal in Animals)
            {
                Console.WriteLine($"Animal: {animal.Name}, {animal.Age}");
            }
        }

        public void YouCanInteractWithIt()
        {
            Animals.Add(new Cat
            {
                Name = "Murzik",
                Age = 1,
            });

            Show();

            Console.WriteLine("OK!");
        }
    }
}

