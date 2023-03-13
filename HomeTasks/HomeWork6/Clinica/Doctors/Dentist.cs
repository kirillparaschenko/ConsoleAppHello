using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork6.Clinica.Doctors
{
    internal class Dentist : Doctor
    {
        public Dentist(string doctorName) : base(doctorName) { }

        public override string Cure()
        {
            Console.WriteLine("Dentist Recipe");
            return "DentistRecipe";
        }

    }
}
