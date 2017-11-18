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
        Student(int course, string specialization, int age, string firstname, string lastname) : base (age, firstname, lastname)
        {
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
