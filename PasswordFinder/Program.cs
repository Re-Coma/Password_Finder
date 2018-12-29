using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordFinder
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm loginform = new LoginForm();
            Application.Run(loginform);
            bool myPass = loginform.pass;

            if(myPass)
            {
                MainForm mForm = new MainForm(loginform.start);
                loginform.Dispose();
                Application.Run(mForm);
            }
        }
    }
}
