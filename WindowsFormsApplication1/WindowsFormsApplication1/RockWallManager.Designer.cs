namespace WindowsFormsApplication1
{
    partial class RockWallManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RockWallManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generateReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePatronsStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeesStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.manageManagersStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAdminsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVisitors = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateReportsToolStripMenuItem,
            this.managePatronsStripMenu,
            this.manageEmployeesStripMenu,
            this.manageManagersStripMenu,
            this.manageAdminsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1766, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generateReportsToolStripMenuItem
            // 
            this.generateReportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.generateReportsToolStripMenuItem.Name = "generateReportsToolStripMenuItem";
            this.generateReportsToolStripMenuItem.Size = new System.Drawing.Size(244, 42);
            this.generateReportsToolStripMenuItem.Text = "Generate Reports";
            this.generateReportsToolStripMenuItem.Click += new System.EventHandler(this.generateReportsToolStripMenuItem_Click);
            // 
            // managePatronsStripMenu
            // 
            this.managePatronsStripMenu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.managePatronsStripMenu.Name = "managePatronsStripMenu";
            this.managePatronsStripMenu.Size = new System.Drawing.Size(229, 42);
            this.managePatronsStripMenu.Text = "Manage Patrons";
            this.managePatronsStripMenu.Click += new System.EventHandler(this.managePatronsStripMenu_Click);
            // 
            // manageEmployeesStripMenu
            // 
            this.manageEmployeesStripMenu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.manageEmployeesStripMenu.Name = "manageEmployeesStripMenu";
            this.manageEmployeesStripMenu.Size = new System.Drawing.Size(270, 42);
            this.manageEmployeesStripMenu.Text = "Manage Employees";
            this.manageEmployeesStripMenu.Click += new System.EventHandler(this.manageEmployeesStripMenu_Click);
            // 
            // manageManagersStripMenu
            // 
            this.manageManagersStripMenu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.manageManagersStripMenu.Name = "manageManagersStripMenu";
            this.manageManagersStripMenu.Size = new System.Drawing.Size(259, 42);
            this.manageManagersStripMenu.Text = "Manage Managers";
            this.manageManagersStripMenu.Click += new System.EventHandler(this.manageManagersStripMenu_Click);
            // 
            // manageAdminsToolStripMenuItem
            // 
            this.manageAdminsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.manageAdminsToolStripMenuItem.Name = "manageAdminsToolStripMenuItem";
            this.manageAdminsToolStripMenuItem.Size = new System.Drawing.Size(230, 42);
            this.manageAdminsToolStripMenuItem.Text = "Manage Admins";
            this.manageAdminsToolStripMenuItem.Click += new System.EventHandler(this.manageAdminsToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblVisitors);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(624, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 249);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rock Wall Status";
            // 
            // lblVisitors
            // 
            this.lblVisitors.AutoSize = true;
            this.lblVisitors.Location = new System.Drawing.Point(226, 141);
            this.lblVisitors.Name = "lblVisitors";
            this.lblVisitors.Size = new System.Drawing.Size(97, 32);
            this.lblVisitors.TabIndex = 3;
            this.lblVisitors.Text = "-visits-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Visits Today:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(226, 81);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(141, 32);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "datetoday";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todays Date:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnBackup);
            this.groupBox2.Controls.Add(this.btnChangePassword);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(41, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 614);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(443, 78);
            this.button2.TabIndex = 4;
            this.button2.Text = "Display IP Address";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(50, 289);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(443, 78);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "Backup Database";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(50, 72);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(443, 67);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(50, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(443, 78);
            this.button3.TabIndex = 2;
            this.button3.Text = "Issue Certificate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(50, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(443, 73);
            this.button1.TabIndex = 5;
            this.button1.Text = "LogOut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1110, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 614);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // RockWallManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1766, 774);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1790, 838);
            this.Name = "RockWallManager";
            this.Text = "Rock Wall Manager Pro - Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generateReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeesStripMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem managePatronsStripMenu;
        private System.Windows.Forms.ToolStripMenuItem manageManagersStripMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem manageAdminsToolStripMenuItem;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblVisitors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}