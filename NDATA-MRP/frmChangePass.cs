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
    public partial class frmChangePass : Form
    {
        public frmChangePass()
        {
            InitializeComponent();
        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {
            if (Program.usrCurrent.username != "")
            {
                lblUserCurent.Text = Program.usrCurrent.username;
            }
            else
            {
                frmLogin f = new frmLogin();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String sSQL = "";
            if (txtNewPass.Text != txtConfirmPass.Text)
                MessageBox.Show("Mật khẩu mới không khớp.");
            else
            {
                ConnectDB con = new ConnectDB();
                NdataFunc f = new NdataFunc();
                UtilityFunc u = new UtilityFunc();
                sSQL = "Select * from users where login='" + lblUserCurent.Text + "' and pass='" + u.md5(txtOldPass.Text) + "' ";
                if (con.checkTable(sSQL))
                {
                    //Login successful
                    string modified = DateTime.Now.ToString("u");
                    sSQL = "Update users set pass='" + u.md5(txtNewPass.Text) + "', modified='"+Convert.ToDateTime(modified)+"' where login='" + lblUserCurent.Text + "'";
                    f.executeQuery(sSQL, con.getConnection());
                    MessageBox.Show("Mật khẩu đã được thay đổi. Bạn có thể đăng nhập với mật khẩu mới.");
                    this.Dispose();
                }
                else
                    MessageBox.Show("Mật khẩu cũ không đúng.");
            }
        }
    }
}
