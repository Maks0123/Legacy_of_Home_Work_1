using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Teacher : People
    {

        #region 
        private string SchoolName;
        private string Subject;
        #endregion

        #region Constructor
        public Teacher(string firstname, string lastname, int age, string schoolname, string subject ) : base (age, firstname, lastname)
        {
            Console.WriteLine(firstname + " " + lastname + " " + age + " " + schoolname + " " + subject);
            this.SchoolName = schoolname;
            this.Subject = subject;
        }
        #endregion

        #region GET SET
        public string GetScoolName { get { return SchoolName; } set { SchoolName = value; } }
        public string GetSubject { get { return Subject;  } set { Subject = value; } }
        #endregion
    }
}
