using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NDATA_MRP
{
    class NdataFunc
    {
        public NdataFunc()
        {
        }

        /*public ConnectionInfo reportConnectionInfo()
        {
            
            SqlConnection conn = new ConnectDB().getConnection();
            //SqlConnection con=new SqlConnection(
            ConnectionInfo conInfo = new ConnectionInfo();
            conInfo.ServerName = System.Configuration.ConfigurationManager.AppSettings.Get("serverName");
            conInfo.DatabaseName = System.Configuration.ConfigurationManager.AppSettings.Get("dbName");
            conInfo.UserID = System.Configuration.ConfigurationManager.AppSettings.Get("userName");
            conInfo.Password = System.Configuration.ConfigurationManager.AppSettings.Get("pass");
            return conInfo;
        }*/
        public IDataReader getDataToIDataReader(String sSQL, SqlConnection con)
        {
            SqlCommand cm = new SqlCommand(sSQL, con);
            IDataReader dr = cm.ExecuteReader();
            return dr;
        }
        public SqlDataReader getDataToDataReader(String sSQL, SqlConnection con)
        {
            SqlCommand cm = new SqlCommand(sSQL, con);
            SqlDataReader dr = cm.ExecuteReader();
            return dr;
        }
        public int executeQuery(String sSQL, SqlConnection con)
        {
            SqlCommand cm = new SqlCommand(sSQL, con);
            int temp = cm.ExecuteNonQuery();
            cm.Dispose();
            return temp;
        }
        public int executeQuery(String sSQL)
        {
            SqlConnection con = new ConnectDB().getConnection();
            SqlCommand cm = new SqlCommand(sSQL, con);
            int temp = cm.ExecuteNonQuery();
            cm.Dispose();
            return temp;
        }

        public DataSet getDataToDataSet(String sSQL, SqlConnection con)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter ad = new SqlDataAdapter(sSQL, con);
            ad.Fill(ds);
            return ds;
        }
        public DataTable getDataToTable(String sSQL, SqlConnection con)
        {
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            SqlDataAdapter ad = new SqlDataAdapter(sSQL, con);
            ad.Fill(table);
            return table;
        }
        public DataTable getDataToTable(String sSQL)
        {
            SqlConnection con = new ConnectDB().getConnection();
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            SqlDataAdapter ad = new SqlDataAdapter(sSQL, con);
            ad.Fill(table);
            return table;
        }
        public void addDataToListBox(ListBox listBox, String sSQL, SqlConnection con)
        {
            SqlDataReader dr = getDataToDataReader(sSQL, con);


        }
        public void addToComboBox(ComboBox cmb, string sSQL, string sText, string sValue)
        {
            BindingSource bindingSource1_ = new BindingSource();
            ConnectDB con = new ConnectDB();
            bindingSource1_.DataSource = getDataToTable(sSQL, con.getConnection());
            cmb.DataSource = bindingSource1_;
            cmb.DisplayMember = sText;
            cmb.ValueMember = sValue;
        }
        public void addToComboBox1(ComboBox cmb, string sSQL, string sText)
        {
            SqlConnection con = new ConnectDB().getConnection();
            SqlCommand cm = new SqlCommand(sSQL, con);
            SqlDataReader dr = cm.ExecuteReader();
            cmb.Items.Clear();
            cmb.Items.Add("All");
            while (dr.Read())
            {
                cmb.Items.Add(dr[sText]);
            }
            dr.Close();
            cmb.SelectedIndex = 0;
        }
        public bool checkKey(string sSQL, SqlConnection con)
        {
            SqlDataReader dr = getDataToDataReader(sSQL, con);
            bool flag = false;
            if (dr.Read())
                flag = true;
            dr.Close();
            return flag;

        }
        public bool checkKey(string sKey, string colName, string tableName)
        {
            bool flag = false;
            string sSql = "Select count(*) from "+tableName+" where "+colName+"='"+sKey+"' ";
            SqlConnection con = new ConnectDB().getConnection();

            flag = this.checkKey(sSql, con);
            return flag;
        }
        public void write2Log(string logContent)
        {
            if (Program.logErr)
            {
                //Table name = logerr(createdate,content, username)
                try
                {
                    string sSQL = "INSERT logerr INTO (created_date=now(), content='" + logContent + "', username='" + Program.usrCurrent.username + "')";
                    executeQuery(sSQL);
                }
                catch (Exception ex) { }
            }
        }
    }
}
