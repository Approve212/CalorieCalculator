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
    public class Food
    {
        int protein, carb, fat;
    }

    public partial class Form1 : Form
    {
        
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
            calcCalorie(food);
        }
    }
}
