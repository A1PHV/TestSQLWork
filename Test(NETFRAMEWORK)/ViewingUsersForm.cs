using System;
using System.Windows.Forms;
using System.Data.Entity;
using System.Collections.Generic;

namespace Test_NETFRAMEWORK_
{
    public partial class ViewingUsersForm : Form
    {
        UserDB _uDB; 

        public ViewingUsersForm()
        {
            InitializeComponent();
            _uDB = new UserDB();
            _uDB.Users.Load();
            _uDB.UsersInfo.Load();

            viewUsersDesk.DataSource = _uDB.Users.Local.ToBindingList();
            viewUsersInfoDesk.DataSource = _uDB.UsersInfo.Local.ToBindingList();
        }
        
        private void addButton_Click(object sender, EventArgs e) //Добавить
        {
            AddingUsersForm _aU = new AddingUsersForm(_uDB);

            _aU.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e) //Изменить
        {
            if (viewUsersDesk.SelectedRows.Count > 0)
            {
                viewUsersInfoDesk.ClearSelection();
                int _uIndex = viewUsersDesk.SelectedRows[0].Index;
                int _uId = 0;
                bool _uConverted = Int32.TryParse(viewUsersDesk[0, _uIndex].Value.ToString(), out _uId);
                if (_uConverted == false)
                    return;

                Users _u = _uDB.Users.Find(_uId);

                EditingUsersForm _eU = new EditingUsersForm(_uDB, _u);

                _eU.ShowDialog();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e) //Удалить
        {
            if (viewUsersDesk.SelectedRows.Count > 0)
            {
                int _uIndex = viewUsersDesk.SelectedRows[0].Index;
                int _uId = 0;
                bool _uConverted = Int32.TryParse(viewUsersDesk[0, _uIndex].Value.ToString(), out _uId);
                if (_uConverted == false)
                    return;

                Users _u = _uDB.Users.Find(_uId);

                _uDB.Users.Remove(_u);
                _uDB.UsersInfo.Remove(_u.UsersInfo);

                _uDB.SaveChanges();
            }           
        }

        private void ViewingUsersForm_Load(object sender, EventArgs e)
        {
            viewUsersInfoDesk.ClearSelection();
            viewUsersDesk.ClearSelection();
        }

        private void statisticButton_Click(object sender, EventArgs e)
        {
            StatisticForm _sF = new StatisticForm(_uDB);

            _sF.ShowDialog();
        }
    }
}
