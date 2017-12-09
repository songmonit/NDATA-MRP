using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDATA_MRP
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private Boolean isDataChanged = false;

        private void suppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsNdataMrp);
            isDataChanged = false;

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsNdataMrp.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.dsNdataMrp.Suppliers);
            // dgvSupplier.CellValueChanged += new EventHandler(CheckValue)
            this.dgvSupplier.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplier_CellValueChanged);
            this.dgvSupplier.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplier_RowEnter);
            this.dgvSupplier.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplier_RowLeave);


        }

        private void dgvSupplier_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            isDataChanged = true;
        }

        private void dgvSupplier_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDataChanged)
            {
                DialogResult msgResult = MessageBox.Show("Dữ liệu đã có thay đổi. Bạn có muốn LƯU trước khi đóng không?", "THÔNG BÁO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (msgResult == DialogResult.Yes)
                {
                    suppliersBindingNavigatorSaveItem_Click(sender, e);
                }
                else if (msgResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void dgvSupplier_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the row error in case the user presses ESC.   
            dgvSupplier.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void dgvSupplier_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string colDataName = dgvSupplier.Columns[e.ColumnIndex].DataPropertyName;
            // Abort validation if cell is not in the CompanyName column.
            if (!colDataName.Equals("Supplier_Name")) return;

            // Confirm that the cell is not empty.
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                dgvSupplier.Rows[e.RowIndex].ErrorText =
                    "Bạn chưa nhập TÊN KHÁCH HÀNG.";
                e.Cancel = true;
            }
        }
        private Boolean checkDataRowChange(int rowIndex)
        {

            return true;
        }

        private void dgvSupplier_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            for (int i = 0; i < dgvSupplier.Rows[e.RowIndex].Cells.Count; i++)
            {
                dgvSupplier[i, e.RowIndex].Style.BackColor = Color.Yellow;
               
            }
        }

        private void dgvSupplier_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgvSupplier.Rows[e.RowIndex].Cells.Count; i++)
            {
                dgvSupplier[i, e.RowIndex].Style.BackColor = Color.Empty;
            }
        }

    }
}
