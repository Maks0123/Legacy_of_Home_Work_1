using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
     class Student : People
    {
        #region Fields
        private int Course;
        private string Specialization;
        #endregion

        #region Constructor
        public Student(string firstname, string lastname, int age, int course, string specialization) : base (age, firstname, lastname)
        {
            Console.WriteLine(firstname + " " + lastname + " " + age + " " + course + " " + specialization);
            this.Course = course;
            this.Specialization = specialization;
        }
        #endregion 

        #region GetSet
        public int SetCourse
        {
            get { return Course; }
            set { Course = value ; }   
        }

        public string GetSpecialization
        {
            get { return Specialization; }
            set { Specialization = value; }
        }

        #endregion
    }
}
