using System;

namespace _16._04._22
{
    internal class Program
    {





        static void Main(string[] args)
        {
            Car car = new Car("White", 2000, "BMW", "90",200);
            Car car1 = new Car("Black", 3000, "Mercedes", "90",100);
            Bus bus = new Bus("White", 2000,20);
            Bus bus1 = new Bus("Black", 2001,10);
            #region Task1
            //Program program = new Program();

            //Console.WriteLine(program.sum(2, 4));
            //Console.WriteLine("\n-------\n");
            //Console.WriteLine(program.Minus(10, 2, 2));
            //Console.WriteLine("\n-------\n");
            //Console.WriteLine(program.Multiply(3, 5, 9, 8));
            //Console.WriteLine("\n-------\n");
            //Console.WriteLine(program.Divice(1441, 4, 5,9,8));
            #endregion
            Vehicle[] vehicles = { car, car1, bus, bus1 };
            foreach (var item in vehicles)
            {
                item.ShowInfo();
            }

            
        }
        #region Task1

        //public int sum(int num1, int num2)
        //{

        //    int sum = num1 + num2;
        //    return sum;


        //}
        //public int sum(int num1, int num2, int num3)
        //{
        //    int sum = num1 + num2 + num3;
        //    return sum;
        //}
        //public int sum(int num1, int num2, int num3, int num4)
        //{
        //    int sum = num1 + num2 + num3 + num4;
        //    return sum;
        //}
        //public int sum(int num1, int num2, int num3, int num4, int num5)
        //{
        //    int sum = num1 + num2 + num3 + num4 + num5;
        //    return sum;
        //}
        //public int Minus(int num1, int num2)
        //{
        //    int Minus = num1 - num2;
        //    return Minus;
        //}
        //public int Minus(int num1, int num2, int num3)
        //{
        //    int Minus = num1 - num2 - num3;
        //    return Minus;
        //}
        //public int Minus(int num1, int num2, int num3, int num4)
        //{
        //    int Minus = num1 - num2 - num3 - num4;
        //    return Minus;
        //}
        //public int Minus(int num1, int num2, int num3, int num4, int num5)
        //{
        //    int Minus = num1 - num2 - num3 - num4 - num5;
        //    return Minus;
        //}
        //public int Multiply(int num1, int num2)
        //{
        //    int Multiply = num1 * num2;
        //    return Multiply;
        //}
        //public int Multiply(int num1, int num2, int num3)
        //{
        //    int Multiply = num1 * num2 * num3;
        //    return Multiply;
        //}
        //public int Multiply(int num1, int num2, int num3, int num4)
        //{
        //    int Multiply = num1 * num2 * num3 * num4;
        //    return Multiply;
        //}
        //public int Multiply(int num1, int num2, int num3, int num4, int num5)
        //{
        //    int Multiply = num1 * num2 * num3 * num4 * num5;
        //    return Multiply;
        //}
        //public double Divice(double num1, double num2)
        //{
        //    double Divice = num1 / num2;
        //    return Divice;
        //}
        //public double Divice(double num1, double num2, double num3)
        //{
        //    double Divice = num1 / num2 / num3;
        //    return Divice;
        //}
        //public double Divice(double num1, double num2, double num3, double num4)
        //{
        //    double Divice = num1 / num2 / num3 / num4;
        //    return Divice;
        //}
        //public double Divice(double num1, double num2, double num3, double num4, double num5)
        //{
        //    double Divice = num1 / num2 / num3 / num4 / num5;
        //    return Divice;
        //}
        #endregion

    }
}


