namespace MoreiraBank.Manager.UIs
{
    public partial class SpendingDashboard : Form
    {
        private long profileId;

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

        internal SpendingDashboard WithProfileId(long profileId)
        {
            this.profileId = profileId;
            return this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Hide();

            new RegisterSpending()
                .WithProfile(profileId)
                .ShowDialog();
            
            Close();
        }
    }
}
