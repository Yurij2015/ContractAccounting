using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedLoginSystem
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            label1.Text = "Административный доступ пользователя : " + AdvancedLoginSystem.Properties.Settings.Default.UserLog ;
        }

        private void userRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistration reg = new frmRegistration();
            reg.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword chgpas = new frmChangePassword();
            chgpas.Show();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUsers mngusr = new frmManageUsers();
            mngusr.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin lgn = new frmLogin();
            this.Hide();
            lgn.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
