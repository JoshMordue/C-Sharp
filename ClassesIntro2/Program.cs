﻿using System;


namespace ClassesIntro2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Car myCar = new Car("Josh");
            Car anotherCar = new Car("Tim");

            myCar.Accelerate();
            myCar.Accelerate();
            myCar.Accelerate();
            myCar.Accelerate();
            myCar.Decelerate();
            myCar.Accelerate();
            anotherCar.Decelerate();
        }

    }

    class Car
    {
        private int speed = 0;
        private string name;

        public Car(string carName)
        {
            name = carName;      
        }

        public void Accelerate()
        {
            speed++;
            showSpeed();
        }

        public void Decelerate()
        {   
            speed--;
            showSpeed();
        }

        private void showSpeed()
        {
            Console.WriteLine($"{name} is going {speed} kilometres per hour");
        }

    }


}


