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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.nhanVienBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dsNdataMrp);
                maNVTextBox.Enabled = false;
                chkChangeMaNV.Checked = false;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
                NdataFunc n = new NdataFunc();
                n.write2Log(ex.Message);
            }

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;
            // TODO: This line of code loads data into the 'dsNdataMrp.NhanVien' table. You can move, or remove it, as needed.
            //this.nhanVienTableAdapter.Fill(this.dsNdataMrp.NhanVien);
            this.nhanVienTableAdapter.FillByStatus(this.dsNdataMrp.NhanVien,true);

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFiles = new OpenFileDialog();
            opFiles.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            opFiles.FilterIndex = 1;
            opFiles.RestoreDirectory = true;
            if (opFiles.ShowDialog() == DialogResult.OK)
            {
                hinhAnhPictureBox.ImageLocation = opFiles.FileName;
            }
        }

        private void hoTenTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedIndex == 1)
            {
                this.nhanVienTableAdapter.Fill(this.dsNdataMrp.NhanVien);
            }
            else
            {
                this.nhanVienTableAdapter.FillByStatus(this.dsNdataMrp.NhanVien, true);
            }
        }

        private void chkChangeMaNV_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChangeMaNV.Checked)
            {
                maNVTextBox.Enabled = true;
            }
            else
            {
                maNVTextBox.Enabled = false;
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            maNVTextBox.Enabled = true;
            chkChangeMaNV.Checked = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa nhân viên này không?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //this.nhanVienBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.dsNdataMrp);
            }
            else
            {
                cmbStatus_SelectedIndexChanged(sender, e);
            }
        }

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if(dsNdataMrp.GetChanges(DataRowState.Modified).HasChanges())
                {
                    DialogResult msgResult= MessageBox.Show("Bạn có muốn LƯU dữ liệu trước khi đóng không?", "THÔNG BÁO", MessageBoxButtons.YesNoCancel);
                    if (msgResult==DialogResult.Yes )
                    {
                        nhanVienBindingNavigatorSaveItem_Click(sender, e);
                    }
                    else if(msgResult == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        
                    }
                    
                }
            }
            catch(Exception ex)
            { }
        }
    }
}
