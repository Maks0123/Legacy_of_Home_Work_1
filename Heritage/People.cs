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
        private int id;
        private int Age;
        private string FirstName;
        private string LastName;
        private string Mail;
        private string Town;
        #endregion

        #region  Arrays
        List<int> Lid;
        List<int> LAge;
        List<string> LName;
        List<string> LMail;
        List<string> LTown;
        #endregion

        #region Constructor
        public People()
        {
             this.id = 1;
             this.Age = 18;
             this.FirstName = "Danil";
             this.LastName = "Hobich";
             this.Mail = "M";
             this.Town = "Kiev";
        }
        #endregion

        #region Get Peoplse
        public int GetAge
        {
            get { return Age; }
            set { Age = value; }

        }

        public string GetMail
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

        public int Getid
        {
            get { return id; }
            set { id = value; }
        }

        #endregion

        void AddArray()
        {
            Age = 18; FirstName = "Nick"; Mail = "M"; Town = "Kiev"; id = 1;
            Lid.Add(id); LAge.Add(Age); LName.Add(FirstName); LMail.Add(Mail); LTown.Add(Town);

            Age = 18; FirstName = "Poli"; Mail = "F"; Town = "Kiev"; id = 1;
            Lid.Add(id); LAge.Add(Age); LName.Add(FirstName); LMail.Add(Mail); LTown.Add(Town);

            Age = 18; FirstName = "Nick"; Mail = "F"; Town = "Kiev"; id = 1;
            Lid.Add(id); LAge.Add(Age); LName.Add(FirstName); LMail.Add(Mail); LTown.Add(Town);

            Age = 18; FirstName = "Nick"; Mail = "F"; Town = "Kiev"; id = 1;
            Lid.Add(id); LAge.Add(Age); LName.Add(FirstName); LMail.Add(Mail); LTown.Add(Town);

            Age = 18; FirstName = "Nick"; Mail = "F"; Town = "Kiev"; id = 1;
            Lid.Add(id); LAge.Add(Age); LName.Add(FirstName); LMail.Add(Mail); LTown.Add(Town);
        }


        public void Print()
        {
            Console.WriteLine("                                                                                   ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                       ***          CLASS PEOPLE        ***                        ");
            Console.WriteLine("   ______________________________________________________________________________  ");
            Console.WriteLine("  |  id    |    Age    |    FirstName    |    LastName    |    Mail    |   Town  | ");
            Console.WriteLine("   ------------------------------------------------------------------------------  ");
            Console.WriteLine("  |   " + id + "    |    " + Age + "     |     " + FirstName + "       |     " + LastName + "     |     " + Mail + "      |   " + Town + "  | ");
            Console.WriteLine("   ------------------------------------------------------------------------------  ");
            Console.WriteLine("                                                                                   ");
        }
    }
}
