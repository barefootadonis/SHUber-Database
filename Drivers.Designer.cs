namespace Task_3
{
    partial class Drivers
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
            lbDrivers = new Label();
            btnMainMenu = new Button();
            dgvDrivers = new DataGridView();
            lblDriTelNo = new Label();
            lblDriEmail = new Label();
            lblDriLastName = new Label();
            lblDriFirstName = new Label();
            lblDriverID = new Label();
            txtDriEmail = new TextBox();
            txtDriTelNo = new TextBox();
            txtDriLastName = new TextBox();
            txtDriFirstName = new TextBox();
            txtDriverID = new TextBox();
            btnClear = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).BeginInit();
            SuspendLayout();
            // 
            // lbDrivers
            // 
            lbDrivers.AutoSize = true;
            lbDrivers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDrivers.Location = new Point(500, 70);
            lbDrivers.Margin = new Padding(4, 0, 4, 0);
            lbDrivers.Name = "lbDrivers";
            lbDrivers.Size = new Size(96, 32);
            lbDrivers.TabIndex = 0;
            lbDrivers.Text = "Drivers";
            // 
            // btnMainMenu
            // 
            btnMainMenu.Location = new Point(896, 1000);
            btnMainMenu.Margin = new Padding(4, 5, 4, 5);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(133, 38);
            btnMainMenu.TabIndex = 1;
            btnMainMenu.Text = "Main Menu";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // dgvDrivers
            // 
            dgvDrivers.AllowUserToAddRows = false;
            dgvDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrivers.Location = new Point(94, 128);
            dgvDrivers.Margin = new Padding(4, 5, 4, 5);
            dgvDrivers.MultiSelect = false;
            dgvDrivers.Name = "dgvDrivers";
            dgvDrivers.ReadOnly = true;
            dgvDrivers.RowHeadersWidth = 62;
            dgvDrivers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrivers.Size = new Size(934, 372);
            dgvDrivers.TabIndex = 2;
            dgvDrivers.CellContentClick += dgvDrivers_CellContentClick;
            // 
            // lblDriTelNo
            // 
            lblDriTelNo.AutoSize = true;
            lblDriTelNo.Location = new Point(130, 907);
            lblDriTelNo.Margin = new Padding(4, 0, 4, 0);
            lblDriTelNo.Name = "lblDriTelNo";
            lblDriTelNo.Size = new Size(181, 25);
            lblDriTelNo.TabIndex = 27;
            lblDriTelNo.Text = "Driver Telephone No.:";
            // 
            // lblDriEmail
            // 
            lblDriEmail.AutoSize = true;
            lblDriEmail.Location = new Point(130, 810);
            lblDriEmail.Margin = new Padding(4, 0, 4, 0);
            lblDriEmail.Name = "lblDriEmail";
            lblDriEmail.Size = new Size(110, 25);
            lblDriEmail.TabIndex = 26;
            lblDriEmail.Text = "Driver Email:";
            // 
            // lblDriLastName
            // 
            lblDriLastName.AutoSize = true;
            lblDriLastName.Location = new Point(130, 722);
            lblDriLastName.Margin = new Padding(4, 0, 4, 0);
            lblDriLastName.Name = "lblDriLastName";
            lblDriLastName.Size = new Size(151, 25);
            lblDriLastName.TabIndex = 25;
            lblDriLastName.Text = "Driver Last Name:";
            // 
            // lblDriFirstName
            // 
            lblDriFirstName.AutoSize = true;
            lblDriFirstName.Location = new Point(130, 637);
            lblDriFirstName.Margin = new Padding(4, 0, 4, 0);
            lblDriFirstName.Name = "lblDriFirstName";
            lblDriFirstName.Size = new Size(153, 25);
            lblDriFirstName.TabIndex = 24;
            lblDriFirstName.Text = "Driver First Name:";
            // 
            // lblDriverID
            // 
            lblDriverID.AutoSize = true;
            lblDriverID.Location = new Point(130, 537);
            lblDriverID.Margin = new Padding(4, 0, 4, 0);
            lblDriverID.Name = "lblDriverID";
            lblDriverID.Size = new Size(86, 25);
            lblDriverID.TabIndex = 23;
            lblDriverID.Text = "Driver ID:";
            // 
            // txtDriEmail
            // 
            txtDriEmail.Location = new Point(406, 797);
            txtDriEmail.Margin = new Padding(4, 5, 4, 5);
            txtDriEmail.Name = "txtDriEmail";
            txtDriEmail.Size = new Size(580, 31);
            txtDriEmail.TabIndex = 22;
            // 
            // txtDriTelNo
            // 
            txtDriTelNo.Location = new Point(406, 893);
            txtDriTelNo.Margin = new Padding(4, 5, 4, 5);
            txtDriTelNo.Name = "txtDriTelNo";
            txtDriTelNo.Size = new Size(580, 31);
            txtDriTelNo.TabIndex = 21;
            // 
            // txtDriLastName
            // 
            txtDriLastName.Location = new Point(406, 708);
            txtDriLastName.Margin = new Padding(4, 5, 4, 5);
            txtDriLastName.Name = "txtDriLastName";
            txtDriLastName.Size = new Size(580, 31);
            txtDriLastName.TabIndex = 20;
            // 
            // txtDriFirstName
            // 
            txtDriFirstName.Location = new Point(406, 623);
            txtDriFirstName.Margin = new Padding(4, 5, 4, 5);
            txtDriFirstName.Name = "txtDriFirstName";
            txtDriFirstName.Size = new Size(580, 31);
            txtDriFirstName.TabIndex = 19;
            // 
            // txtDriverID
            // 
            txtDriverID.BackColor = SystemColors.ControlLightLight;
            txtDriverID.Enabled = false;
            txtDriverID.Location = new Point(406, 532);
            txtDriverID.Margin = new Padding(4, 5, 4, 5);
            txtDriverID.Name = "txtDriverID";
            txtDriverID.Size = new Size(580, 31);
            txtDriverID.TabIndex = 18;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(717, 1000);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 38);
            btnClear.TabIndex = 31;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(509, 1000);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(166, 38);
            btnEdit.TabIndex = 30;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(311, 1000);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(147, 38);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(87, 1000);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(157, 38);
            btnAdd.TabIndex = 28;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Drivers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1143, 1050);
            Controls.Add(btnClear);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lblDriTelNo);
            Controls.Add(lblDriEmail);
            Controls.Add(lblDriLastName);
            Controls.Add(lblDriFirstName);
            Controls.Add(lblDriverID);
            Controls.Add(txtDriEmail);
            Controls.Add(txtDriTelNo);
            Controls.Add(txtDriLastName);
            Controls.Add(txtDriFirstName);
            Controls.Add(txtDriverID);
            Controls.Add(dgvDrivers);
            Controls.Add(btnMainMenu);
            Controls.Add(lbDrivers);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Drivers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Drivers";
            Load += Drivers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDrivers;
        private Button btnMainMenu;
        private DataGridView dgvDrivers;
        private Label lblDriTelNo;
        private Label lblDriEmail;
        private Label lblDriLastName;
        private Label lblDriFirstName;
        private Label lblDriverID;
        private TextBox txtDriEmail;
        private TextBox txtDriTelNo;
        private TextBox txtDriLastName;
        private TextBox txtDriFirstName;
        private TextBox txtDriverID;
        private Button btnClear;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
    }
}