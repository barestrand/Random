using RandomProg.UI_forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomProg
{
    class Program
    {
        public static string getPath(string file)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, file);
        }

        [STAThread]
        static void Main(string[] args)
        {
            Form form = new Form1();

            Console.WriteLine("test5");
            Console.WriteLine("xxxXXXXXXXXXXXXXXXXXDEEERP");
            Console.ReadKey();

            dankFunk dff = new dankFunk();
            dff.repeat();

            Console.ReadKey();


        }
    }
}
