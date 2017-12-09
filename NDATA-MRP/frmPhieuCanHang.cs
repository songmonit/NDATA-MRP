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
            // TODO: This line of code loads data into the 'dsNdataMrp.PhieuCan' table. You can move, or remove it, as needed.
            this.phieuCanTableAdapter.Fill(this.dsNdataMrp.PhieuCan);
            phieuCanBindingSource.AddNew();
            //dateTime format
            dateTimePickerNgayCan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePickerNgayCan.CustomFormat = "dd-MM-yyyy";

            dateTimePickerGioDen.Format = DateTimePickerFormat.Custom;
            dateTimePickerGioDen.CustomFormat = "HH:mm";
            dateTimePickerGioDen.ShowUpDown = true;

            //Load MaKH
            NdataFunc f = new NdataFunc();
            String sSQL = "SELECT supplier_code, supplier_name FROM dbo.Suppliers ORDER BY supplier_name ASC";
            f.addToComboBox1(cmbMaKH, sSQL,"supplier_code");
            
            //Load TenKH
            sSQL = "SELECT supplier_code, supplier_name FROM dbo.Suppliers ORDER BY supplier_name ASC";
            f.addToComboBox(cmbTenKH, sSQL, "supplier_name","supplier_code");
            cmbTenKH.SelectedIndex = -1;

            //load Items No
            sSQL = "SELECT item_no, name FROM dbo.Items ORDER BY item_no ASC";
            f.addToComboBox1(cmbMaNL, sSQL,"item_no");

            //load Items
            sSQL = "SELECT item_no, name FROM dbo.Items ORDER BY name ASC";
            f.addToComboBox(cmbItem, sSQL, "name", "item_no");
            cmbItem.SelectedIndex = -1;

            //set default status value
            cmbStatus.SelectedIndex = 0;

            //Input PhieuCan
            initPhieuCanChiTiet();

            //panelRDetail.Enabled = false;
            //dgvPhieuCanChiTiet.Enabled = false;
        }

        private void initPhieuCanChiTiet()
        {
            String sSQL = "SELECT phieu_can,lan_can,trong_luong,lot FROM PhieuCanChiTiet";
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
            dgvPhieuCanChiTiet.Columns[2].DefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleRight;

            dgvPhieuCanChiTiet.Columns[3].HeaderText = "LOT";
            dgvPhieuCanChiTiet.Columns[3].Width = 160;
            dgvPhieuCanChiTiet.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhieuCanChiTiet.Columns[3].Visible = true;

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "chkCancel";
            checkColumn.HeaderText = "LOẠI BỎ";
            checkColumn.Width = 68;
            checkColumn.ReadOnly = false;
            checkColumn.FillWeight = 10;
            dgvPhieuCanChiTiet.Columns.Add(checkColumn);


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

            if (tl != "" && IsNumeric(tl))
            {
                DataRow row = dataTable.NewRow();
                row["phieu_can"] = txtSoPhieu.Text.Trim();
                row["lan_can"] = txtLanCan.Text;
                row["trong_luong"] = txtTrongLuong.Text;
                row["lot"] = txtLot.Text.Trim();
                dataTable.Rows.Add(row);
                lanCan = lanCan + 1;
                txtLanCan.Text = lanCan.ToString();
                dgvPhieuCanChiTiet.CurrentCell = dgvPhieuCanChiTiet.Rows[0].Cells[2];
                //dgvPhieuCanChiTiet.Rows[0].Selected=true;
                //dgvPhieuCanChiTiet.CurrentCell.Style.SelectionBackColor = Color.Yellow;
                //dgvPhieuCanChiTiet.CurrentCell.Style.SelectionForeColor = Color.Black;
                //update db
                
                bindingSource.EndEdit();
                sqlDataAdapter.Update(dataTable);

            }
            else
            {
                MessageBox.Show(this, "Trọng lượng chưa nhập hoặc dữ liệu chưa đúng.", "THÔNG BÁO");
            }
        }
        private String setSoPhieu()
        {
            NdataFunc f = new NdataFunc();
            string lastID = f.GetLastID("PhieuCan","So_Phieu");
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
            }
            //Create phieu
            try
            {

                //dsNdataMrp.PhieuCanDataTable tblPhieu = new dsNdataMrp.PhieuCanDataTable();
                //dsNdataMrp.PhieuCanRow rowPhieu = tblPhieu.NewPhieuCanRow();
                //rowPhieu.So_Phieu = txtSoPhieu.Text;
                //rowPhieu.Ma_KH = cmbTenKH.SelectedValue.ToString();
                //rowPhieu.Ten_KH = cmbTenKH.SelectedText;

                ////tblPhieu.Rows.Add(rowPhieu);
                //tblPhieu.AddPhieuCanRow(rowPhieu);
                 

                //string Ma_KH = cmbTenKH.SelectedValue.ToString();
                //string Ten_KH = cmbTenKH.SelectedText;
                //string Ma_NL = cmbItem.SelectedValue.ToString();
                string sSQL = "INSERT INTO PhieuCan(Ma_KH,Ten_KH,Ma_NL,Ten_NL,Nguon,So_xe,Kho_luu, ngay, gio_den,Tong_TL_Can,Tru_TL,Tong_TL,Nguoi_can,Nguoi_duyet,mc_duyet,qc_duyet,status,qc_check,qc_note,createDate) " +
                                           "VALUES () ";
                //int rowAdd = f.executeQuery(sSQL);
                f.write2Log(sSQL, "AddNew");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                f.write2Log(ex.Message, "Error(Ins)");

            }
            return true;
        }

        private void phieuCanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            txtSoPhieu.Text = setSoPhieu();
            this.Validate();
            this.phieuCanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsNdataMrp);
            

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
        private void dgvPhieuCanChiTiet_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            int TongTL = 0;
            for (int i = 0; i < dgvPhieuCanChiTiet.Rows.Count; ++i)
            {
                TongTL += Convert.ToInt32(dgvPhieuCanChiTiet.Rows[i].Cells[2].Value);
            }
            txtTongKL.Text = TongTL.ToString();
        }
    }
}
