namespace MoreiraBank.Manager.UIs
{
    partial class EarningDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EarningsDataGridView = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.earningLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EarningsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EarningsDataGridView
            // 
            this.EarningsDataGridView.AllowUserToAddRows = false;
            this.EarningsDataGridView.AllowUserToDeleteRows = false;
            this.EarningsDataGridView.AllowUserToResizeColumns = false;
            this.EarningsDataGridView.AllowUserToResizeRows = false;
            this.EarningsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.EarningsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EarningsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.EarningsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EarningsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.Amount});
            this.EarningsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EarningsDataGridView.Location = new System.Drawing.Point(12, 13);
            this.EarningsDataGridView.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EarningsDataGridView.MultiSelect = false;
            this.EarningsDataGridView.Name = "EarningsDataGridView";
            this.EarningsDataGridView.ReadOnly = true;
            this.EarningsDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.EarningsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.EarningsDataGridView.RowTemplate.Height = 35;
            this.EarningsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EarningsDataGridView.Size = new System.Drawing.Size(1444, 607);
            this.EarningsDataGridView.TabIndex = 17;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.FillWeight = 5.076141F;
            this.Description.HeaderText = "Descrição";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.FillWeight = 194.9239F;
            this.Amount.HeaderText = "Valor";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 350;
            // 
            // earningLabel
            // 
            this.earningLabel.AutoSize = true;
            this.earningLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.earningLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.earningLabel.Location = new System.Drawing.Point(12, 626);
            this.earningLabel.Name = "earningLabel";
            this.earningLabel.Size = new System.Drawing.Size(110, 33);
            this.earningLabel.TabIndex = 20;
            this.earningLabel.Text = "R$ 20,00";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1150, 629);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 19;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(1306, 629);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 18;
            this.button2.Text = "Novo Ganho";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // EarningDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1469, 692);
            this.Controls.Add(this.EarningsDataGridView);
            this.Controls.Add(this.earningLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "EarningDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EarningDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.EarningsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView EarningsDataGridView;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Amount;
        private Label earningLabel;
        private Button button1;
        private Button button2;
    }
}