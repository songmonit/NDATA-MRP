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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UtilityFunc u = new UtilityFunc();
            ConnectDB con = new ConnectDB();
            NdataFunc f = new NdataFunc();
            String sSQL = "Select * from users where active='true' and login='" + txtUser.Text + "' and pass='" + u.md5(this.txtPassword.Text) + "' ";
            if (con.checkTable(sSQL))
            {
                //Login successful
                SqlDataReader dr = f.getDataToDataReader(sSQL, con.getConnection());
                if (dr.Read())
                {
                    Program.usrCurrent.user_id = Convert.ToInt32(dr["ID"]);
                    Program.usrCurrent.username = dr["login"].ToString();
                    Program.usrCurrent.user_role = Convert.ToInt32(dr["role"]);
                    Program.usrCurrent.ma_NV = dr["MaNV"].ToString();
                }
                Program.mainForm.showMenu();
                this.Dispose();
            }
            else
            {
                Program.mainForm.hideMenu();
                MessageBox.Show(this, "Tài khoản đăng nhập không hợp lệ ,Bạn vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
