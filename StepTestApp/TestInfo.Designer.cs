
namespace StepTestApp
{
    partial class TestInfo
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
            this.TestInfoName = new System.Windows.Forms.Label();
            this.LabelSelect = new System.Windows.Forms.Label();
            this.listViewTest = new System.Windows.Forms.ListView();
            this.HRLabel1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.HRLabel2 = new System.Windows.Forms.Label();
            this.HRLabel3 = new System.Windows.Forms.Label();
            this.HRLabel4 = new System.Windows.Forms.Label();
            this.HRLabel5 = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.BackTest = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // TestInfoName
            // 
            this.TestInfoName.AutoSize = true;
            this.TestInfoName.Font = new System.Drawing.Font("Malgun Gothic", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestInfoName.Location = new System.Drawing.Point(278, 19);
            this.TestInfoName.Name = "TestInfoName";
            this.TestInfoName.Size = new System.Drawing.Size(221, 60);
            this.TestInfoName.TabIndex = 3;
            this.TestInfoName.Text = "Step Test";
            this.TestInfoName.Click += new System.EventHandler(this.FormNewName_Click);
            // 
            // LabelSelect
            // 
            this.LabelSelect.AutoSize = true;
            this.LabelSelect.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSelect.Location = new System.Drawing.Point(272, 119);
            this.LabelSelect.Name = "LabelSelect";
            this.LabelSelect.Size = new System.Drawing.Size(243, 32);
            this.LabelSelect.TabIndex = 4;
            this.LabelSelect.Text = "Select the Participant";
            // 
            // listViewTest
            // 
            this.listViewTest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewTest.FullRowSelect = true;
            this.listViewTest.HideSelection = false;
            this.listViewTest.Location = new System.Drawing.Point(103, 177);
            this.listViewTest.Name = "listViewTest";
            this.listViewTest.Size = new System.Drawing.Size(590, 200);
            this.listViewTest.TabIndex = 9;
            this.listViewTest.UseCompatibleStateImageBehavior = false;
            this.listViewTest.SelectedIndexChanged += new System.EventHandler(this.listViewTest_SelectedIndexChanged);
            // 
            // HRLabel1
            // 
            this.HRLabel1.AutoSize = true;
            this.HRLabel1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRLabel1.Location = new System.Drawing.Point(169, 418);
            this.HRLabel1.Name = "HRLabel1";
            this.HRLabel1.Size = new System.Drawing.Size(346, 32);
            this.HRLabel1.TabIndex = 13;
            this.HRLabel1.Text = "Enter Heart Rate for Level 1 :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(538, 424);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 26);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(538, 474);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 26);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(538, 526);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 26);
            this.textBox3.TabIndex = 16;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(538, 582);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 26);
            this.textBox4.TabIndex = 18;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(538, 641);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(76, 26);
            this.textBox5.TabIndex = 20;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HRLabel2
            // 
            this.HRLabel2.AutoSize = true;
            this.HRLabel2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRLabel2.Location = new System.Drawing.Point(169, 468);
            this.HRLabel2.Name = "HRLabel2";
            this.HRLabel2.Size = new System.Drawing.Size(346, 32);
            this.HRLabel2.TabIndex = 22;
            this.HRLabel2.Text = "Enter Heart Rate for Level 2 :";
            // 
            // HRLabel3
            // 
            this.HRLabel3.AutoSize = true;
            this.HRLabel3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRLabel3.Location = new System.Drawing.Point(169, 520);
            this.HRLabel3.Name = "HRLabel3";
            this.HRLabel3.Size = new System.Drawing.Size(346, 32);
            this.HRLabel3.TabIndex = 23;
            this.HRLabel3.Text = "Enter Heart Rate for Level 3 :";
            // 
            // HRLabel4
            // 
            this.HRLabel4.AutoSize = true;
            this.HRLabel4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRLabel4.Location = new System.Drawing.Point(169, 576);
            this.HRLabel4.Name = "HRLabel4";
            this.HRLabel4.Size = new System.Drawing.Size(346, 32);
            this.HRLabel4.TabIndex = 24;
            this.HRLabel4.Text = "Enter Heart Rate for Level 4 :";
            // 
            // HRLabel5
            // 
            this.HRLabel5.AutoSize = true;
            this.HRLabel5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRLabel5.Location = new System.Drawing.Point(169, 635);
            this.HRLabel5.Name = "HRLabel5";
            this.HRLabel5.Size = new System.Drawing.Size(346, 32);
            this.HRLabel5.TabIndex = 25;
            this.HRLabel5.Text = "Enter Heart Rate for Level 5 :";
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(705, 676);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(83, 41);
            this.Next.TabIndex = 26;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // BackTest
            // 
            this.BackTest.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackTest.Location = new System.Drawing.Point(12, 12);
            this.BackTest.Name = "BackTest";
            this.BackTest.Size = new System.Drawing.Size(97, 45);
            this.BackTest.TabIndex = 27;
            this.BackTest.Text = "< Back";
            this.BackTest.UseVisualStyleBackColor = true;
            this.BackTest.Click += new System.EventHandler(this.BackTest_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Age";
            // 
            // TestInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 729);
            this.Controls.Add(this.BackTest);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.HRLabel5);
            this.Controls.Add(this.HRLabel4);
            this.Controls.Add(this.HRLabel3);
            this.Controls.Add(this.HRLabel2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.HRLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listViewTest);
            this.Controls.Add(this.LabelSelect);
            this.Controls.Add(this.TestInfoName);
            this.Name = "TestInfo";
            this.Text = "TestInfo";
            this.Load += new System.EventHandler(this.TestInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TestInfoName;
        private System.Windows.Forms.Label LabelSelect;
        private System.Windows.Forms.ListView listViewTest;
        private System.Windows.Forms.Label HRLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label HRLabel2;
        private System.Windows.Forms.Label HRLabel3;
        private System.Windows.Forms.Label HRLabel4;
        private System.Windows.Forms.Label HRLabel5;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button BackTest;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}