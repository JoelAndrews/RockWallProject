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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFreeClimb = new System.Windows.Forms.Label();
            this.lblBelay = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.id_box);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 263);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for Patron";
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(256, 61);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(192, 45);
            this.id_box.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patron ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblBelay);
            this.groupBox2.Controls.Add(this.lblFreeClimb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lNameBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.fNameBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(877, 237);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // freeclimbbox
            // 
            this.freeclimbbox.AutoSize = true;
            this.freeclimbbox.Enabled = false;
            this.freeclimbbox.Location = new System.Drawing.Point(886, 132);
            this.freeclimbbox.Name = "freeclimbbox";
            this.freeclimbbox.Size = new System.Drawing.Size(133, 29);
            this.freeclimbbox.TabIndex = 7;
            this.freeclimbbox.Text = "Free Climb";
            this.freeclimbbox.UseVisualStyleBackColor = true;
            this.freeclimbbox.Visible = false;
            // 
            // belayBox
            // 
            this.belayBox.AutoSize = true;
            this.belayBox.Enabled = false;
            this.belayBox.Location = new System.Drawing.Point(1017, 96);
            this.belayBox.Name = "belayBox";
            this.belayBox.Size = new System.Drawing.Size(92, 29);
            this.belayBox.TabIndex = 6;
            this.belayBox.Text = "Belay ";
            this.belayBox.UseVisualStyleBackColor = true;
            this.belayBox.Visible = false;
            // 
            // lNameBox
            // 
            this.lNameBox.Enabled = false;
            this.lNameBox.Location = new System.Drawing.Point(206, 131);
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.ReadOnly = true;
            this.lNameBox.Size = new System.Drawing.Size(192, 39);
            this.lNameBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Last Name";
            // 
            // fNameBox
            // 
            this.fNameBox.Enabled = false;
            this.fNameBox.Location = new System.Drawing.Point(206, 66);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.ReadOnly = true;
            this.fNameBox.Size = new System.Drawing.Size(192, 39);
            this.fNameBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.belayCertButton);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(23, 591);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(488, 207);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Belay";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // belayCertButton
            // 
            this.belayCertButton.AutoSize = true;
            this.belayCertButton.Enabled = false;
            this.belayCertButton.Location = new System.Drawing.Point(77, 74);
            this.belayCertButton.Name = "belayCertButton";
            this.belayCertButton.Size = new System.Drawing.Size(363, 80);
            this.belayCertButton.TabIndex = 0;
            this.belayCertButton.Text = "Change Belay Certification";
            this.belayCertButton.UseVisualStyleBackColor = true;
            this.belayCertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.freeClimbButton);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(564, 591);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(507, 207);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Free Climb";
            // 
            // freeClimbButton
            // 
            this.freeClimbButton.AutoSize = true;
            this.freeClimbButton.Enabled = false;
            this.freeClimbButton.Location = new System.Drawing.Point(16, 74);
            this.freeClimbButton.Name = "freeClimbButton";
            this.freeClimbButton.Size = new System.Drawing.Size(457, 90);
            this.freeClimbButton.TabIndex = 0;
            this.freeClimbButton.Text = "Change Free Climb Certification";
            this.freeClimbButton.UseVisualStyleBackColor = true;
            this.freeClimbButton.Click += new System.EventHandler(this.freeClimbButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(167, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Free Climb:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Belay:";
            // 
            // lblFreeClimb
            // 
            this.lblFreeClimb.AutoSize = true;
            this.lblFreeClimb.Location = new System.Drawing.Point(656, 66);
            this.lblFreeClimb.Name = "lblFreeClimb";
            this.lblFreeClimb.Size = new System.Drawing.Size(0, 32);
            this.lblFreeClimb.TabIndex = 8;
            // 
            // lblBelay
            // 
            this.lblBelay.AutoSize = true;
            this.lblBelay.Location = new System.Drawing.Point(656, 118);
            this.lblBelay.Name = "lblBelay";
            this.lblBelay.Size = new System.Drawing.Size(0, 32);
            this.lblBelay.TabIndex = 8;
            // 
            // IssueCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 874);
            this.Controls.Add(this.freeclimbbox);
            this.Controls.Add(this.belayBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "IssueCertificate";
            this.Text = "IssueCertificate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblBelay;
        private System.Windows.Forms.Label lblFreeClimb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}