using ConsoleAppHello.HomeTasks.HomeWork6.Clinica.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork6.Clinica
{
    internal class TreatmentPlan
    {
        int planNumber;
        public TreatmentPlan(Patient patient, int planNumber) 
        { 
            this.planNumber = planNumber;
        }

        public void AsignDoctor() 
        {
            if (planNumber == 1) 
            {
                Doctor doctor = new Surgeon("Surgeon");
                Console.WriteLine($"Asigned Surgeon");
                doctor.Cure();
            }
            else if (planNumber == 2)
            {
                Doctor doctor = new Dentist("Dentist");
                Console.WriteLine($"Asigned Dentist");
                doctor.Cure();
            }
            else 
            {
                Doctor doctor = new Therapist("Therapist");
                Console.WriteLine("Asigned Therapist");
                doctor.Cure();
            }
        }
    }
}
