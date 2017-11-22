using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace NDATA_MRP
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsNdataMrp.NhanVien' table. You can move, or remove it, as needed.
            //this.nhanVienTableAdapter.Fill(this.dsNdataMrp.NhanVien);
            this.nhanVienTableAdapter.FillByStatus(this.dsNdataMrp.NhanVien, true);
            // TODO: This line of code loads data into the 'dsNdataMrp.Quyen' table. You can move, or remove it, as needed.
            this.quyenTableAdapter.Fill(this.dsNdataMrp.Quyen);
            // TODO: This line of code loads data into the 'dsNdataMrp.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsNdataMrp.Users);

        }
        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (chkPassEdit.Checked)
            {
                UtilityFunc u = new UtilityFunc();
                txtPass.Text = u.md5(txtPass.Text);
            }
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsNdataMrp);
            chkPassEdit.Checked = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult msgResult = MessageBox.Show("Bạn có muốn XÓA tài khoản này không?", "THÔNG BÁO", MessageBoxButtons.YesNo);
            if (msgResult == DialogResult.Yes)
            {
                usersBindingNavigatorSaveItem_Click(sender, e);
            }
            else 
            {
                this.usersTableAdapter.Fill(this.dsNdataMrp.Users);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            txtPass.Enabled = true;
            txtPass.Focus();
            txtPass.SelectAll();
        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.SelectAll();
        }

        private void txtPass_MouseClick(object sender, MouseEventArgs e)
        {
            txtPass.SelectAll();
        }

        private void chkPassEdit_CheckedChanged(object sender, EventArgs e)
        {
            if(chkPassEdit.Checked)
            {
                txtPass.Enabled = true;
                txtPass.Focus();
                txtPass.SelectAll();
            }
            else
            {
                txtPass.Enabled = false;
            }
        }
    }
}
