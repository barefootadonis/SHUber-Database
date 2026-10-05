namespace Task_3
{
    partial class Customers
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
            lblCustomers = new Label();
            btnMainMenu = new Button();
            dgvCustomers = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnClear = new Button();
            txtCustomerID = new TextBox();
            txtCustFirstName = new TextBox();
            txtCustLastName = new TextBox();
            txtCustTelNo = new TextBox();
            txtCustEmail = new TextBox();
            lblCustomerID = new Label();
            lblCustFirstName = new Label();
            lblCustLastName = new Label();
            lblCustEmail = new Label();
            lblCustTelNo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // lblCustomers
            // 
            lblCustomers.AutoSize = true;
            lblCustomers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomers.Location = new Point(501, 52);
            lblCustomers.Margin = new Padding(4, 0, 4, 0);
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new Size(135, 32);
            lblCustomers.TabIndex = 0;
            lblCustomers.Text = "Customers";
            lblCustomers.Click += lblCustomers_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Location = new Point(880, 1018);
            btnMainMenu.Margin = new Padding(4, 5, 4, 5);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(146, 38);
            btnMainMenu.TabIndex = 1;
            btnMainMenu.Text = "Main Menu";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(140, 113);
            dgvCustomers.Margin = new Padding(4, 5, 4, 5);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 62;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(801, 328);
            dgvCustomers.TabIndex = 2;
            dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(67, 1018);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(157, 38);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(291, 1018);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(147, 38);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(489, 1018);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(166, 38);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(697, 1018);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 38);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtCustomerID
            // 
            txtCustomerID.BackColor = SystemColors.ControlLightLight;
            txtCustomerID.Enabled = false;
            txtCustomerID.Location = new Point(389, 512);
            txtCustomerID.Margin = new Padding(4, 5, 4, 5);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(580, 31);
            txtCustomerID.TabIndex = 7;
            // 
            // txtCustFirstName
            // 
            txtCustFirstName.Location = new Point(389, 603);
            txtCustFirstName.Margin = new Padding(4, 5, 4, 5);
            txtCustFirstName.Name = "txtCustFirstName";
            txtCustFirstName.Size = new Size(580, 31);
            txtCustFirstName.TabIndex = 8;
            // 
            // txtCustLastName
            // 
            txtCustLastName.Location = new Point(389, 688);
            txtCustLastName.Margin = new Padding(4, 5, 4, 5);
            txtCustLastName.Name = "txtCustLastName";
            txtCustLastName.Size = new Size(580, 31);
            txtCustLastName.TabIndex = 9;
            // 
            // txtCustTelNo
            // 
            txtCustTelNo.Location = new Point(389, 873);
            txtCustTelNo.Margin = new Padding(4, 5, 4, 5);
            txtCustTelNo.Name = "txtCustTelNo";
            txtCustTelNo.Size = new Size(580, 31);
            txtCustTelNo.TabIndex = 10;
            // 
            // txtCustEmail
            // 
            txtCustEmail.Location = new Point(389, 777);
            txtCustEmail.Margin = new Padding(4, 5, 4, 5);
            txtCustEmail.Name = "txtCustEmail";
            txtCustEmail.Size = new Size(580, 31);
            txtCustEmail.TabIndex = 11;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Location = new Point(113, 517);
            lblCustomerID.Margin = new Padding(4, 0, 4, 0);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(116, 25);
            lblCustomerID.TabIndex = 13;
            lblCustomerID.Text = "Customer ID:";
            // 
            // lblCustFirstName
            // 
            lblCustFirstName.AutoSize = true;
            lblCustFirstName.Location = new Point(113, 617);
            lblCustFirstName.Margin = new Padding(4, 0, 4, 0);
            lblCustFirstName.Name = "lblCustFirstName";
            lblCustFirstName.Size = new Size(183, 25);
            lblCustFirstName.TabIndex = 14;
            lblCustFirstName.Text = "Customer First Name:";
            // 
            // lblCustLastName
            // 
            lblCustLastName.AutoSize = true;
            lblCustLastName.Location = new Point(113, 702);
            lblCustLastName.Margin = new Padding(4, 0, 4, 0);
            lblCustLastName.Name = "lblCustLastName";
            lblCustLastName.Size = new Size(181, 25);
            lblCustLastName.TabIndex = 15;
            lblCustLastName.Text = "Customer Last Name:";
            // 
            // lblCustEmail
            // 
            lblCustEmail.AutoSize = true;
            lblCustEmail.Location = new Point(113, 790);
            lblCustEmail.Margin = new Padding(4, 0, 4, 0);
            lblCustEmail.Name = "lblCustEmail";
            lblCustEmail.Size = new Size(140, 25);
            lblCustEmail.TabIndex = 16;
            lblCustEmail.Text = "Customer Email:";
            // 
            // lblCustTelNo
            // 
            lblCustTelNo.AutoSize = true;
            lblCustTelNo.Location = new Point(113, 887);
            lblCustTelNo.Margin = new Padding(4, 0, 4, 0);
            lblCustTelNo.Name = "lblCustTelNo";
            lblCustTelNo.Size = new Size(211, 25);
            lblCustTelNo.TabIndex = 17;
            lblCustTelNo.Text = "Customer Telephone No.:";
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1101, 1050);
            Controls.Add(lblCustTelNo);
            Controls.Add(lblCustEmail);
            Controls.Add(lblCustLastName);
            Controls.Add(lblCustFirstName);
            Controls.Add(lblCustomerID);
            Controls.Add(txtCustEmail);
            Controls.Add(txtCustTelNo);
            Controls.Add(txtCustLastName);
            Controls.Add(txtCustFirstName);
            Controls.Add(txtCustomerID);
            Controls.Add(btnClear);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvCustomers);
            Controls.Add(btnMainMenu);
            Controls.Add(lblCustomers);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Customers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customers";
            Load += Customers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomers;
        private Button btnMainMenu;
        private DataGridView dgvCustomers;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnClear;
        private TextBox txtCustomerID;
        private TextBox txtCustFirstName;
        private TextBox txtCustLastName;
        private TextBox txtCustTelNo;
        private TextBox txtCustEmail;
        private Label lblCustomerID;
        private Label lblCustFirstName;
        private Label lblCustLastName;
        private Label lblCustEmail;
        private Label lblCustTelNo;
    }
}