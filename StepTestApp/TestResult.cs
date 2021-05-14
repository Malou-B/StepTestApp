using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearRegression;


namespace StepTestApp
{
    public partial class TestResult : SwitchForm
    {
        private int stepHeight;
        private List<AddUserInfo> userList;
        private int userIndex;
        private List<int> dataResult;
        public TestResult(int stepHeight, List<AddUserInfo> userList, int userIndex, StepDataResult dataResult)
        {
            this.stepHeight = stepHeight;
            this.userList = userList;
            this.userIndex = userIndex;
            this.dataResult = new List<int>
            {
                dataResult.Level1,
                dataResult.Level2,
                dataResult.Level3,
                dataResult.Level4,
                dataResult.Level5
            };
            
            InitializeComponent();
        }

        private void TestResult_Load(object sender, EventArgs e)
        {
            var maxHR = 220 - userList[userIndex].Age;
            var hr85 = maxHR*0.85;
            var hr50 = maxHR * 0.5;
            var p = AllCases(hr50, hr85);
            if(p == null)
            {
                BackResult_Click(null, null);
                return;
            }

            var aerobic = (maxHR - p.Item1) / p.Item2;
            var result = Tools.ScoreWithRating((int)aerobic, userList[userIndex].Age, userList[userIndex].Sex);
            labelAerobicCapacity.Text = ((int)aerobic).ToString() + " mlsO2/kg/min";
            labelFitnessResult.Text = result.ToString();
            SaveUsers((int)aerobic, result);
        }

        private Tuple<double, double> AllCases(double hr50, double hr85)
        {
            var validReadings = dataResult.Where(el => el < hr85 && el > hr50);
            var underReadings = dataResult.Where(el => el < hr85);
            var aboveReadings = dataResult.Where(el => el > hr50);

            if (underReadings.Count() == 0 || aboveReadings.Count() ==0 || validReadings.Count() <2)
            {
                MessageBox.Show("All readings are invalid, we cannot determine your Aerobic Capacity");
                return null;
            }

            var xdata = new List<double>();
            var ydata = new List<double>();
            for (int i = 0; i < dataResult.Count; i++)
            {
                if (dataResult[i] < hr50 || dataResult[i] > hr85)
                {
                    continue;
                }
                ydata.Add(dataResult[i]);
                xdata.Add((double)Tools.StepToAerobic(i, stepHeight));
            }
            return SimpleRegression.Fit(xdata.ToArray(), ydata.ToArray());
        }

        private void SaveUsers(int aerobicCapacity, Rating? fitnessResult)
        {
            if(fitnessResult == null)
            {
                return;
            }
            DatabaseContext.Add(new UserInfo()
            {
                Name = userList[userIndex].Name,
                Age = userList[userIndex].Age,
                Date = DateTime.Now,
                Capacity = aerobicCapacity,
                Fitness = (Rating) fitnessResult,
                Sex = userList[userIndex].Sex
                
            });
        }
        private void BackResult_Click(object sender, EventArgs e)
        {
            var form = new TestInfo(stepHeight, userList);
            form.Show();
            Close();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            var form = new TestInfo(stepHeight, userList);
            form.Show();
            Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            var form = new Menu();
            form.Show();
            Close();
        }

        private void LabelCapacity_Click(object sender, EventArgs e)
        {

        }
    }
}
