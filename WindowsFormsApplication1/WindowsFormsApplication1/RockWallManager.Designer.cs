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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generateReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePatronsStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeesStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.manageManagersStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateReportsToolStripMenuItem,
            this.managePatronsStripMenu,
            this.manageEmployeesStripMenu,
            this.manageManagersStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1215, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generateReportsToolStripMenuItem
            // 
            this.generateReportsToolStripMenuItem.Name = "generateReportsToolStripMenuItem";
            this.generateReportsToolStripMenuItem.Size = new System.Drawing.Size(211, 36);
            this.generateReportsToolStripMenuItem.Text = "Generate Reports";
            this.generateReportsToolStripMenuItem.Click += new System.EventHandler(this.generateReportsToolStripMenuItem_Click);
            // 
            // managePatronsStripMenu
            // 
            this.managePatronsStripMenu.Name = "managePatronsStripMenu";
            this.managePatronsStripMenu.Size = new System.Drawing.Size(199, 36);
            this.managePatronsStripMenu.Text = "Manage Patrons";
            this.managePatronsStripMenu.Click += new System.EventHandler(this.managePatronsStripMenu_Click);
            // 
            // manageEmployeesStripMenu
            // 
            this.manageEmployeesStripMenu.Name = "manageEmployeesStripMenu";
            this.manageEmployeesStripMenu.Size = new System.Drawing.Size(236, 36);
            this.manageEmployeesStripMenu.Text = "Manage Employees";
            this.manageEmployeesStripMenu.Click += new System.EventHandler(this.manageEmployeesStripMenu_Click);
            // 
            // manageManagersStripMenu
            // 
            this.manageManagersStripMenu.Name = "manageManagersStripMenu";
            this.manageManagersStripMenu.Size = new System.Drawing.Size(226, 36);
            this.manageManagersStripMenu.Text = "Manage Managers";
            this.manageManagersStripMenu.Click += new System.EventHandler(this.manageManagersStripMenu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rock Wall Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "20";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "12/2/2016";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patron Visits Today:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todays Date:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(578, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 283);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(54, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(321, 60);
            this.button3.TabIndex = 0;
            this.button3.Text = "Issue Certificate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(321, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "Issue Incident Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1069, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "LogOut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RockWallManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RockWallManager";
            this.Text = "Rock Wall Manager Pro - Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generateReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeesStripMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem managePatronsStripMenu;
        private System.Windows.Forms.ToolStripMenuItem manageManagersStripMenu;
        private System.Windows.Forms.Button button1;
    }
}