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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void showMenu()
        {
            //loginMenu.Visible = false;
            DangNhapMenuItem.Enabled = false;
            DangXuatMenuItem.Enabled = true;
            DoiMatKhauMenuItem.Enabled = true;
            QuanLyUserMenuItem.Enabled = true;
           

        }
        public void hideMenu()
        {
            //FuncMenu.Enabled = false;
            DangNhapMenuItem.Enabled = true;
            DangXuatMenuItem.Enabled = false;
            DoiMatKhauMenuItem.Enabled = false;
            QuanLyUserMenuItem.Enabled = false;
        }
        private void DangNhapMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void DoiMatKhauMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePass f = new frmChangePass();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void DangXuatMenuItem_Click(object sender, EventArgs e)
        {
            Program.usrCurrent.Empty();
            hideMenu();
        }

        private void QuanLyUserMenuItem_Click(object sender, EventArgs e)
        {
            frmUser f = new frmUser();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void ThoatMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
