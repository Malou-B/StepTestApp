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
    public partial class FormNew : SwitchForm
    {

        private List<AddUserInfo> listUsers = new List<AddUserInfo>();
        public FormNew()
        {
            InitializeComponent();
        }

        public FormNew(int stepHeight, List<AddUserInfo> userList)
        {
            listUsers = userList;
            InitializeComponent();
        }
        /// <summary>
        /// sets two columns for the display tables
        /// </summary>
        private void DisplayUserList()
        {
            listViewInfo.Items.Clear();
            foreach(var user in listUsers)
            {
                var userTable = new string[2]
                {
                    user.Name, user.Age.ToString()
                };

                listViewInfo.Items.Add(new ListViewItem(userTable));
            }
        }
        private void MenuName_Click(object sender, EventArgs e)
        {

        }

        private void Begin_Click(object sender, EventArgs e)
        {
            var stepHeight = 0;
            if (radioButton15.Checked)
            {
                stepHeight = 15;
            }
            else if (radioButton20.Checked)
            {
                stepHeight = 20;
            }
            else if (radioButton25.Checked)
            {
                stepHeight = 25;
            }
            else if (radioButton30.Checked)
            {
                stepHeight = 30;
            }
            else
            {
                MessageBox.Show("Please select the size of the step");
                return;
            }

            if (listViewInfo.Items.Count<1)
            {
                MessageBox.Show("Please enter a participant");
                return;
            }

            var form = new TestInfo(stepHeight, listUsers);
            form.Show();
            Close();
        }

        private void NbBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TitleSelect_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Menu();
            form.Show();
            Close();
        }

        private void Import_Click(object sender, EventArgs e)
        {
            
        }

        private async void NewParticipant_Click(object sender, EventArgs e)
        {
            var form = new FormAdd();
            var newUser = await form.Show();
            listUsers.Add(newUser);
            DisplayUserList();
        }

        /// <summary>
        /// To display colums
        /// </summary>
        private void FormNew_Load(object sender, EventArgs e)
        {
            listViewInfo.View = View.Details;
            DisplayUserList();
        }
    }
}
