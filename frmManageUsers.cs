using System;
using System.Linq;
using System.Windows.Forms;

namespace AdvancedLoginSystem
{
    public partial class frmManageUsers : Form
    {
        public string userName, Email;
        public string Role;
        public string isActive;
        public string temp;
        public string result;
        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            dgvUserdata.SelectionChanged += new EventHandler(
          dgvUserdata_SelectionChanged);
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                cobRole.Items.Clear();
                cobRole.DataSource = db.Roles.ToList();
                cobRole.DisplayMember = "RoleName";
                cobRole.ValueMember = "RoleId";
            }
            RefreshDataGrid();
        }
        public void RefreshDataGrid()
        {
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                dgvUserdata.DataSource = db.spSearchViewUsers(txtSearch.Text);
                dgvUserdata.Refresh();
            }

        }

        private void dgvUserdata_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUserdata.SelectedCells.Count > 0)
            {
                temp = dgvUserdata.SelectedCells[0].Value.ToString();
                using (DataClassesDataContext db = new DataClassesDataContext())
                {
                    db.spReadUsers(Convert.ToInt32(temp), ref userName, ref Email, ref Role, ref isActive);
                }
            }
            txtUserName.Text = userName;
            txtEmail.Text = Email;
            cobRole.SelectedValue = Convert.ToInt32(Role);
            if (isActive == "1")
            {
                chkIsActived.Checked = true;
            }
            else
            {
                chkIsActived.Checked = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (chkIsActived.Checked == true)
            {
                using (DataClassesDataContext db = new DataClassesDataContext())
                {
                    db.spManageUsers(Convert.ToInt32(temp), Convert.ToInt32(cobRole.SelectedValue), true, ref result);
                    MessageBox.Show(result);
                    RefreshDataGrid();
                }
            }
            else
            {
                using (DataClassesDataContext db = new DataClassesDataContext())
                {
                    db.spManageUsers(Convert.ToInt32(temp), Convert.ToInt32(cobRole.SelectedValue), false, ref result);
                    MessageBox.Show(result);
                    RefreshDataGrid();
                }
            }
        }
    }
}
