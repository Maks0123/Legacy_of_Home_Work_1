using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Program
    {

        #region Output Hello World
        private string str = "Hello world!!!";

        #region void constructor
        Program(){}
        #endregion

        #region 
        Program(string str)
        {
            str = this.str;
        }
        #endregion

        #region 
        public void Hello ()
         {
            Console.WriteLine("Hello world!!!");
         }
        #endregion

        #endregion

        static void Main(string[] args)
        {
            #region Output Hello World
            Program str = new Program();
            str.Hello();
            Console.ReadKey();
            #endregion



        }
    }
}
