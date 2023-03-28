using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork9.Machines
{
    public class Machine<T> where T : MotorType

    {
        public T Motor { get; set; }

        public Machine(T motor) 
        {
            this.Motor = motor;
        }

        public void Move() 
        {
            Console.WriteLine("Machine rides");
        }

        public void Refuel()
        {
            if (Motor?.GetType() == typeof(DieselMotor))
            {
                Console.WriteLine("Diesel");
            }
            else if (Motor?.GetType() == typeof(GasMotor))
            {
                Console.WriteLine("Gas");
            }
            else if (Motor?.GetType() == typeof(ElectroMotor)) 
            {
                Console.WriteLine("Electricity");
            }
        }
    }
}
