namespace Praktika
{
    partial class Astudgupe
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
            this.Astud = new System.Windows.Forms.TextBox();
            this.Agrupe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Prideti prie grupes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Studento ID";
            // 
            // Astud
            // 
            this.Astud.Location = new System.Drawing.Point(64, 63);
            this.Astud.Name = "Astud";
            this.Astud.Size = new System.Drawing.Size(100, 22);
            this.Astud.TabIndex = 2;
            // 
            // Agrupe
            // 
            this.Agrupe.Location = new System.Drawing.Point(64, 109);
            this.Agrupe.Name = "Agrupe";
            this.Agrupe.Size = new System.Drawing.Size(100, 22);
            this.Agrupe.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grupes ID";
            // 
            // Astudgupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 236);
            this.Controls.Add(this.Agrupe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Astud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Astudgupe";
            this.Text = "Astudgupe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Astud;
        private System.Windows.Forms.TextBox Agrupe;
        private System.Windows.Forms.Label label2;
    }
}