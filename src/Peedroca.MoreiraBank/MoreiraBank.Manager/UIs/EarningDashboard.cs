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
    public partial class EarningDashboard : Form
    {
        public EarningDashboard()
        {
            InitializeComponent();
        }

        internal EarningDashboard WithData(dynamic? list)
        {
            EarningsDataGridView.AutoGenerateColumns = false;
            EarningsDataGridView.DataSource = list;

            return this;
        }

        internal EarningDashboard WithFooter(string footer)
        {
            earningLabel.Text = footer;
            return this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
