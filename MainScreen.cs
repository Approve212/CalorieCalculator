using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalorieCalculator
{
    public partial class MainScreen : Form
    {

        public Dictionary<DateTime, List<Form1.Food>> foodDic = new Dictionary<DateTime, List<Form1.Food>>();
        public MainScreen()
        {
            InitializeComponent();
        }

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            Form1 page = new Form1();
            page.mainScreen = this;
            page.Show();
            this.Enabled = false;
        }

        private void buttonWeekSum_Click(object sender, EventArgs e)
        {
            Summary page = new Summary();
            page.mainScreen = this;
            page.foodDic = foodDic;
            page.Show();
            this.Enabled = false;
            
        }

        public void addFood(Form1.Food food) 
        {
            if (!foodDic.ContainsKey(food.Day))
            {
                foodDic.Add(food.Day, new List<Form1.Food>());
            }
            foodDic[food.Day].Add(food);
        }

    }
}
