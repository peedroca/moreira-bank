using MoreiraBank.Manager.Facades;
using MoreiraBank.Manager.Helpers;
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
    public partial class RegisterSpending : Form
    {
        private long profileId;

        public RegisterSpending()
        {
            InitializeComponent();
        }

        #region Public Methods

        internal RegisterSpending WithProfile(long profileId)
        {
            this.profileId = profileId;
            return this;
        }

        #endregion Public Methods

        private void SaveButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            decimal.TryParse(AmountTextBox.Text, out var amount);

            var facade = new FinanceFacade(profileId);
            var modelResponse = facade.CreateSpending(DescriptionTextBox.Text, amount);

            if (modelResponse.Success)
            {
                MessageBox.Show($"Gasto #{modelResponse.Result?.SpendingId}  criado.", "Despeza cadastrado com sucesso!");
                Close();
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
    }
}
