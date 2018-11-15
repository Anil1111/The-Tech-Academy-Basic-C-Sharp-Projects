using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesPgm2
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.ReadLine();
        }

        public void Quit()
        {
            Console.WriteLine("Take this job and shove it ;-)");
            Console.ReadLine();
        }
    }
}
