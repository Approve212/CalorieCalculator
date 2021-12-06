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
        public MainScreen mainScreen;
        public class Food
        {
            //Need to fix
            public string Name { get; set; }
            public string Type { get; set; }
            public int Serving { get; set; }
            public int Protein { get; set; }
            public int Carb { get; set; }
            public int Fat { get; set; }
            public int TotalCal { get; set; }
            public DateTime Day { get; set; }
            public override string ToString()
            {
                return "Name: " + Name + " Servings: " + Serving + ", Total Calories: " + TotalCal + "\n";
            }
        }

        int CalcCalorie(Food food)
        {
            int proteinCal, carbCal, fatCal, serv, foodCal, totalCal;

            proteinCal = food.Protein * 4;
            carbCal = food.Carb * 4;
            fatCal = food.Fat * 9;
            serv = food.Serving;

            foodCal = proteinCal + carbCal + fatCal;
            totalCal = foodCal * serv;
            return totalCal;
        }

        public Form1()
        {
            InitializeComponent();
            comboBoxType.Text = "Meat";
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (textName.Text == "")
            {
                MessageBox.Show("Please Enter Food Name");
            }
            else if (textBoxServ.Text == "")
            {
                MessageBox.Show("Please Enter Serving Amount");
            }
            else if (textBoxProtein.Text == "")
            {
                MessageBox.Show("Please Enter Proteins in grams");
            }
            else if (textBoxCarb.Text == "")
            {
                MessageBox.Show("Please Enter Carbs in grams");
            }
            else if (textBoxFat.Text == "")
            {
                MessageBox.Show("Please Enter Fat in grams");
            }

            else
            {
                int protein = Convert.ToInt32(textBoxProtein.Text);
                int carb = Convert.ToInt32(textBoxCarb.Text);
                int fat = Convert.ToInt32(textBoxFat.Text);
                int serv = Convert.ToInt32(textBoxServ.Text);

                Food food = new Food();

                food.Name = textName.Text;
                food.Type = comboBoxType.Text;
                food.Serving = serv;
                food.Protein = protein;
                food.Carb = carb;
                food.Fat = fat;
                food.Day = dateTimePickerDay.Value.Date;

                int totalCal = CalcCalorie(food);

                food.TotalCal = totalCal;

                mainScreen.addFood(food);

                labelCalc.Text = food.Name + " entered for " + food.Day;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainScreen.Enabled = true;
        }
    }
}