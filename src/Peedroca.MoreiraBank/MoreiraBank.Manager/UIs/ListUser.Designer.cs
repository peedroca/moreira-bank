namespace MoreiraBank.Manager.UIs
{
    partial class ListUser
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
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersDataGridView
            // 
            this.UsersDataGridView.AllowUserToAddRows = false;
            this.UsersDataGridView.AllowUserToDeleteRows = false;
            this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Email});
            this.UsersDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsersDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.UsersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.ReadOnly = true;
            this.UsersDataGridView.RowHeadersVisible = false;
            this.UsersDataGridView.RowTemplate.Height = 25;
            this.UsersDataGridView.Size = new System.Drawing.Size(1029, 474);
            this.UsersDataGridView.TabIndex = 0;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Nome";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Sobrenome";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // CreateButton
            // 
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Location = new System.Drawing.Point(894, 480);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(123, 35);
            this.CreateButton.TabIndex = 5;
            this.CreateButton.Text = "Novo";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 525);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.UsersDataGridView);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários Cadastrados";
            this.Load += new System.EventHandler(this.ListUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView UsersDataGridView;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Email;
        private Button CreateButton;
    }
}