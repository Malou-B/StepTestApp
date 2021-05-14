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
    public partial class TestInfo : SwitchForm
    {
        private int stepHeight;
        private List<AddUserInfo> userList;
        private StepDataResult dataResult = new StepDataResult();
        public TestInfo(int stepHeight, List<AddUserInfo> userList)
        {
            this.stepHeight = stepHeight;
            this.userList = userList;
            InitializeComponent();
        }

        private void FormNewName_Click(object sender, EventArgs e)
        {

        }

        private void TestInfo_Load(object sender, EventArgs e)
        {
            textBox1.DataBindings.Add("Text", dataResult, "Level1", true);
            textBox2.DataBindings.Add("Text", dataResult, "Level2", true);
            textBox3.DataBindings.Add("Text", dataResult, "Level3", true);
            textBox4.DataBindings.Add("Text", dataResult, "Level4", true);
            textBox5.DataBindings.Add("Text", dataResult, "Level5", true);
            listViewTest.View = View.Details;
            DisplayUserList();
        }
        private void DisplayUserList()
        {
            listViewTest.Items.Clear();
            foreach (var user in userList)
            {
                var userTable = new string[2]
                {
                    user.Name, user.Age.ToString()
                };

                listViewTest.Items.Add(new ListViewItem(userTable));
            }
        }
        private void listViewTest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BackTest_Click(object sender, EventArgs e)
        {
            var form = new FormNew(stepHeight, userList);
            form.Show();
            Close();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (dataResult.Level1 == 0 || dataResult.Level2 == 0 || dataResult.Level3 == 0 || dataResult.Level4 ==0 || dataResult.Level5 == 0)
            {
                MessageBox.Show("Please enter empty field");
                return;
            }
           
            try
            {
                var form = new TestResult(stepHeight, userList, listViewTest.SelectedIndices[0], dataResult);
                form.Show();
                Close();
            }

            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a participant");
                return;
            }
            
        }
    }
    public class StepDataResult
    {
        public int Level1 { get; set; }
        public int Level2 { get; set; }
        public int Level3 { get; set; }
        public int Level4 { get; set; }
        public int Level5 { get; set; }

    }
}
