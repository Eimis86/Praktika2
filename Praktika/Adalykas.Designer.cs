namespace Praktika
{
    partial class Adalykas
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
            this.destytojoid = new System.Windows.Forms.TextBox();
            this.dalykopavadinimas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sukurti dalyka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Destytojo ID";
            // 
            // destytojoid
            // 
            this.destytojoid.Location = new System.Drawing.Point(194, 165);
            this.destytojoid.Name = "destytojoid";
            this.destytojoid.Size = new System.Drawing.Size(183, 22);
            this.destytojoid.TabIndex = 2;
            // 
            // dalykopavadinimas
            // 
            this.dalykopavadinimas.Location = new System.Drawing.Point(194, 120);
            this.dalykopavadinimas.Name = "dalykopavadinimas";
            this.dalykopavadinimas.Size = new System.Drawing.Size(183, 22);
            this.dalykopavadinimas.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dalyko pavadinimas";
            // 
            // Adalykas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 323);
            this.Controls.Add(this.dalykopavadinimas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.destytojoid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Adalykas";
            this.Text = "Adalykas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox destytojoid;
        private System.Windows.Forms.TextBox dalykopavadinimas;
        private System.Windows.Forms.Label label2;
    }
}