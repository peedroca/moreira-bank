namespace MoreiraBank.Manager.UIs
{
    public partial class SpendingDashboard : Form
    {
        public SpendingDashboard()
        {
            InitializeComponent();
        }

        internal SpendingDashboard WithData(dynamic? list)
        {
            SpendingsDataGridView.AutoGenerateColumns = false;
            SpendingsDataGridView.DataSource = list;

            return this;
        }

        internal SpendingDashboard WithFooter(string footer)
        {
            spendingLabel.Text = footer;
            return this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
