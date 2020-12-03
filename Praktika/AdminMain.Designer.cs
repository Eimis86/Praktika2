namespace Praktika
{
    partial class AdminMain
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktikaDataSet = new Praktika.PraktikaDataSet();
            this.usersTableAdapter = new Praktika.PraktikaDataSetTableAdapters.UsersTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteuser = new System.Windows.Forms.TextBox();
            this.praktikaDataSet1 = new Praktika.PraktikaDataSet1();
            this.studentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentasTableAdapter = new Praktika.PraktikaDataSet1TableAdapters.StudentasTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.praktikaDataSet2 = new Praktika.PraktikaDataSet2();
            this.studentasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentasTableAdapter1 = new Praktika.PraktikaDataSet2TableAdapters.StudentasTableAdapter();
            this.praktikaDataSet3 = new Praktika.PraktikaDataSet3();
            this.studentasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentasTableAdapter2 = new Praktika.PraktikaDataSet3TableAdapters.StudentasTableAdapter();
            this.deletedestyt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.deletegrupe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.deletedalykas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.deletedestomadalyka = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sukurt studenta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sukurt destytoja";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(202, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(483, 345);
            this.dataGridView1.TabIndex = 2;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.praktikaDataSet;
            // 
            // praktikaDataSet
            // 
            this.praktikaDataSet.DataSetName = "PraktikaDataSet";
            this.praktikaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(443, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 53);
            this.button3.TabIndex = 3;
            this.button3.Text = "Istrinti naudotoja";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parasykit studento ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // deleteuser
            // 
            this.deleteuser.Location = new System.Drawing.Point(298, 416);
            this.deleteuser.Name = "deleteuser";
            this.deleteuser.Size = new System.Drawing.Size(139, 22);
            this.deleteuser.TabIndex = 5;
            this.deleteuser.TextChanged += new System.EventHandler(this.deleteuser_TextChanged);
            // 
            // praktikaDataSet1
            // 
            this.praktikaDataSet1.DataSetName = "PraktikaDataSet1";
            this.praktikaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentasBindingSource
            // 
            this.studentasBindingSource.DataMember = "Studentas";
            this.studentasBindingSource.DataSource = this.praktikaDataSet1;
            // 
            // studentasTableAdapter
            // 
            this.studentasTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(691, 34);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(509, 345);
            this.dataGridView2.TabIndex = 6;
            // 
            // praktikaDataSet2
            // 
            this.praktikaDataSet2.DataSetName = "PraktikaDataSet2";
            this.praktikaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentasBindingSource1
            // 
            this.studentasBindingSource1.DataMember = "Studentas";
            this.studentasBindingSource1.DataSource = this.praktikaDataSet2;
            // 
            // studentasTableAdapter1
            // 
            this.studentasTableAdapter1.ClearBeforeFill = true;
            // 
            // praktikaDataSet3
            // 
            this.praktikaDataSet3.DataSetName = "PraktikaDataSet3";
            this.praktikaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentasBindingSource2
            // 
            this.studentasBindingSource2.DataMember = "Studentas";
            this.studentasBindingSource2.DataSource = this.praktikaDataSet3;
            // 
            // studentasTableAdapter2
            // 
            this.studentasTableAdapter2.ClearBeforeFill = true;
            // 
            // deletedestyt
            // 
            this.deletedestyt.Location = new System.Drawing.Point(635, 416);
            this.deletedestyt.Name = "deletedestyt";
            this.deletedestyt.Size = new System.Drawing.Size(139, 22);
            this.deletedestyt.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Parasykit destytojo ID";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(780, 385);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 61);
            this.button4.TabIndex = 7;
            this.button4.Text = "Istrinti destytoja";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(202, 469);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(483, 271);
            this.dataGridView3.TabIndex = 10;
            // 
            // deletegrupe
            // 
            this.deletegrupe.Location = new System.Drawing.Point(298, 777);
            this.deletegrupe.Name = "deletegrupe";
            this.deletegrupe.Size = new System.Drawing.Size(139, 22);
            this.deletegrupe.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 757);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Parasykit grupes ID";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(443, 746);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 53);
            this.button5.TabIndex = 11;
            this.button5.Text = "Istrinti naudotoja";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(52, 150);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 49);
            this.button6.TabIndex = 14;
            this.button6.Text = "Sukurt grupe";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(691, 469);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(483, 271);
            this.dataGridView4.TabIndex = 15;
            // 
            // deletedalykas
            // 
            this.deletedalykas.Location = new System.Drawing.Point(777, 777);
            this.deletedalykas.Name = "deletedalykas";
            this.deletedalykas.Size = new System.Drawing.Size(139, 22);
            this.deletedalykas.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(774, 757);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Parasykite dalyko ID";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(922, 746);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 53);
            this.button7.TabIndex = 16;
            this.button7.Text = "Istrinti dalyka";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(52, 206);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(144, 50);
            this.button8.TabIndex = 19;
            this.button8.Text = "Sukurti dalyka";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Studentu lentele";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(890, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "destytoju lentele";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(890, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "dalyko lentele";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "grupes lentele";
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(1224, 343);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(705, 397);
            this.dataGridView5.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1404, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(365, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Destytoju ir studentu priskirimas prie studijuojamo dalyko";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1450, 757);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Parasykite destomo dalyko ID";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1650, 746);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(136, 53);
            this.button9.TabIndex = 26;
            this.button9.Text = "Istrinti destoma dalyka";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(52, 263);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(144, 50);
            this.button10.TabIndex = 29;
            this.button10.Text = "Sukurti destoma dalyka";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // deletedestomadalyka
            // 
            this.deletedestomadalyka.Location = new System.Drawing.Point(1453, 777);
            this.deletedestomadalyka.Name = "deletedestomadalyka";
            this.deletedestomadalyka.Size = new System.Drawing.Size(191, 22);
            this.deletedestomadalyka.TabIndex = 28;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(52, 320);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(144, 48);
            this.button11.TabIndex = 30;
            this.button11.Text = "Prideti studenta prie grupes";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(1064, 385);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(136, 61);
            this.button12.TabIndex = 31;
            this.button12.Text = "Istrinti destytoja/dalyka/studijas";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(922, 385);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(136, 61);
            this.button13.TabIndex = 32;
            this.button13.Text = "Istrinti destytoja/dalyka";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 836);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.deletedestomadalyka);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.deletedalykas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.deletegrupe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.deletedestyt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.deleteuser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.Load += new System.EventHandler(this.AdminMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PraktikaDataSet praktikaDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private PraktikaDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deleteuser;
        private PraktikaDataSet1 praktikaDataSet1;
        private System.Windows.Forms.BindingSource studentasBindingSource;
        private PraktikaDataSet1TableAdapters.StudentasTableAdapter studentasTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private PraktikaDataSet2 praktikaDataSet2;
        private System.Windows.Forms.BindingSource studentasBindingSource1;
        private PraktikaDataSet2TableAdapters.StudentasTableAdapter studentasTableAdapter1;
        private PraktikaDataSet3 praktikaDataSet3;
        private System.Windows.Forms.BindingSource studentasBindingSource2;
        private PraktikaDataSet3TableAdapters.StudentasTableAdapter studentasTableAdapter2;
        private System.Windows.Forms.TextBox deletedestyt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox deletegrupe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TextBox deletedalykas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox deletedestomadalyka;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
    }
}