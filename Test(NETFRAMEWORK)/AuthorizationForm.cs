using System;
using System.Windows.Forms;
using System.Data.Entity;

namespace Test_NETFRAMEWORK_
{
    public partial class authorizationForm : Form
    {
        UserDB _uDB;
        public authorizationForm()
        {
            InitializeComponent();
            _uDB = new UserDB();
            _uDB.Users.Load();
            _uDB.UsersInfo.Load();
        }

        private void authorizeButton_Click(object sender, EventArgs e)
        {
            string _login = loginBox.Text;
            string _password = passwordBox.Text;

            var _listUsers = _uDB.Users;

            Users userTemp = CheckUser(_login, _password); 

            if (userTemp != null)
            {
                if (statusUser(userTemp))
                {
                    ViewingUsersForm _vU = new ViewingUsersForm();
                    _vU.ShowDialog();
                }
                if (!statusUser(userTemp))
                {
                    UserForm _uF = new UserForm(_uDB, userTemp);
                    _uF.ShowDialog();
                }
            }

            else
            {
                MessageBox.Show("Вы не прошли авторизацию");
            }
        }
        Users CheckUser(string _login, string _password)
        {
            Users result = null;
            foreach(Users u in _uDB.Users)
            {
                string _userLogin = u.Login;
                string _userPassword = u.Password;
                _userLogin = _userLogin.Replace(" ", string.Empty);
                _userPassword = _userPassword.Replace(" ", string.Empty);

                if (_userLogin == _login && _userPassword == _password)
                {
                    result = u;
                }
            }
            return result;
        }

        bool statusUser(Users _u)
        {
            string _userRole = _u.UsersInfo.Role;

            _userRole = _userRole.Replace(" ", string.Empty);

            if (_userRole == "Admin")
            {
                return true;
            }
            if (_userRole == "User")
            {
                return false;
            }
            return true;
        }
    }
}
