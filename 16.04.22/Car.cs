using System;
using System.Collections.Generic;
using System.Text;

namespace _16._04._22
{
    class Car : Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        private int _maxspeed;

        public Car(string color, int year, string brand, string model,int maxspeed) : base(color, year)
        {
            MaxSpeed = maxspeed;
            Model = model;
            Brand = brand;
            
        }

        public int MaxSpeed
        {
            get
            {
                return _maxspeed;
            }
            set
            {
                if (value > 0)
                {
                    _maxspeed = value;
                }

            }


        }

        public override void ShowInfo()
        {
            Console.WriteLine($"color:{Color},year:{Year},brand:{Brand},model:{Model},MaxSpeed:{MaxSpeed}");
        }

    }
}
