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
    public partial class FormAdd : Form
    {
        private AddUserInfo addUserInfo = new AddUserInfo();
        private bool done = false;

        public FormAdd()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// calls the method to display the Add form and keeps the dialogbox open until the user presses on done.
        /// </summary>
        /// <returns>an object userinfo is returned with the information entered in the dialogbox</returns>
        public async new Task<AddUserInfo> Show()
        {
            base.Show();
            while (!done)
            {
                await Task.Delay(25);
            }
            return addUserInfo;
        }


        private void Done_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                addUserInfo.Sex = Sex.Male;
            }
            else if(radioButton2.Checked)
            {
                addUserInfo.Sex = Sex.Female;
            }
            else
            {
                MessageBox.Show("Please select the sex of the participant");
                return;
            }

            if(addUserInfo.Name == null || addUserInfo.Name.Length <2)
            {
                MessageBox.Show("Please enter a name of at least two letters");
                return;
            }

            if(addUserInfo.Age <15 || addUserInfo.Age > 69)
            {
                MessageBox.Show("Please enter an age between 15 and 69");
                return;
            }
            done = true;
            Close();
        }

        private void AddFormName_Click(object sender, EventArgs e)
        {

        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            textBoxName.DataBindings.Add("Text", addUserInfo, "Name");
            textBoxAge.DataBindings.Add("Text", addUserInfo, "Age", true);
        }
    }
    public class AddUserInfo
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }
    }
}
