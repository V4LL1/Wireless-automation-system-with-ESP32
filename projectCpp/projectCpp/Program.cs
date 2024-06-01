using System;
using System.IO.Ports;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projectCpp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
