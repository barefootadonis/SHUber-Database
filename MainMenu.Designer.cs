namespace Task_3
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnCustomers = new Button();
            btnDrivers = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(328, 51);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(97, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Main Menu";
            // 
            // btnCustomers
            // 
            btnCustomers.Location = new Point(186, 187);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(125, 33);
            btnCustomers.TabIndex = 1;
            btnCustomers.Text = "Manage Customers";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnDrivers
            // 
            btnDrivers.Location = new Point(445, 187);
            btnDrivers.Name = "btnDrivers";
            btnDrivers.Size = new Size(125, 33);
            btnDrivers.TabIndex = 2;
            btnDrivers.Text = "Manage Drivers";
            btnDrivers.UseVisualStyleBackColor = true;
            btnDrivers.Click += btnDrivers_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDrivers);
            Controls.Add(btnCustomers);
            Controls.Add(lblTitle);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnCustomers;
        private Button btnDrivers;
    }
}
