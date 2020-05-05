using System;

namespace _5._5._2020car
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.1
            Car car1 = new Car();
            car1.Velocity = 50;
            //2.2
            Console.WriteLine(car1.Velocity);
            //2.3
            Console.WriteLine("How much faster do you want to go?");
            int acc=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < acc; i++)
            {
                car1.Accelerate();
            }
            //2.4
            Console.WriteLine(car1.Velocity);
            //2.5
            car1.Decelerate();
            car1.Decelerate();
            //2.6
            Console.WriteLine(car1.Velocity);
            //2.7
            for (int i = car1.Velocity; i > 0; i--)
            {
                car1.Decelerate();
            }
            Console.WriteLine(car1.Velocity);
        }
    }
    class Car
    {
        //1
        private int velocity;

        public int Velocity
        {
            get { return velocity; }
            set { velocity = value; }
        }

        public void Accelerate()
        {
            velocity++;
        }
        public void Decelerate()
        {
            velocity--;
        }


    }
}
