using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quizzy.BLL;
namespace Quizzy.UI
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            UserBLL userBLL = new UserBLL();
            if(userBLL.LogIn(txtUserName.Text, txtPassword.Text).Rows.Count>0)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Cancel");
            }
        }
    }
}
