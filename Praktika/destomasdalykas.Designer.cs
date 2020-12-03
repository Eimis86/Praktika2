namespace Praktika
{
    partial class destomasdalykas
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Astudentoid = new System.Windows.Forms.TextBox();
            this.Adalykoid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sukurti studijuojama dalyka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Studento_ID";
            // 
            // Astudentoid
            // 
            this.Astudentoid.Location = new System.Drawing.Point(80, 56);
            this.Astudentoid.Name = "Astudentoid";
            this.Astudentoid.Size = new System.Drawing.Size(142, 22);
            this.Astudentoid.TabIndex = 2;
            // 
            // Adalykoid
            // 
            this.Adalykoid.Location = new System.Drawing.Point(80, 110);
            this.Adalykoid.Name = "Adalykoid";
            this.Adalykoid.Size = new System.Drawing.Size(142, 22);
            this.Adalykoid.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dalyko_ID";
            // 
            // destomasdalykas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 291);
            this.Controls.Add(this.Adalykoid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Astudentoid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "destomasdalykas";
            this.Text = "destomasdalykas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Astudentoid;
        private System.Windows.Forms.TextBox Adalykoid;
        private System.Windows.Forms.Label label2;
    }
}