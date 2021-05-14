
namespace StepTestApp
{
    partial class FormAdd
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
            this.AddFormName = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.LabelAge = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.LabelSex = new System.Windows.Forms.Label();
            this.Done = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // AddFormName
            // 
            this.AddFormName.AutoSize = true;
            this.AddFormName.Font = new System.Drawing.Font("Malgun Gothic", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFormName.Location = new System.Drawing.Point(108, 22);
            this.AddFormName.Name = "AddFormName";
            this.AddFormName.Size = new System.Drawing.Size(353, 60);
            this.AddFormName.TabIndex = 4;
            this.AddFormName.Text = "Add Participant";
            this.AddFormName.Click += new System.EventHandler(this.AddFormName_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(155, 183);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(146, 32);
            this.LabelName.TabIndex = 19;
            this.LabelName.Text = "Full Name :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(334, 189);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(146, 26);
            this.textBoxName.TabIndex = 18;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelAge
            // 
            this.LabelAge.AutoSize = true;
            this.LabelAge.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAge.Location = new System.Drawing.Point(45, 238);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(256, 32);
            this.LabelAge.TabIndex = 21;
            this.LabelAge.Text = "Age (enter number) :";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(334, 245);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(146, 26);
            this.textBoxAge.TabIndex = 20;
            this.textBoxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelSex
            // 
            this.LabelSex.AutoSize = true;
            this.LabelSex.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSex.Location = new System.Drawing.Point(232, 293);
            this.LabelSex.Name = "LabelSex";
            this.LabelSex.Size = new System.Drawing.Size(69, 32);
            this.LabelSex.TabIndex = 23;
            this.LabelSex.Text = "Sex :";
            // 
            // Done
            // 
            this.Done.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done.Location = new System.Drawing.Point(475, 403);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(93, 47);
            this.Done.TabIndex = 28;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(330, 302);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 24);
            this.radioButton1.TabIndex = 29;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(404, 302);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 24);
            this.radioButton2.TabIndex = 30;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 462);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.LabelSex);
            this.Controls.Add(this.LabelAge);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.AddFormName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddFormName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label LabelAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label LabelSex;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}