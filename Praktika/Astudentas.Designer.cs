namespace Praktika
{
    partial class Astudentas
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
            this.Afirstname = new System.Windows.Forms.TextBox();
            this.asdasdsadasd = new System.Windows.Forms.Label();
            this.Asurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Afirstname
            // 
            this.Afirstname.Location = new System.Drawing.Point(79, 84);
            this.Afirstname.Name = "Afirstname";
            this.Afirstname.Size = new System.Drawing.Size(162, 22);
            this.Afirstname.TabIndex = 5;
            // 
            // asdasdsadasd
            // 
            this.asdasdsadasd.AutoSize = true;
            this.asdasdsadasd.Location = new System.Drawing.Point(76, 64);
            this.asdasdsadasd.Name = "asdasdsadasd";
            this.asdasdsadasd.Size = new System.Drawing.Size(70, 17);
            this.asdasdsadasd.TabIndex = 4;
            this.asdasdsadasd.Text = "Firstname";
            // 
            // Asurname
            // 
            this.Asurname.Location = new System.Drawing.Point(79, 128);
            this.Asurname.Name = "Asurname";
            this.Asurname.Size = new System.Drawing.Size(162, 22);
            this.Asurname.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Surname";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Registruot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Astudentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 236);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Asurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Afirstname);
            this.Controls.Add(this.asdasdsadasd);
            this.Name = "Astudentas";
            this.Text = "Astudentas";
            this.Load += new System.EventHandler(this.Astudentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Afirstname;
        private System.Windows.Forms.Label asdasdsadasd;
        private System.Windows.Forms.TextBox Asurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}