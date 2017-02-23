namespace WindowsFormsApplication1
{
    partial class IssueCertificate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.freeclimbbox = new System.Windows.Forms.CheckBox();
            this.belayBox = new System.Windows.Forms.CheckBox();
            this.lNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.belayCertButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.freeClimbButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.id_box);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for Patron";
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(160, 41);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(209, 31);
            this.id_box.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patron ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.freeclimbbox);
            this.groupBox2.Controls.Add(this.belayBox);
            this.groupBox2.Controls.Add(this.lNameBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.fNameBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(25, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 180);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patron Found";
            // 
            // freeclimbbox
            // 
            this.freeclimbbox.AutoSize = true;
            this.freeclimbbox.Location = new System.Drawing.Point(411, 90);
            this.freeclimbbox.Name = "freeclimbbox";
            this.freeclimbbox.Size = new System.Drawing.Size(148, 29);
            this.freeclimbbox.TabIndex = 7;
            this.freeclimbbox.Text = "Free Climb";
            this.freeclimbbox.UseVisualStyleBackColor = true;
            // 
            // belayBox
            // 
            this.belayBox.AutoSize = true;
            this.belayBox.Location = new System.Drawing.Point(411, 40);
            this.belayBox.Name = "belayBox";
            this.belayBox.Size = new System.Drawing.Size(104, 29);
            this.belayBox.TabIndex = 6;
            this.belayBox.Text = "Belay ";
            this.belayBox.UseVisualStyleBackColor = true;
            // 
            // lNameBox
            // 
            this.lNameBox.Enabled = false;
            this.lNameBox.Location = new System.Drawing.Point(160, 87);
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.ReadOnly = true;
            this.lNameBox.Size = new System.Drawing.Size(209, 31);
            this.lNameBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Last Name";
            // 
            // fNameBox
            // 
            this.fNameBox.Enabled = false;
            this.fNameBox.Location = new System.Drawing.Point(160, 41);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.ReadOnly = true;
            this.fNameBox.Size = new System.Drawing.Size(209, 31);
            this.fNameBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.belayCertButton);
            this.groupBox3.Location = new System.Drawing.Point(35, 420);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 216);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Belay";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // belayCertButton
            // 
            this.belayCertButton.Enabled = false;
            this.belayCertButton.Location = new System.Drawing.Point(30, 77);
            this.belayCertButton.Name = "belayCertButton";
            this.belayCertButton.Size = new System.Drawing.Size(211, 62);
            this.belayCertButton.TabIndex = 0;
            this.belayCertButton.Text = "Change Belay Certification";
            this.belayCertButton.UseVisualStyleBackColor = true;
            this.belayCertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.freeClimbButton);
            this.groupBox4.Location = new System.Drawing.Point(419, 420);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(308, 216);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Free Climb";
            // 
            // freeClimbButton
            // 
            this.freeClimbButton.Enabled = false;
            this.freeClimbButton.Location = new System.Drawing.Point(17, 77);
            this.freeClimbButton.Name = "freeClimbButton";
            this.freeClimbButton.Size = new System.Drawing.Size(211, 62);
            this.freeClimbButton.TabIndex = 0;
            this.freeClimbButton.Text = "Change Free Climb Certification";
            this.freeClimbButton.UseVisualStyleBackColor = true;
            this.freeClimbButton.Click += new System.EventHandler(this.freeClimbButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(520, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 42);
            this.button3.TabIndex = 7;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // IssueCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 682);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "IssueCertificate";
            this.Text = "IssueCertificate";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox freeclimbbox;
        private System.Windows.Forms.CheckBox belayBox;
        private System.Windows.Forms.TextBox lNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button belayCertButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button freeClimbButton;
        private System.Windows.Forms.Button button3;
    }
}