using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NDATA_MRP
{
    public partial class frmPhieuCanHang : Form
    {
        public frmPhieuCanHang()
        {
            InitializeComponent();
        }
        private DataTable dataTable = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private BindingSource bindingSource = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private int lanCan = 1;
        private void frmPhieuCanHang_Load(object sender, EventArgs e)
        {
            try
            {
                // Loads data into the 'dsNdataMrp.PhieuCan' table.
                this.phieuCanTableAdapter.Fill(this.dsNdataMrp.PhieuCan);
                phieuCanBindingSource.AddNew();

                //dateTime format
                dateTimePickerNgayCan.Value = DateTime.Today;
                dateTimePickerNgayCan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                dateTimePickerNgayCan.CustomFormat = "dd-MM-yyyy";

                //dateTimePickerGioDen.Text = DateTime.Now.ToShortTimeString();
                dateTimePickerGioDen.Format = DateTimePickerFormat.Custom;
                dateTimePickerGioDen.CustomFormat = "HH:mm";
                dateTimePickerGioDen.ShowUpDown = true;
                dateTimePickerGioDen.Value = DateTime.Now;

                //Load MaKH
                NdataFunc f = new NdataFunc();
                String sSQL = "SELECT supplier_code, supplier_name FROM dbo.Suppliers ORDER BY supplier_name ASC";
                f.addToComboBox1(cmbMaKH, sSQL, "supplier_code");

                //Load TenKH
                sSQL = "SELECT supplier_code, supplier_name FROM dbo.Suppliers ORDER BY supplier_name ASC";
                f.addToComboBox(cmbTenKH, sSQL, "supplier_name", "supplier_code");
                cmbTenKH.SelectedIndex = -1;

                //load Items No
                sSQL = "SELECT item_no, name FROM dbo.Items ORDER BY item_no ASC";
                f.addToComboBox1(cmbMaNL, sSQL, "item_no");

                //load Items
                sSQL = "SELECT item_no, name FROM dbo.Items ORDER BY name ASC";
                f.addToComboBox(cmbItem, sSQL, "name", "item_no");
                cmbItem.SelectedIndex = -1;

                //Set default status
                txtStatus.Text = "10";

                //Set default QC note
                txtQCNote.Text = "Đánh giá chất lượng";
                chkOkQC.Checked = true;

                //Input PhieuCan
                initPhieuCanChiTiet(txtSoPhieu.Text);

                //input NguoiCan
                cmbNguoiCan.Text = f.getLasFieldValue("NhanVien","HoTen","MaNV=N'"+ Program.usrCurrent.ma_NV+"' ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void initPhieuCanChiTiet(string soPhieu)
        {
            try
            {
                String sSQL = "SELECT phieu_can,lan_can,trong_luong,lot,status FROM PhieuCanChiTiet WHERE phieu_can=N'" + soPhieu + "'";
                NdataFunc ndata = new NdataFunc();
                sqlDataAdapter = ndata.getSqlDataAdapter(sSQL);
                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dgvPhieuCanChiTiet.DataSource = bindingSource;


                dgvPhieuCanChiTiet.Columns[0].HeaderText = "PHIẾU CÂN";
                dgvPhieuCanChiTiet.Columns[0].Visible = false;
                dgvPhieuCanChiTiet.Columns[0].DefaultCellStyle.ForeColor = Color.Gray;

                dgvPhieuCanChiTiet.Columns[1].HeaderText = "LẦN CÂN";
                dgvPhieuCanChiTiet.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPhieuCanChiTiet.Sort(dgvPhieuCanChiTiet.Columns[1], ListSortDirection.Descending);

                dgvPhieuCanChiTiet.Columns[2].HeaderText = "TRỌNG LƯỢNG";
                dgvPhieuCanChiTiet.Columns[2].Width = 160;
                dgvPhieuCanChiTiet.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvPhieuCanChiTiet.Columns[3].HeaderText = "LOT";
                dgvPhieuCanChiTiet.Columns[3].Width = 160;
                dgvPhieuCanChiTiet.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPhieuCanChiTiet.Columns[3].Visible = true;

                dgvPhieuCanChiTiet.Columns[4].HeaderText = "LOẠI BỎ";
                dgvPhieuCanChiTiet.Columns[4].Width = 68;
                dgvPhieuCanChiTiet.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                //checkColumn.Name = "chkCancel";
                //checkColumn.HeaderText = "LOẠI BỎ";
                //checkColumn.Width = 68;
                //checkColumn.ReadOnly = false;
                //checkColumn.FillWeight = 10;
                //dgvPhieuCanChiTiet.Columns.Add(checkColumn);
                
            }
            catch(Exception ex) { }

            // if you want to hide Identity column
            //dgvPhieuCanChiTiet.Columns[0].Visible = false;
            txtLanCan.Text = lanCan.ToString();

        }

        private void cmbTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMaKH.SelectedItem = cmbTenKH.SelectedValue;
        }

        private void cmbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTenKH.SelectedValue = cmbMaKH.SelectedItem;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //add data
            String tl = txtTrongLuong.Text.Trim();

            if (IsNumeric(tl) && Convert.ToDouble(tl)>0)
            {
                DataRow row = dataTable.NewRow();
                row["phieu_can"] = txtSoPhieu.Text.Trim();
                row["lan_can"] = txtLanCan.Text;
                row["trong_luong"] = txtTrongLuong.Text;
                row["lot"] = txtLot.Text.Trim();
                row["status"] = false;
                dataTable.Rows.Add(row);
                lanCan = lanCan + 1;
                txtLanCan.Text = lanCan.ToString();
                if(dgvPhieuCanChiTiet.Rows.Count>1)
                    dgvPhieuCanChiTiet.CurrentCell = dgvPhieuCanChiTiet.Rows[0].Cells[2];
                
                //update db
                bindingSource.EndEdit();
                //sqlDataAdapter.Update(dataTable);
                this.updTongTL();
            }
            else
            {
                MessageBox.Show(this, "Trọng lượng chưa nhập hoặc dữ liệu chưa đúng.", "THÔNG BÁO");
            }
        }
        private String setSoPhieu()
        {
            NdataFunc f = new NdataFunc();
            string lastID = f.getLasFieldValue("PhieuCan","So_Phieu");
            return f.NextID(lastID);
        }
        public static bool IsNumeric(string s)
        {
            float output;
            return float.TryParse(s, out output);
        }

        private void cmbMaNL_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbItem.SelectedValue = cmbMaNL.SelectedItem;
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMaNL.SelectedItem = cmbItem.SelectedValue;
        }

        private bool checkDataInput()
        {
            NdataFunc f = new NdataFunc();
            //check Item code
            if (!f.checkRecordExit("Items", "item_no= N'" + cmbItem.SelectedValue + "'"))
            {
                MessageBox.Show("Mã nguyên liệu không tồn tại. Bạn vui lòng chọn lại", "THÔNG BÁO");
                return false;
            }
            //check MaKH
            if (!f.checkRecordExit("Suppliers","supplier_code= N'"+ cmbTenKH.SelectedValue +"'"))
            {
                DialogResult tb= MessageBox.Show("Mã khách hàng không tồn tại. Bạn có muốn thêm khách hàng mới bây giờ không?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(tb==DialogResult.Yes)
                {
                    frmKhachHang frmKH = new frmKhachHang();
                    frmKH.Show();
                }
                return false;
            }
            //check SO XE, NGUON GOC, KHO LUU
            string msg = "";
            if (String.IsNullOrEmpty(txtSoXe.Text)) { msg = msg + " [SỐ XE],"; }
            if (String.IsNullOrEmpty(txtNguon.Text)) { msg = msg + " [NGUỒN],"; }
            if (String.IsNullOrEmpty(txtLuuKho.Text)) { msg = msg + " [KHO LƯU],"; }
            if(msg!="")
            {
                msg = "Vui lòng nhập dữ liệu cho ô " + msg + " của phiếu cân.";
                MessageBox.Show(msg, "THÔNG BÁO");
                return false;
            }
            return true;
        }

        private void phieuCanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (checkDataInput())
            {
                txtSoPhieu.Text = setSoPhieu();
                this.Validate();
                this.phieuCanBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dsNdataMrp);
            }
        }
        private void updTongTL()
        {
               double TongTL = 0;
                foreach (DataGridViewRow row in dgvPhieuCanChiTiet.Rows)
                {

                    if (Convert.ToBoolean(row.Cells[4].Value) == true)
                    {
                        row.DefaultCellStyle.ForeColor = Color.Gray;
                        row.DefaultCellStyle.Font = new Font(this.Font,FontStyle.Strikeout);
                    }
                    else
                    {
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        row.DefaultCellStyle.Font = new Font(this.Font, FontStyle.Regular);
                        TongTL += Convert.ToDouble(row.Cells[2].Value);
                    }
                }

                txtTongKL.Text = TongTL.ToString();
        }

        private void txtSoPhieu_TextChanged(object sender, EventArgs e)
        {
            //SoPhieu is null: disable scales function
            if(String.IsNullOrWhiteSpace(txtSoPhieu.Text))
            {
                panelRDetail.Enabled = false;
                dgvPhieuCanChiTiet.Enabled = false;
            }
            else
            {
                //check status of PhieuCan
                panelRDetail.Enabled = true;
                dgvPhieuCanChiTiet.Enabled = true;
                //Input PhieuCan
                initPhieuCanChiTiet(txtSoPhieu.Text);
            }

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
            switch (txtStatus.Text)
            {
                case "10":
                    lblStatus.Text = "Mới";
                    break;
                case "20":
                    lblStatus.Text = "Đã Hủy";
                    break;
                case "90":
                    lblStatus.Text = "Đã Cân Xong";
                    break;
                default:
                    lblStatus.Text = "Đang cân";
                    tlbSatus.Text = "Đang cân";
                    break;

            }
        }

        private void txtQCNote_Enter(object sender, EventArgs e)
        {
            if(txtQCNote.Text== "Đánh giá chất lượng")
            {
                txtQCNote.Text = "";
            }
        }

        private void txtQCNote_Leave(object sender, EventArgs e)
        {
            if(txtQCNote.Text=="")
            {
                txtQCNote.Text = "Đánh giá chất lượng";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save and Lock phieuCan
            txtStatus.Text = "90";
            this.updTongTL();
            this.Validate();
            this.phieuCanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsNdataMrp);

            btnPrint.Enabled = true;
            btnDel.Enabled = false;
            btnSave.Enabled = false;
        }
        private bool checkStatus()
        {
            bool flag = false;
            if(flag)
            {
                btnPrint.Enabled = true;
                btnDel.Enabled = false;
                btnSave.Enabled = false;
            }
            else
            {
                btnPrint.Enabled = false;
                btnDel.Enabled = true;
                btnSave.Enabled = true;
            }

            return flag;
        }
    }
}