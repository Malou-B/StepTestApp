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
    public partial class Menu : SwitchForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonOld_Click(object sender, EventArgs e)
        {
            var form = new FormOld();
            form.Show();
            Close();
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            var form = new FormNew();
            form.Show();
            Close();
        }
    }
}
