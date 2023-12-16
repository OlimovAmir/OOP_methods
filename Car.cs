using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_methods
{
    public class Car
    {
        private int speed = 0;

        public void PrintSreed() 
        {
            if (speed == 0)
            {
                Console.WriteLine("Стоим на месте ..");
            }
            if (speed > 0)
            {
                Console.WriteLine($"Едем вперед с скоростью {speed} км\\ч");
            }

            if (speed < 0)
            {
                Console.WriteLine($"Едем назад с скоростью {-speed} км\\ч");
            }

           
        }

        public void DriveFoward()
        {
            speed = 60;
        }

        public void Stop()
        {
            speed = 0;
        }

        public void DriveBackward()
        {
            speed = -5;
        }
    }
}
