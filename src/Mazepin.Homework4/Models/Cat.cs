using System;
using System.Collections.Generic;
using System.Text;

namespace Mazepin.Homework4.Models
{
    public class Cat : AnimalsClass<int>
    {
        public void Say()
        {
            Console.WriteLine("What does the cat say?");
        }
    }
}
