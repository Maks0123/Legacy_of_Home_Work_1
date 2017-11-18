using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Heritage
{
    class People
    {
        #region Field   
        public int Age;
        public string FirstName;
        public string LastName;
        private char Mail;
        private string Town;
        #endregion

        #region  Arrays
        List<int> Lid;
        List<int> LAge;
        List<string> LName;
        List<string> LMail;
        List<string> LTown;
        #endregion

        #region Constructors

     

        public People(string firstname, string lastname, int age, char mail, string town)
        {
            Console.WriteLine(firstname+ " " + lastname + " " + age + " " + mail + " " + town);
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            this.Mail = mail;
            this.Town = town;
           
        }

        public People(int age, string firstname, string lastname)
        {

            Age = age;
            FirstName = firstname;
            LastName = lastname;

        }
        #endregion

        #region Get Peoplse
        public int GetAge
        {
            get { return Age; }
            set { Age = value; }

        }

        public char GetMail
        {
            get { return Mail; }
            set { Mail = value; }
        }

        public string GetTown
        {
            get { return Town; }
            set { Town = value; }
        }

        public string GetFirstName
        {
            get { return FirstName; }
            set {  FirstName = value; }
        }

        public string GetLastName
        {
            get { return LastName; }
            set { LastName = value; }
        }
        #endregion
 
    }
}
