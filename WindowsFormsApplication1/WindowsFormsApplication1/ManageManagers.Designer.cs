namespace WindowsFormsApplication1
{
    partial class ManageManagers
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
            this.txtloginnewname = new System.Windows.Forms.TextBox();
            this.txtloginnewpass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtverifypass = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtloginnewname
            // 
            this.txtloginnewname.Location = new System.Drawing.Point(467, 86);
            this.txtloginnewname.Name = "txtloginnewname";
            this.txtloginnewname.Size = new System.Drawing.Size(186, 45);
            this.txtloginnewname.TabIndex = 1;
            // 
            // txtloginnewpass
            // 
            this.txtloginnewpass.Location = new System.Drawing.Point(467, 144);
            this.txtloginnewpass.Name = "txtloginnewpass";
            this.txtloginnewpass.Size = new System.Drawing.Size(186, 45);
            this.txtloginnewpass.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(395, 39);
            this.label8.TabIndex = 9;
            this.label8.Text = "New Manager Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 39);
            this.label7.TabIndex = 10;
            this.label7.Text = "Set Password";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(200, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(453, 68);
            this.button2.TabIndex = 4;
            this.button2.Text = "Create New Manager";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtverifypass);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtloginnewpass);
            this.groupBox1.Controls.Add(this.txtloginnewname);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(51, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 505);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New Manager";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 39);
            this.label5.TabIndex = 15;
            this.label5.Text = "Verify Password";
            // 
            // txtverifypass
            // 
            this.txtverifypass.Location = new System.Drawing.Point(467, 205);
            this.txtverifypass.Name = "txtverifypass";
            this.txtverifypass.Size = new System.Drawing.Size(186, 45);
            this.txtverifypass.TabIndex = 3;
            // 
            // ManageManagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 658);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageManagers";
            this.Text = "Manage Managers";
            this.Load += new System.EventHandler(this.ManageManagers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtloginnewname;
        private System.Windows.Forms.TextBox txtloginnewpass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtverifypass;
    }
}