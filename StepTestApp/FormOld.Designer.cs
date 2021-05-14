
namespace StepTestApp
{
    partial class FormOld
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
            this.BackOld = new System.Windows.Forms.Button();
            this.dataGridConsult = new System.Windows.Forms.DataGridView();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.FormOldName = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fitness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsult)).BeginInit();
            this.SuspendLayout();
            // 
            // BackOld
            // 
            this.BackOld.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackOld.Location = new System.Drawing.Point(12, 12);
            this.BackOld.Name = "BackOld";
            this.BackOld.Size = new System.Drawing.Size(94, 39);
            this.BackOld.TabIndex = 10;
            this.BackOld.Text = "< Back";
            this.BackOld.UseVisualStyleBackColor = true;
            this.BackOld.Click += new System.EventHandler(this.BackOld_Click);
            // 
            // dataGridConsult
            // 
            this.dataGridConsult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.Age,
            this.Date,
            this.Result,
            this.Fitness,
            this.Sexes});
            this.dataGridConsult.Location = new System.Drawing.Point(68, 283);
            this.dataGridConsult.Name = "dataGridConsult";
            this.dataGridConsult.RowHeadersWidth = 62;
            this.dataGridConsult.RowTemplate.Height = 28;
            this.dataGridConsult.Size = new System.Drawing.Size(694, 417);
            this.dataGridConsult.TabIndex = 4;
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearch.Location = new System.Drawing.Point(234, 146);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(376, 32);
            this.LabelSearch.TabIndex = 3;
            this.LabelSearch.Text = "Type the Name of the Participant";
            this.LabelSearch.Click += new System.EventHandler(this.LabelSearch_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(252, 205);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(327, 26);
            this.SearchBox.TabIndex = 2;
            this.SearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // FormOldName
            // 
            this.FormOldName.AutoSize = true;
            this.FormOldName.Font = new System.Drawing.Font("Malgun Gothic", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormOldName.Location = new System.Drawing.Point(156, 25);
            this.FormOldName.Name = "FormOldName";
            this.FormOldName.Size = new System.Drawing.Size(540, 60);
            this.FormOldName.TabIndex = 1;
            this.FormOldName.Text = "Consult Previous Results";
            this.FormOldName.Click += new System.EventHandler(this.FormOldName_Click);
            // 
            // User
            // 
            this.User.HeaderText = "Name";
            this.User.MinimumWidth = 8;
            this.User.Name = "User";
            this.User.Width = 150;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 8;
            this.Age.Name = "Age";
            this.Age.Width = 150;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.Width = 150;
            // 
            // Result
            // 
            this.Result.HeaderText = "Result";
            this.Result.MinimumWidth = 8;
            this.Result.Name = "Result";
            this.Result.Width = 150;
            // 
            // Fitness
            // 
            this.Fitness.HeaderText = "Rating";
            this.Fitness.MinimumWidth = 8;
            this.Fitness.Name = "Fitness";
            this.Fitness.Width = 150;
            // 
            // Sexes
            // 
            this.Sexes.HeaderText = "Sex";
            this.Sexes.MinimumWidth = 8;
            this.Sexes.Name = "Sexes";
            this.Sexes.Width = 150;
            // 
            // FormOld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 736);
            this.Controls.Add(this.BackOld);
            this.Controls.Add(this.dataGridConsult);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.FormOldName);
            this.Name = "FormOld";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormOld_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormOldName;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.DataGridView dataGridConsult;
        private System.Windows.Forms.Button BackOld;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fitness;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexes;
    }
}