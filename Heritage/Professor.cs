using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Professor : People
    {
        #region field
        private string ScientificDirection1;
        #endregion

        #region Constructor
        public Professor(string firstname, string lastname, int age, string scientificDirection) : base(age, firstname, lastname)
        {
            Console.WriteLine(firstname + " " + lastname + " " + age + " " + scientificDirection);
            this.ScientificDirection1 = scientificDirection;
        }
        #endregion 

    }
}
