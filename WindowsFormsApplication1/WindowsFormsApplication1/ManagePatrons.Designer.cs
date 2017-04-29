namespace WindowsFormsApplication1
{
    partial class ManagePatrons
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
            this.searchButton = new System.Windows.Forms.Button();
            this.iDNumberBox = new System.Windows.Forms.TextBox();
            this.lNameBox = new System.Windows.Forms.TextBox();
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastVisit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hasincident = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClrIncidents = new System.Windows.Forms.Button();
            this.btnDeletePatron = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtincedent = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblsuspstatus = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.suspendTime = new System.Windows.Forms.DateTimePicker();
            this.btnSuspend = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.iDNumberBox);
            this.groupBox1.Controls.Add(this.lNameBox);
            this.groupBox1.Controls.Add(this.fNameBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 394);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for Patron";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(62, 261);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(226, 53);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // iDNumberBox
            // 
            this.iDNumberBox.Location = new System.Drawing.Point(190, 192);
            this.iDNumberBox.Name = "iDNumberBox";
            this.iDNumberBox.Size = new System.Drawing.Size(155, 39);
            this.iDNumberBox.TabIndex = 5;
            // 
            // lNameBox
            // 
            this.lNameBox.Location = new System.Drawing.Point(190, 127);
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.Size = new System.Drawing.Size(155, 39);
            this.lNameBox.TabIndex = 4;
            // 
            // fNameBox
            // 
            this.fNameBox.Location = new System.Drawing.Point(190, 59);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(155, 39);
            this.fNameBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.LastVisit,
            this.columnHeader4,
            this.hasincident});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(533, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1640, 718);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "First Name";
            this.columnHeader1.Width = 218;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last Name";
            this.columnHeader2.Width = 199;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID Number";
            this.columnHeader3.Width = 206;
            // 
            // LastVisit
            // 
            this.LastVisit.Text = "Belay";
            this.LastVisit.Width = 142;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "FreeClimb";
            this.columnHeader4.Width = 192;
            // 
            // hasincident
            // 
            this.hasincident.Text = "Incident";
            this.hasincident.Width = 275;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Selected User:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "None";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClrIncidents);
            this.groupBox2.Controls.Add(this.btnDeletePatron);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 497);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 408);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Patron";
            // 
            // btnClrIncidents
            // 
            this.btnClrIncidents.Location = new System.Drawing.Point(41, 312);
            this.btnClrIncidents.Name = "btnClrIncidents";
            this.btnClrIncidents.Size = new System.Drawing.Size(279, 48);
            this.btnClrIncidents.TabIndex = 8;
            this.btnClrIncidents.Text = "Clear Incident Reports";
            this.btnClrIncidents.UseVisualStyleBackColor = true;
            this.btnClrIncidents.Click += new System.EventHandler(this.btnClrIncidents_Click);
            // 
            // btnDeletePatron
            // 
            this.btnDeletePatron.Location = new System.Drawing.Point(47, 229);
            this.btnDeletePatron.Name = "btnDeletePatron";
            this.btnDeletePatron.Size = new System.Drawing.Size(273, 48);
            this.btnDeletePatron.TabIndex = 7;
            this.btnDeletePatron.Text = "Delete Patron";
            this.btnDeletePatron.UseVisualStyleBackColor = true;
            this.btnDeletePatron.Click += new System.EventHandler(this.btnDeletePatron_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtincedent);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(427, 775);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(868, 392);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Incident Report";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(181, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 32);
            this.label13.TabIndex = 12;
            this.label13.Text = "None";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 32);
            this.label12.TabIndex = 11;
            this.label12.Text = "ID #";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(425, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(304, 66);
            this.button2.TabIndex = 10;
            this.button2.Text = "Submit Incident Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(381, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(445, 32);
            this.label11.TabIndex = 9;
            this.label11.Text = "Explain the Incident(include date):\r\n";
            // 
            // txtincedent
            // 
            this.txtincedent.Location = new System.Drawing.Point(385, 77);
            this.txtincedent.Multiline = true;
            this.txtincedent.Name = "txtincedent";
            this.txtincedent.Size = new System.Drawing.Size(441, 197);
            this.txtincedent.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(180, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 32);
            this.label10.TabIndex = 3;
            this.label10.Text = "None";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 32);
            this.label9.TabIndex = 2;
            this.label9.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "None";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "First Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblsuspstatus);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.lbldate);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.suspendTime);
            this.groupBox4.Controls.Add(this.btnSuspend);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(1334, 801);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(839, 317);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Suspend Patron";
            // 
            // lblsuspstatus
            // 
            this.lblsuspstatus.AutoSize = true;
            this.lblsuspstatus.Location = new System.Drawing.Point(295, 51);
            this.lblsuspstatus.Name = "lblsuspstatus";
            this.lblsuspstatus.Size = new System.Drawing.Size(161, 32);
            this.lblsuspstatus.TabIndex = 16;
            this.lblsuspstatus.Text = "Select User";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(268, 32);
            this.label16.TabIndex = 15;
            this.label16.Text = "Suspension Status: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(201, 32);
            this.label15.TabIndex = 14;
            this.label15.Text = "Suspend Until:";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(295, 99);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(154, 32);
            this.lbldate.TabIndex = 13;
            this.lbldate.Text = "-Curr Date-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(183, 32);
            this.label14.TabIndex = 12;
            this.label14.Text = "Todays Date:";
            // 
            // suspendTime
            // 
            this.suspendTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.suspendTime.Location = new System.Drawing.Point(288, 147);
            this.suspendTime.Name = "suspendTime";
            this.suspendTime.Size = new System.Drawing.Size(356, 39);
            this.suspendTime.TabIndex = 11;
            // 
            // btnSuspend
            // 
            this.btnSuspend.Enabled = false;
            this.btnSuspend.Location = new System.Drawing.Point(195, 225);
            this.btnSuspend.Name = "btnSuspend";
            this.btnSuspend.Size = new System.Drawing.Size(285, 68);
            this.btnSuspend.TabIndex = 10;
            this.btnSuspend.Text = "Suspend Patron";
            this.btnSuspend.UseVisualStyleBackColor = true;
            this.btnSuspend.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(176, 99);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 32);
            this.label19.TabIndex = 1;
            // 
            // ManagePatrons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2259, 1215);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ManagePatrons";
            this.Text = "Manage Patrons";
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox iDNumberBox;
        private System.Windows.Forms.TextBox lNameBox;
        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader LastVisit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtincedent;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ColumnHeader hasincident;
        private System.Windows.Forms.Button btnDeletePatron;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker suspendTime;
        private System.Windows.Forms.Button btnSuspend;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblsuspstatus;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnClrIncidents;
    }
}