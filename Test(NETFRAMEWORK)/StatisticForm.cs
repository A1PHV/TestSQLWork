using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_NETFRAMEWORK_
{
    public partial class StatisticForm : Form
    {
        UserDB _uDB;
        List<int> _cl = new List<int>();
        List<string> _nm = new List<string>();
        public StatisticForm(UserDB _uDB)
        {
            InitializeComponent();
            this._uDB = _uDB;
        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            userStatistic.Series["Users"].LegendText = "User statistic";
            foreach (Users _u in _uDB.Users)
            {
                string _userRole = _u.UsersInfo.Role;
                _userRole = _userRole.Replace(" ", string.Empty);
                if (_userRole != "Admin")
                    userStatistic.Series["Users"].Points.AddXY(_u.Login, _u.UsersInfo.Click);
            }

        }
    }
}
