namespace WindowsFormsApplication1
{
    partial class AddPatron
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.iDNumberBox = new System.Windows.Forms.TextBox();
            this.lNameBox = new System.Windows.Forms.TextBox();
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkClimb = new System.Windows.Forms.CheckBox();
            this.checkBelay = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBelay);
            this.groupBox1.Controls.Add(this.checkClimb);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.iDNumberBox);
            this.groupBox1.Controls.Add(this.lNameBox);
            this.groupBox1.Controls.Add(this.fNameBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 457);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Patron";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(66, 381);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 53);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Patron";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // iDNumberBox
            // 
            this.iDNumberBox.Location = new System.Drawing.Point(145, 137);
            this.iDNumberBox.Name = "iDNumberBox";
            this.iDNumberBox.Size = new System.Drawing.Size(155, 29);
            this.iDNumberBox.TabIndex = 5;
            // 
            // lNameBox
            // 
            this.lNameBox.Location = new System.Drawing.Point(145, 92);
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.Size = new System.Drawing.Size(155, 29);
            this.lNameBox.TabIndex = 4;
            // 
            // fNameBox
            // 
            this.fNameBox.Location = new System.Drawing.Point(145, 50);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(155, 29);
            this.fNameBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name:";
            // 
            // checkClimb
            // 
            this.checkClimb.AutoSize = true;
            this.checkClimb.Location = new System.Drawing.Point(30, 230);
            this.checkClimb.Name = "checkClimb";
            this.checkClimb.Size = new System.Drawing.Size(133, 29);
            this.checkClimb.TabIndex = 7;
            this.checkClimb.Text = "Free Climb";
            this.checkClimb.UseVisualStyleBackColor = true;
            // 
            // checkBelay
            // 
            this.checkBelay.AutoSize = true;
            this.checkBelay.Location = new System.Drawing.Point(30, 183);
            this.checkBelay.Name = "checkBelay";
            this.checkBelay.Size = new System.Drawing.Size(92, 29);
            this.checkBelay.TabIndex = 8;
            this.checkBelay.Text = "Belay ";
            this.checkBelay.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // AddPatron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddPatron";
            this.Text = "AddPatron";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox iDNumberBox;
        private System.Windows.Forms.TextBox lNameBox;
        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBelay;
        private System.Windows.Forms.CheckBox checkClimb;
        private System.Windows.Forms.Label label1;
    }
}