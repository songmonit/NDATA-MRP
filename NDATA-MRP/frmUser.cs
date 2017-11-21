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
            // TODO: This line of code loads data into the 'dsNdataMrp.Quyen' table. You can move, or remove it, as needed.
            this.quyenTableAdapter.Fill(this.dsNdataMrp.Quyen);
            // TODO: This line of code loads data into the 'dsNdataMrp.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsNdataMrp.Users);

        }
        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            UtilityFunc u = new UtilityFunc();
            txtPass.Text = u.md5(txtPass.Text);
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsNdataMrp);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
