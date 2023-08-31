using System;
using System.Windows.Forms;

namespace Test_NETFRAMEWORK_
{
    public partial class EditingUsersForm : Form
    {
        Users _u;
        UserDB _uDB;

        string[] Roles = { "User", "Admin" };
        public EditingUsersForm(UserDB _uDB, Users _u)
        {
            InitializeComponent();

            this._uDB = _uDB;
            this._u = _u;

            usernameBox.Text = _u.Login;
            passwordBox.Text = _u.Password;
            lastnameBox.Text = _u.UsersInfo.Last_name;
            firtstnameBox.Text = _u.UsersInfo.First_name;
            patronymicBox.Text = _u.UsersInfo.Patronymic;
            roleBox.Text = _u.UsersInfo.Role;

            roleBox.Items.AddRange(Roles);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            _u.Login = usernameBox.Text;
            _u.Password = passwordBox.Text;
            _u.UsersInfo.Last_name = lastnameBox.Text;
            _u.UsersInfo.First_name = firtstnameBox.Text;
            _u.UsersInfo.Patronymic = patronymicBox.Text;
            _u.UsersInfo.Role = roleBox.SelectedItem.ToString();
            _uDB.SaveChanges();
            this.Close();
        }
    }
}
