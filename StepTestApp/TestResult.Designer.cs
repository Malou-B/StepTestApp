
namespace StepTestApp
{
    partial class TestResult
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
            this.ResultFormName = new System.Windows.Forms.Label();
            this.LabelCapacity = new System.Windows.Forms.Label();
            this.FitResultLabel = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.labelAerobicCapacity = new System.Windows.Forms.Label();
            this.labelFitnessResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultFormName
            // 
            this.ResultFormName.AutoSize = true;
            this.ResultFormName.Font = new System.Drawing.Font("Malgun Gothic", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultFormName.Location = new System.Drawing.Point(270, 53);
            this.ResultFormName.Name = "ResultFormName";
            this.ResultFormName.Size = new System.Drawing.Size(256, 60);
            this.ResultFormName.TabIndex = 3;
            this.ResultFormName.Text = "Test Result";
            // 
            // LabelCapacity
            // 
            this.LabelCapacity.AutoSize = true;
            this.LabelCapacity.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCapacity.Location = new System.Drawing.Point(191, 189);
            this.LabelCapacity.Name = "LabelCapacity";
            this.LabelCapacity.Size = new System.Drawing.Size(222, 32);
            this.LabelCapacity.TabIndex = 15;
            this.LabelCapacity.Text = "Aerobic Capacity :";
            this.LabelCapacity.Click += new System.EventHandler(this.LabelCapacity_Click);
            // 
            // FitResultLabel
            // 
            this.FitResultLabel.AutoSize = true;
            this.FitResultLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FitResultLabel.Location = new System.Drawing.Point(226, 251);
            this.FitResultLabel.Name = "FitResultLabel";
            this.FitResultLabel.Size = new System.Drawing.Size(187, 32);
            this.FitResultLabel.TabIndex = 17;
            this.FitResultLabel.Text = "Fitness Result :";
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(681, 391);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(107, 47);
            this.Reset.TabIndex = 27;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(681, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(107, 39);
            this.Close.TabIndex = 28;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // labelAerobicCapacity
            // 
            this.labelAerobicCapacity.AutoSize = true;
            this.labelAerobicCapacity.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAerobicCapacity.Location = new System.Drawing.Point(422, 194);
            this.labelAerobicCapacity.Name = "labelAerobicCapacity";
            this.labelAerobicCapacity.Size = new System.Drawing.Size(0, 28);
            this.labelAerobicCapacity.TabIndex = 29;
            // 
            // labelFitnessResult
            // 
            this.labelFitnessResult.AutoSize = true;
            this.labelFitnessResult.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFitnessResult.Location = new System.Drawing.Point(422, 254);
            this.labelFitnessResult.Name = "labelFitnessResult";
            this.labelFitnessResult.Size = new System.Drawing.Size(0, 28);
            this.labelFitnessResult.TabIndex = 30;
            // 
            // TestResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFitnessResult);
            this.Controls.Add(this.labelAerobicCapacity);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.FitResultLabel);
            this.Controls.Add(this.LabelCapacity);
            this.Controls.Add(this.ResultFormName);
            this.Name = "TestResult";
            this.Text = "TestResult";
            this.Load += new System.EventHandler(this.TestResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultFormName;
        private System.Windows.Forms.Label LabelCapacity;
        private System.Windows.Forms.Label FitResultLabel;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label labelAerobicCapacity;
        private System.Windows.Forms.Label labelFitnessResult;
    }
}