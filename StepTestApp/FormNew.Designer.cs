
namespace StepTestApp
{
    partial class FormNew
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
            this.FormNewName = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.NewParticipant = new System.Windows.Forms.Button();
            this.listViewInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BackNew = new System.Windows.Forms.Button();
            this.StepSizeLabel = new System.Windows.Forms.Label();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.radioButton25 = new System.Windows.Forms.RadioButton();
            this.radioButton30 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // FormNewName
            // 
            this.FormNewName.AutoSize = true;
            this.FormNewName.Font = new System.Drawing.Font("Malgun Gothic", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormNewName.Location = new System.Drawing.Point(216, 35);
            this.FormNewName.Name = "FormNewName";
            this.FormNewName.Size = new System.Drawing.Size(343, 60);
            this.FormNewName.TabIndex = 2;
            this.FormNewName.Text = "Add New Tests";
            this.FormNewName.Click += new System.EventHandler(this.MenuName_Click);
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(674, 620);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(83, 41);
            this.Start.TabIndex = 5;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Begin_Click);
            // 
            // NewParticipant
            // 
            this.NewParticipant.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewParticipant.Location = new System.Drawing.Point(263, 163);
            this.NewParticipant.Name = "NewParticipant";
            this.NewParticipant.Size = new System.Drawing.Size(242, 67);
            this.NewParticipant.TabIndex = 7;
            this.NewParticipant.Text = "Add Participant";
            this.NewParticipant.UseVisualStyleBackColor = true;
            this.NewParticipant.Click += new System.EventHandler(this.NewParticipant_Click);
            // 
            // listViewInfo
            // 
            this.listViewInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewInfo.HideSelection = false;
            this.listViewInfo.Location = new System.Drawing.Point(85, 264);
            this.listViewInfo.Name = "listViewInfo";
            this.listViewInfo.Size = new System.Drawing.Size(590, 242);
            this.listViewInfo.TabIndex = 8;
            this.listViewInfo.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Age";
            // 
            // BackNew
            // 
            this.BackNew.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackNew.Location = new System.Drawing.Point(12, 12);
            this.BackNew.Name = "BackNew";
            this.BackNew.Size = new System.Drawing.Size(95, 44);
            this.BackNew.TabIndex = 9;
            this.BackNew.Text = "< Back";
            this.BackNew.UseVisualStyleBackColor = true;
            this.BackNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // StepSizeLabel
            // 
            this.StepSizeLabel.AutoSize = true;
            this.StepSizeLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepSizeLabel.Location = new System.Drawing.Point(79, 552);
            this.StepSizeLabel.Name = "StepSizeLabel";
            this.StepSizeLabel.Size = new System.Drawing.Size(210, 32);
            this.StepSizeLabel.TabIndex = 11;
            this.StepSizeLabel.Text = "Select Step Size :";
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(307, 560);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(77, 24);
            this.radioButton15.TabIndex = 16;
            this.radioButton15.TabStop = true;
            this.radioButton15.Text = "15 cm";
            this.radioButton15.UseVisualStyleBackColor = true;
            // 
            // radioButton20
            // 
            this.radioButton20.AutoSize = true;
            this.radioButton20.Location = new System.Drawing.Point(402, 560);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(77, 24);
            this.radioButton20.TabIndex = 17;
            this.radioButton20.TabStop = true;
            this.radioButton20.Text = "20 cm";
            this.radioButton20.UseVisualStyleBackColor = true;
            // 
            // radioButton25
            // 
            this.radioButton25.AutoSize = true;
            this.radioButton25.Location = new System.Drawing.Point(496, 560);
            this.radioButton25.Name = "radioButton25";
            this.radioButton25.Size = new System.Drawing.Size(77, 24);
            this.radioButton25.TabIndex = 18;
            this.radioButton25.TabStop = true;
            this.radioButton25.Text = "25 cm";
            this.radioButton25.UseVisualStyleBackColor = true;
            // 
            // radioButton30
            // 
            this.radioButton30.AutoSize = true;
            this.radioButton30.Location = new System.Drawing.Point(598, 560);
            this.radioButton30.Name = "radioButton30";
            this.radioButton30.Size = new System.Drawing.Size(77, 24);
            this.radioButton30.TabIndex = 19;
            this.radioButton30.TabStop = true;
            this.radioButton30.Text = "30 cm";
            this.radioButton30.UseVisualStyleBackColor = true;
            // 
            // FormNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 673);
            this.Controls.Add(this.radioButton30);
            this.Controls.Add(this.radioButton25);
            this.Controls.Add(this.radioButton20);
            this.Controls.Add(this.radioButton15);
            this.Controls.Add(this.StepSizeLabel);
            this.Controls.Add(this.BackNew);
            this.Controls.Add(this.listViewInfo);
            this.Controls.Add(this.NewParticipant);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.FormNewName);
            this.Name = "FormNew";
            this.Text = "FormNew";
            this.Load += new System.EventHandler(this.FormNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormNewName;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button NewParticipant;
        private System.Windows.Forms.ListView listViewInfo;
        private System.Windows.Forms.Button BackNew;
        private System.Windows.Forms.Label StepSizeLabel;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton20;
        private System.Windows.Forms.RadioButton radioButton25;
        private System.Windows.Forms.RadioButton radioButton30;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}