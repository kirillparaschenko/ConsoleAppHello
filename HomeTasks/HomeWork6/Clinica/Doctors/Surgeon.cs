using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork6.Clinica.Doctors
{
    internal class Surgeon : Doctor
    {
        public Surgeon(string doctorName) : base(doctorName) { }

        public override string Cure()
        {
            Console.WriteLine("SurgeonRecipe");
            return "SurgeonRecipe";
        }
    }
}
