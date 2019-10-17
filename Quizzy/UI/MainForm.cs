using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizzy.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void lblExit_Click(object sender, EventArgs e)
        {
           
        }

        private void btnManageQuizzes_Click(object sender, EventArgs e)
        {
            checkOpenForm();

            ManageQuizzes manageQuizzes = new ManageQuizzes();
            manageQuizzes.TopLevel = false;
            manageQuizzes.AutoScroll = true;
            this.panel3.Controls.Add(manageQuizzes);
            manageQuizzes.Show();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                frm.WindowState = FormWindowState.Minimized;
            }
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            checkOpenForm();

            ManageUser manageUser = new ManageUser();
            manageUser.TopLevel = false;
            manageUser.AutoScroll = true;
            this.panel3.Controls.Add(manageUser);
            manageUser.Show();
        }

        private void checkOpenForm()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm != this)
                    frm.Hide();
            }
        }
    }
}
