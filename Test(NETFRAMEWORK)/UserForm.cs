using System;
using System.Windows.Forms;

namespace Test_NETFRAMEWORK_
{
    public partial class UserForm : Form
    {
        Users _u;
        UserDB _uDB;

        int cnt = 0;
        public UserForm(UserDB _uDB, Users _u)
        {
            InitializeComponent();
            this._uDB = _uDB;
            this._u = _u;
            cnt = (int)_u.UsersInfo.Click;
            counter.Text = cnt.ToString();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            cnt++;
            counter.Text = cnt.ToString();

        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            cnt--;
            counter.Text = cnt.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            _u.UsersInfo.Click = cnt;
            _uDB.SaveChanges();
            this.Close();
        }
    }
}
