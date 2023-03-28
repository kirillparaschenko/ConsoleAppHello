using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork6.Clinica.Doctors
{
    internal class Therapist : Doctor
    {
        public Therapist(string doctorName) : base(doctorName) { }

        public override string Cure()
        {
            Console.WriteLine("Therapist Recipe");
            return "TherapistRecipe";
        }
    }
}
