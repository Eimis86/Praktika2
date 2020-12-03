namespace Praktika
{
    partial class Adestytojas
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
            this.Dfirstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Dsurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dfirstname
            // 
            this.Dfirstname.Location = new System.Drawing.Point(57, 64);
            this.Dfirstname.Name = "Dfirstname";
            this.Dfirstname.Size = new System.Drawing.Size(170, 22);
            this.Dfirstname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Firstname";
            // 
            // Dsurname
            // 
            this.Dsurname.Location = new System.Drawing.Point(57, 119);
            this.Dsurname.Name = "Dsurname";
            this.Dsurname.Size = new System.Drawing.Size(170, 22);
            this.Dsurname.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Surname";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Registruoti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Adestytojas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 233);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dsurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Dfirstname);
            this.Controls.Add(this.label3);
            this.Name = "Adestytojas";
            this.Text = "Adestytojas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Dfirstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Dsurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}