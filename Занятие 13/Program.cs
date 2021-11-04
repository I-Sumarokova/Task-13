using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Тверская улица", 40, 30, 20);
            //building.Print();
            MultiBuilding multiBuilding = new MultiBuilding("Тверская улица", 40, 30, 20, 3);
            multiBuilding.Print();
            Console.ReadKey();
        }
    }

    class Building
    {
        public string Address { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Building(string address, double lenght, double width, double height)
        {
            Address = address;
            Length = lenght;
            Width = width;
            Height = height;
        }

        public void Print()
        {
            Console.WriteLine("Здание расположено по адресу {0}. Длина здания - {1} м., ширина - {2} м., высота - {3} м.", Address, Length, Width, Height);
        }
    }

    sealed class MultiBuilding : Building
    {
        public int Floor { get; set; }

        public MultiBuilding(string address, double lenght, double width, double height, int floor)
               : base(address, lenght, width, height)
        {
            Floor = floor;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("Количество этажей - {0}", Floor);
        }
    }
}
