using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCalculator
{
    public partial class Form1 : Form
    {  
        public class Food
        {
            //Need to fix
            public int protein;// = Convert.ToInt32(textBoxProtein.Text);
            public int carb;// = Convert.ToInt32(textBoxCarb.Text);
            public int fat;// = Convert.ToInt32(textBoxFat.Text);
        }

        double calcCalorie(Food food)
        {
            double proteinCal, carbCal, fatCal, foodCal;

            proteinCal = food.protein * 4;
            carbCal = food.carb * 4;
            fatCal = food.fat * 9;

            foodCal = proteinCal + carbCal + fatCal;
            return foodCal;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //calcCalorie(food);
            //Above call is preferred, below is temporary
            int protein = Convert.ToInt32(textBoxProtein.Text);
            int carb = Convert.ToInt32(textBoxCarb.Text);
            int fat = Convert.ToInt32(textBoxFat.Text);
            double proteinCal, carbCal, fatCal, foodCal;

            proteinCal = protein * 4;
            carbCal = carb * 4;
            fatCal = fat * 9;

            foodCal = proteinCal + carbCal + fatCal;
            labelTotal.Text = "Total Calories: " + foodCal.ToString();
        }

    }
}
