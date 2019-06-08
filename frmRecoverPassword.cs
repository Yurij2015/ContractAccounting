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
    public partial class frmRecoverPassword : Form
    {
        public string result;
        public string question;
        public frmRecoverPassword()
        {
            InitializeComponent();
        }

        private void RecoverPassword_Load(object sender, EventArgs e)
        {
            groupBox2.Hide();
            groupBox3.Hide();
        }

        private void BtnRecover_Click(object sender, EventArgs e)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                db.spCheckEmail(txtEmailID.Text, "CheckEmail", ref result, ref question, txtAnswer.Text, txtConfirmNewPassword.Text);
                db.SubmitChanges();
                MessageBox.Show(result);
                if (result == "Please answer the security Question.")
                {
                    txtQuestion.Text = question;
                    groupBox2.Show();
                    groupBox3.Hide();
                }
                else
                {
                    txtQuestion.Text = "";
                    groupBox2.Hide();
                    groupBox3.Hide();
                }
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                db.spCheckEmail(txtEmailID.Text, "CheckSecurity", ref result, ref question, txtAnswer.Text, txtConfirmNewPassword.Text);
                db.SubmitChanges();
                MessageBox.Show(result);
                if (result == "Enter your password!")
                {
                    txtQuestion.Text = question;
                    groupBox3.Show();
                }
                else
                {
                    txtQuestion.Text = "";
                    groupBox3.Hide();
                }
            }
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == txtConfirmNewPassword.Text)
            {
                using (DataClassesDataContext db = new DataClassesDataContext())
                {
                    db.spCheckEmail(txtEmailID.Text, "ChangePassword", ref result, ref question, txtAnswer.Text, txtConfirmNewPassword.Text);
                    db.SubmitChanges();
                    MessageBox.Show(result);
                    txtEmailID.Text = "";
                    txtAnswer.Text = "";
                    txtNewPassword.Text = "";
                    txtConfirmNewPassword.Text = "";
                    txtQuestion.Text = "";
                    groupBox2.Hide();
                    groupBox3.Hide();
                }
            }
            else
            {
                MessageBox.Show("Password does not matching");
            }
        }

        private void txtEmailId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
