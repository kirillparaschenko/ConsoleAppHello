using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHello.HomeTasks.HomeWork6.Clinica.Doctors
{
    internal class Doctor
    {
        public string doctorName;

        public Doctor(string doctorName)
        {
            this.doctorName = doctorName;
        }

        public virtual string Cure()
        {
            return string .Empty;
        }
    }
}
