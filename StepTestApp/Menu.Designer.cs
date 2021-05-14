
namespace StepTestApp
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuName = new System.Windows.Forms.Label();
            this.ButtonOld = new System.Windows.Forms.Button();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MenuName
            // 
            this.MenuName.AutoSize = true;
            this.MenuName.Font = new System.Drawing.Font("Malgun Gothic", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuName.Location = new System.Drawing.Point(222, 36);
            this.MenuName.Name = "MenuName";
            this.MenuName.Size = new System.Drawing.Size(356, 60);
            this.MenuName.TabIndex = 0;
            this.MenuName.Text = "Step Test Menu";
            this.MenuName.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonOld
            // 
            this.ButtonOld.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOld.Location = new System.Drawing.Point(129, 211);
            this.ButtonOld.Name = "ButtonOld";
            this.ButtonOld.Size = new System.Drawing.Size(223, 114);
            this.ButtonOld.TabIndex = 1;
            this.ButtonOld.Text = "Check Old Results\r\n";
            this.ButtonOld.UseVisualStyleBackColor = true;
            this.ButtonOld.Click += new System.EventHandler(this.ButtonOld_Click);
            // 
            // ButtonNew
            // 
            this.ButtonNew.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNew.Location = new System.Drawing.Point(444, 211);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(223, 114);
            this.ButtonNew.TabIndex = 2;
            this.ButtonNew.Text = "Create New Test";
            this.ButtonNew.UseVisualStyleBackColor = true;
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.ButtonOld);
            this.Controls.Add(this.MenuName);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MenuName;
        private System.Windows.Forms.Button ButtonOld;
        private System.Windows.Forms.Button ButtonNew;
    }
}

