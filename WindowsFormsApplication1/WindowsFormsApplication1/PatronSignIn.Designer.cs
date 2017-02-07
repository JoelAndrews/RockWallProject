namespace WindowsFormsApplication1
{
    partial class PatronSignIn
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(388, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 31);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "Log-In";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(788, 60);
            this.label2.TabIndex = 3;
            this.label2.Text = "-This textbox will display Success or Failure-";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update Profile";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PatronSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 631);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "PatronSignIn";
            this.Text = "PatronSignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}