using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Stok_Takibi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Trace.OutputEncoding = System.Text.Encoding.UTF8;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                //Login login = new Login();
                //login.Show();
                Employee mainPage = new Employee();
                mainPage.Show();
                //OnTrustSaleDetails veresiyeMüşterileri = new VeresiyeMüşterileri();
                //veresiyeMüşterileri.Show();
                Application.Run();
            } catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
