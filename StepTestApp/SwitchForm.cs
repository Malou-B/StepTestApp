using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StepTestApp
{

    public class SwitchForm : Form
    {
        /// <summary>
        /// boolean attribute (true/false) to see if the user intentionnaly closed the app 
        /// </summary>
        private bool appClosedByUser = true;

        public SwitchForm()
        {
            FormClosing += FormClose;
            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// method that closes the different forms without closing the app.
        /// (user did not close the form so (base = parent class) closes the form)
        /// </summary>
        public virtual new void Close()
        {
            appClosedByUser = false;
            base.Close();
        }

        /// <summary>
        /// the method is called when the Form is closed. It verifies if it is the user who closed it.
        /// if it is the user who closes the form, the app exits.
        /// </summary>
        /// <param name="target">gives information about the form being closed</param>
        /// <param name="closingEvent">event object that gives information about the current events</param>
        private void FormClose(object target, FormClosingEventArgs closingEvent)
        {
            if (appClosedByUser)
            {
                Application.Exit();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SwitchForm
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "SwitchForm";
            this.Load += new System.EventHandler(this.SwitchForm_Load);
            this.ResumeLayout(false);

        }

        private void SwitchForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
