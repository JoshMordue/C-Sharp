using System;


namespace ClassesIntro2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Car myCar = new Car("Josh");
            Car anotherCar = new Car("Tim");

            myCar.Accelerate(1);
            myCar.Accelerate(32);
            myCar.Accelerate(1);
            myCar.Accelerate(2);
            myCar.Decelerate(3);
            myCar.Accelerate(5);
            anotherCar.Accelerate(50);
            anotherCar.Decelerate(60);
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

        public void Accelerate(int amount)
        {
            speed += amount;
            ShowSpeed();
        }

        public void Decelerate(int amount)
        {
            if (amount > speed)
            {
                speed = 0;
            }
            else
            {
                speed -= amount;
            }
            ShowSpeed();
        }

        private void ShowSpeed()
        {
            Console.WriteLine($"{name} is going {speed} kilometres per hour");
        }

    }


}



