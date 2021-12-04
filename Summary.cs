using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalorieCalculator
{
    public partial class Summary : Form
    {
        public MainScreen mainScreen;
        public Dictionary<DateTime, List<Form1.Food>> foodDic;

        Label[] arrayLabels = new Label[7];

        public Summary()
        {
            InitializeComponent();
            arrayLabels[0] = labelSunOut;
            arrayLabels[1] = labelMonOut;
            arrayLabels[2] = labelTuesOut;
            arrayLabels[3] = labelWedOut;
            arrayLabels[4] = labelThurOut;
            arrayLabels[5] = labelFriOut;
            arrayLabels[6] = labelSatOut;
        }

        private void dateTimePickerWeekSum_ValueChanged(object sender, EventArgs e)
        {
            DateTime curDate = dateTimePickerWeekSum.Value.Date;
            List<Form1.Food> curFoodList;
            StringBuilder sb = new StringBuilder();
            int totalCalorieWeek = 0;
            foreach (Label label in arrayLabels)
            {
                if (foodDic.TryGetValue(curDate, out curFoodList))
                {
                    foreach (Form1.Food food in curFoodList)
                    {
                        totalCalorieWeek += food.TotalCal;
                        sb.Append(food.ToString());
                        label.Text = sb.ToString();
                    }
                }
                else
                {
                    label.Text = "No food entered for this day.";
                }
                curDate = curDate.AddDays(1);
            }
            labelCalForWeek.Text = totalCalorieWeek.ToString() + " calories.";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Summary_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainScreen.Enabled = true;
        }
    }
}
