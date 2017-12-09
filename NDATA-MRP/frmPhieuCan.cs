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
    public partial class frmPhieuCan : Form
    {
        private DataTable dataTable = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private BindingSource bindingSource = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        public frmPhieuCan()
        {
            InitializeComponent();
        }
        private int lanCan = 1;

        private void phieuCanChiTietBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();


        }

        private void frmPhieuCan_Load(object sender, EventArgs e)
        {
            String sSQL = "SELECT phieu_can,lan_can,trong_luong FROM PhieuCanChiTiet";
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
            dgvPhieuCanChiTiet.Columns[1].HeaderText = "LẦN CÂN";
            dgvPhieuCanChiTiet.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhieuCanChiTiet.Columns[2].Width = 110;
            dgvPhieuCanChiTiet.Columns[2].HeaderText = "TRỌNG LƯỢNG";
            dgvPhieuCanChiTiet.Columns[2].Width = 180;
            
            // if you want to hide Identity column
            //dgvPhieuCanChiTiet.Columns[0].Visible = false;
            txtLanCan.Text = lanCan.ToString();

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            //add data
            String tl = txtTrongLuong.Text.Trim();

            if (tl != "" && IsNumeric(tl))
            {
                DataRow row = dataTable.NewRow();
                row["phieu_can"] = txtPhieuCan.Text;
                row["lan_can"] = txtLanCan.Text;
                row["trong_luong"] = txtTrongLuong.Text;
                dataTable.Rows.Add(row);
                lanCan = lanCan + 1;
                txtLanCan.Text = lanCan.ToString();
            }
            else
            {
                MessageBox.Show(this,"Trọng lượng chưa nhập hoặc dữ liệu chưa đúng.","THÔNG BÁO");
            }
        }
        public static bool IsNumeric(string s)
        {
            float output;
            return float.TryParse(s, out output);
        }
    }
}
