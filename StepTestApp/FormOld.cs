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
    public partial class FormOld : SwitchForm
    {
        public FormOld()
        {
            InitializeComponent();
        }

        private void LabelSearch_Click(object sender, EventArgs e)
        {

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            var users = DatabaseContext.Search(SearchBox.Text);
            PopulateTable(users);
        }

        private void FormOldName_Click(object sender, EventArgs e)
        {

        }

        private void BackOld_Click(object sender, EventArgs e)
        {
            var form = new Menu();
            form.Show();
            Close();
        }

        /// <summary>
        /// method displays all the previous tests and retrieves them from the database
        /// </summary>
        /// <param name="sender">gives information about the form being loaded</param>
        /// <param name="e">event object that gives information about the current event</param>
        private void FormOld_Load(object sender, EventArgs e)
        {
            DatabaseContext.Add(new UserInfo()
            {
                Name = "Groda",
                Age = 5,
                Date = DateTime.Now,
                Capacity = 70,
                Fitness = Rating.Excellent,
                Sex = Sex.Male,
            });
            DatabaseContext.Add(new UserInfo()
            {
                Name = "Poulet",
                Age = 7,
                Date = DateTime.Now,
                Capacity = 70,
                Fitness = Rating.Excellent,
                Sex = Sex.Male,
            });
            DatabaseContext.Add(new UserInfo()
            {
                Name = "Tekashi",
                Age = 3,
                Date = DateTime.Now,
                Capacity = 70,
                Fitness = Rating.Excellent,
                Sex = Sex.Male,
            });

            var users = DatabaseContext.Retrieve();
            PopulateTable(users);
        }

        /// <summary>
        /// method that adds the user info in the grid
        /// </summary>
        /// <param name="users">entery list, all the users</param>
        private void PopulateTable(List<UserInfo> users)
        {
            dataGridConsult.Rows.Clear();
            foreach (var user in users)
            {
                dataGridConsult.Rows.Add(user.Name, user.Age, user.Date, user.Capacity, user.Fitness, user.Sex);
            }
            dataGridConsult.AutoResizeColumns();
        }
    }
}
