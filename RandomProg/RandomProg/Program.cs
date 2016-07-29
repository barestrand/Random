using RandomProg.UI_forms;
using System;
using System.Collections.Generic;
using System.IO;
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
            form.FormClosing += form_Closing;


            Application.Run(form);


        }

            private static void form_Closing(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    
    }
}
