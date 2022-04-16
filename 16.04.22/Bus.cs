using System;
using System.Collections.Generic;
using System.Text;

namespace _16._04._22
{
    class Bus : Vehicle
    {
       
        private int _passengerCount;

        public Bus(string color, int year,int passengercount) : base(color, year)
        {
            PassengerCount = passengercount;
            
        }

        public int PassengerCount
        {
            get
            {
                return _passengerCount;
            }
            set
            {
                if (value > 0 && value <= 100)
                {
                    _passengerCount = value;

                }
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"color:{Color},Year:{Year},PassengerCount:{PassengerCount}");
        }
        
    }
}
