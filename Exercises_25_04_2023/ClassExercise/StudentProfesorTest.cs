using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    internal class StudentProfesorTest
    {
        internal void Main() {
            Person person = new Person();
            person.Greet();

            Student student = new Student();
            student.SetAge(21);
            student.ShowAge();
            student.Greet();

            Profesor profesor = new Profesor();
            profesor.SetAge(53);
            profesor.Greet();
            profesor.Explain();
        }    
    }
}
