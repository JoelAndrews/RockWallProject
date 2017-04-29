namespace WindowsFormsApplication1
{
    partial class ManageEmployees
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtverifypass = new System.Windows.Forms.TextBox();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtloginnewpass = new System.Windows.Forms.TextBox();
            this.txtloginnewname = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtverifypass);
            this.groupBox1.Controls.Add(this.btnCreateEmployee);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtloginnewpass);
            this.groupBox1.Controls.Add(this.txtloginnewname);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1063, 441);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New Employee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Verify Password";
            // 
            // txtverifypass
            // 
            this.txtverifypass.Location = new System.Drawing.Point(436, 236);
            this.txtverifypass.Name = "txtverifypass";
            this.txtverifypass.Size = new System.Drawing.Size(385, 39);
            this.txtverifypass.TabIndex = 3;
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Location = new System.Drawing.Point(304, 326);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(389, 57);
            this.btnCreateEmployee.TabIndex = 4;
            this.btnCreateEmployee.Text = "Create New Employee";
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 32);
            this.label7.TabIndex = 10;
            this.label7.Text = "Set Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(342, 32);
            this.label8.TabIndex = 9;
            this.label8.Text = "New Employee Username";
            // 
            // txtloginnewpass
            // 
            this.txtloginnewpass.Location = new System.Drawing.Point(436, 170);
            this.txtloginnewpass.Name = "txtloginnewpass";
            this.txtloginnewpass.Size = new System.Drawing.Size(385, 39);
            this.txtloginnewpass.TabIndex = 2;
            // 
            // txtloginnewname
            // 
            this.txtloginnewname.Location = new System.Drawing.Point(436, 100);
            this.txtloginnewname.Name = "txtloginnewname";
            this.txtloginnewname.Size = new System.Drawing.Size(385, 39);
            this.txtloginnewname.TabIndex = 1;
            // 
            // ManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 776);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ManageEmployees";
            this.Text = "Manage Employees";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtverifypass;
        private System.Windows.Forms.Button btnCreateEmployee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtloginnewpass;
        private System.Windows.Forms.TextBox txtloginnewname;
    }
}