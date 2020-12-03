namespace Praktika
{
    partial class LoginA
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
            this.ALU = new System.Windows.Forms.TextBox();
            this.ALP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Studentlogin = new System.Windows.Forms.Button();
            this.spassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.susername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // ALU
            // 
            this.ALU.Location = new System.Drawing.Point(53, 96);
            this.ALU.Name = "ALU";
            this.ALU.Size = new System.Drawing.Size(232, 22);
            this.ALU.TabIndex = 1;
            // 
            // ALP
            // 
            this.ALP.Location = new System.Drawing.Point(53, 144);
            this.ALP.Name = "ALP";
            this.ALP.Size = new System.Drawing.Size(232, 22);
            this.ALP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Studentlogin
            // 
            this.Studentlogin.Location = new System.Drawing.Point(486, 183);
            this.Studentlogin.Name = "Studentlogin";
            this.Studentlogin.Size = new System.Drawing.Size(127, 36);
            this.Studentlogin.TabIndex = 9;
            this.Studentlogin.Text = "Login";
            this.Studentlogin.UseVisualStyleBackColor = true;
            this.Studentlogin.Click += new System.EventHandler(this.Studentlogin_Click);
            // 
            // spassword
            // 
            this.spassword.Location = new System.Drawing.Point(438, 144);
            this.spassword.Name = "spassword";
            this.spassword.Size = new System.Drawing.Size(232, 22);
            this.spassword.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // susername
            // 
            this.susername.Location = new System.Drawing.Point(438, 96);
            this.susername.Name = "susername";
            this.susername.Size = new System.Drawing.Size(232, 22);
            this.susername.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "admin/destytojam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Studentam";
            // 
            // LoginA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Studentlogin);
            this.Controls.Add(this.spassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.susername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ALP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ALU);
            this.Controls.Add(this.label1);
            this.Name = "LoginA";
            this.Text = "LoginA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ALU;
        private System.Windows.Forms.TextBox ALP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Studentlogin;
        private System.Windows.Forms.TextBox spassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox susername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}