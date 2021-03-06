using MoreiraBank.Manager.Business;
using MoreiraBank.Manager.Facades;
using MoreiraBank.Manager.Helpers;
using MoreiraBank.Manager.Models;
using MoreiraBank.Manager.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoreiraBank.Manager.UIs
{
    public partial class RegisterUser : Form
    {
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
            errorProvider1.Clear();

            var facade = new UserFacade();
            facade.Create(UsernameTextBox.Text, PasswordTextBox.Text);
            facade.AddProfile(FirstNameTextBox.Text, LastNameTextBox.Text, EmailTextBox.Text);

            var modelResponse = facade.Save();

            if (modelResponse.Success)
            {
                MessageBox.Show($"Usuário número #{modelResponse.Result?.IdUser} criado.", "Usuário cadastrado com sucesso!");
            }
            else
            {
                var fields = GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

                foreach (var error in modelResponse.Errors)
                {
                    var control = TagHelper.Find(Controls, error.Key);

                    if (control != null)
                        errorProvider1.SetError(control, error.Message);
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {
        }
    }
}
