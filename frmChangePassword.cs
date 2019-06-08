using System;
using System.Windows.Forms;

namespace AdvancedLoginSystem
{
    public partial class frmChangePassword : Form
    {
        public string result;
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                db.spChangePassword(AdvancedLoginSystem.Properties.Settings.Default.Email, txtCurrentPassword.Text, txtNewPassword.Text, txtConfirmNewPassword.Text, ref result);
                db.SubmitChanges();
                MessageBox.Show(result);
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
