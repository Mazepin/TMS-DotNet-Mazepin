using System;
using System.Collections.Generic;
using System.Text;

namespace Mazepin.Homework4.Models
{
    public class Bear : AnimalsClass<int>
    {
        static void AnimalVoice()
        {
            Console.WriteLine("Hrrrrrrr");
        }
        static void AnimalHeight()
        {
            Console.WriteLine("150 Kg");
        }
        
    }
}
