using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDATA_MRP
{
    class User
    {
        private int _user_id;
        private string _username;
        private int _user_role;
        private string _ma_NV;
        public int user_id
        {
            get { return _user_id; }
            set { _user_id = value; }
        }
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }
        public int user_role
        {
            get { return _user_role; }
            set { _user_role = value; }
        }
        public string ma_NV
        {
            get { return _ma_NV; }
            set { _ma_NV = value; }
        }
        public void Empty()
        {
            user_id = 0;
            username = string.Empty;
            user_role = 0;
            ma_NV = string.Empty;
        }
    }
}
