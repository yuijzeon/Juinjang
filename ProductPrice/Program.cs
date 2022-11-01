using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace ProductPrice
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var context = new JuinjangContext())
            {
                context.Products.Load();
                Application.Run(new Form1(context));
            }
        }
    }
}