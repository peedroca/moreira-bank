using MoreiraBank.Manager.Business;
using MoreiraBank.Manager.Facades;
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
    public partial class MainDashboard : Form
    {
        private FinanceFacade? financeFacade;

        public MainDashboard()
        {
            InitializeComponent();
        }

        #region Private Methods

        private void LoadFinance()
        {
            if (financeFacade == null)
                throw new NullReferenceException(nameof(financeFacade));

            earningLabel.Text = financeFacade
                .GetEarning()?
                .Sum(s => s.Amount)
                .ToString("c2");

            spendingLabel.Text = financeFacade
                .GetSpending()?
                .Sum(s => s.Amount)
                .ToString("c2");

            estimatedInvestimentLabel.Text = financeFacade
                .GetEstimatedInvestments()?
                .Where(w => int.Parse(w.Calendar?.CalendarMonth ?? "0") == DateTime.Now.Month)
                .Sum(s => s.Amount)
                .ToString("c2");

            investimentLabel.Text = financeFacade
                .GetInvestiments()?
                .Where(w => w.StartDate.Year == DateTime.Now.Year && w.StartDate.Month == DateTime.Now.Month)
                .Sum(s => s.Amount)
                .ToString("c2");
        }

        #endregion Private Methods

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            financeFacade = new FinanceFacade(1);
            LoadFinance();
        }

        private void spendingLabel_Click(object sender, EventArgs e)
        {
            if (financeFacade == null)
                throw new NullReferenceException(nameof(financeFacade));

            var spendings = financeFacade.GetFinance()?.SpendingModels?
            .Select(s => new
            {
                s.Description,
                Amount = s.Amount.ToString("c2")
            }
            ).ToList();

            new SpendingDashboard()
                .WithData(spendings)
                .WithFooter(string.Format("Total: {0}", spendingLabel.Text))
                .Show();
        }

        private void earningLabel_Click(object sender, EventArgs e)
        {
            if (financeFacade == null)
                throw new NullReferenceException(nameof(financeFacade));

            var earnings = financeFacade.GetFinance()?.EarningModels?
            .Select(s => new
            {
                s.Description,
                Amount = s.Amount.ToString("c2")
            }
            ).ToList();

            new EarningDashboard()
                .WithData(earnings)
                .WithFooter(string.Format("Total: {0}", earningLabel.Text))
                .Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
