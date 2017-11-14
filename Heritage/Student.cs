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

        public Student()
        {
              Course = 3;
              Specialization = "Manager";
              
        }

        public void Print()
        {
            GetLastName = "Voir";
        }
    }
}
