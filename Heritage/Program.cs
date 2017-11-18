using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Program
    {

        static void Main(string[] args)
        {
           
            People people = new People("David", "Lognov", 24, 'F', "California");
            Console.WriteLine(people);
            Console.WriteLine();

            Student student = new Student("Oleg", "Petrovsky", 18, 1, "Ingener");
            Console.WriteLine(student);
            Console.WriteLine();

            Aspirant aspirant = new Aspirant("Nickolay", "Fomin", 27, "Optic tonight");
            Console.WriteLine(aspirant);
            Console.WriteLine();

            Teacher teacher = new Teacher("Alex", "Swarc", 32, "Doctor House", "|Mathametic");
            Console.WriteLine(teacher);
            Console.WriteLine();

            Professor professor = new Professor("Devid", "Oushen", 45, "Electromagnatics wavуы");
            Console.WriteLine(professor);
            Console.WriteLine();

            Console.ReadKey();          
        }
    }
}
