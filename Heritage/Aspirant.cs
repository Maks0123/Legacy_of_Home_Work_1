using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Aspirant :People
    {
        #region field
        private string TitleCandidateWork;
        #endregion

        #region Constructor
        public Aspirant(string firstname, string lastname, int age, string titlecandidatework) : base (age, firstname, lastname) 
        {
            Console.WriteLine(firstname + " " + lastname + " " + age + " " + titlecandidatework);
            this.TitleCandidateWork = titlecandidatework;
        }
        #endregion

        #region GET SET
        public string GetTitleCandidateWork
        {
            get { return TitleCandidateWork; }
            set { TitleCandidateWork = value; }
        }
        #endregion
    }
}
