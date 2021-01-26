using System;
using System.Collections.Generic;
using System.Text;
using Mazepin.Homework4.Models;


namespace Mazepin.Homework4.Interfaces
{
    public interface IZooManager
    {
        List<AnimalsClass<int>> Animals { get; set; }
        
        void Show();
    }
}
