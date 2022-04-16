using System;
using System.Collections.Generic;
using System.Text;

namespace _16._04._22
{
    abstract class Vehicle
    {
        public string Color;
        public int Year;

        public abstract void ShowInfo();

        public Vehicle(string color,int year)
        {
            Color = color;
            Year = year;
        }

        


    }




}
