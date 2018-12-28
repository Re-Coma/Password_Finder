using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PasswordFinder
{
    public partial class LoginForm : Form
    {
        string ID = ""; string Pswd = "";

        public LoginForm()
        {
            InitializeComponent();
        }

        //나가기 버튼
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
