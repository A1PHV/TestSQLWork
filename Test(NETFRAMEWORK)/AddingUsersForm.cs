using System;
using System.Windows.Forms;

namespace Test_NETFRAMEWORK_
{
    public partial class AddingUsersForm : Form
    {
        UserDB _uDB;

        string[] Roles = { "User", "Admin" };

        public AddingUsersForm(UserDB _uDB)
        {
            InitializeComponent();
            this._uDB = _uDB;


            roleBox.Items.AddRange(Roles);
        }
        private void addUser()
        {
            Users _u = new Users();
            UsersInfo _uI = new UsersInfo();

            _u.Login = usernameBox.Text;
            _u.Password = passwordBox.Text;
            _uI.Last_name = lastnameBox.Text;
            _uI.First_name = firstnameBox.Text;
            _uI.Patronymic = patronymicBox.Text;
            _uI.Role = roleBox.SelectedItem.ToString();
            _uI.Users = _u;
            _u.UsersInfo = _uI;
            _uI.id = _uDB.UsersInfo.Local.Count + 1;
            _u.id = _uDB.Users.Local.Count + 1;

            try
            {
                _uDB.Users.Add(_u);
                _uDB.UsersInfo.Add(_uI);
                _uDB.SaveChanges();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                this.Close();
            }

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            addUser();
            this.Close();
        }
    }
}
