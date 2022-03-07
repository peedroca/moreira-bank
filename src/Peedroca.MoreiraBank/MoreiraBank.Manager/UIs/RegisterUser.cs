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
    public partial class RegisterUser : Form
    {
        private UserBusiness? business;

        public RegisterUser()
        {
            InitializeComponent();
        }

        #region Private Methods

        private void ClearFields()
        {
            FirstNameTextBox.Text = string.Empty;
            LastNameTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            UsernameTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
        }

        #endregion Private Methods

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (business != null)
            {
                var user = UserModel.New(UsernameTextBox.Text, PasswordTextBox.Text);
                var profile = ProfileModel.New(FirstNameTextBox.Text, LastNameTextBox.Text, EmailTextBox.Text);
                
                user.AddProfile(profile);

                var modelResponse = business.Create(user);

                if (modelResponse != null)
                {
                    MessageBox.Show($"Usuário número #{modelResponse.IdUser} criado.", "Usuário cadastrado com sucesso!");
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {
            business = new UserBusiness();
        }
    }
}
