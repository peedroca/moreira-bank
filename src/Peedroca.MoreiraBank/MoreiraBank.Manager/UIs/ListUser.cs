using MoreiraBank.Manager.Business;
using MoreiraBank.Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoreiraBank.Manager.UIs
{
    public partial class ListUser : Form
    {
        private UserBusiness? business;
        private List<UserModel>? users;

        public ListUser()
        {
            InitializeComponent();
        }

        #region Private Methods

        private void LoadGrid()
        {
            if (business == null)
                return;

            users = business.GetUsers();

            if (users == null)
                return;

            UsersDataGridView.AutoGenerateColumns = false;
            UsersDataGridView.DataSource = users.SelectMany(u => u.Profiles).ToList();
        }

        #endregion Private Methods

        private void ListUser_Load(object sender, EventArgs e)
        {
            business = new UserBusiness();
            users = new List<UserModel>();

            LoadGrid();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Hide();
            new RegisterUser().ShowDialog();

            LoadGrid();
            Show();
        }
    }
}
