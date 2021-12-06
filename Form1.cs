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
                Message.Text = "Please Enter Food Name";
            }
            else if (textBoxServ.Text == "")
            {
                Message.Text = "Please Enter Serving Amount";
            }
            else if (textBoxProtein.Text == "")
            {
                Message.Text = "Please Enter Proteins in grams";
            }
            else if (textBoxCarb.Text == "")
            {
                Message.Text = "Please Enter Carbs in grams";
            }
            else if (textBoxFat.Text == "")
            {
                Message.Text = "Please Enter Fat in grams";
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
        private void calculateButton_Click(object sender, EventArgs e)
        {
            string gender, exercise;
            double height, weight, age, malebr, femalebr; //variables
            decimal bmrult;
            
            //personal information
            height = double.Parse(heightTextBox.Text);
            weight = double.Parse(weightTextBox.Text);
            age = double.Parse(ageTextBox.Text);
            //select gender
            if (genderList.SelectedIndex !=-1)
           {
                gender = genderList.SelectedItem.ToString();
                switch(gender)
                {  
                    case "Male":
                        //perform calculation
                        malebmr = weight * 10 + height * 6.25 - age * 5 - 5);
                        calories = malebmr * bmrmult;
                        bmrDisplay.Text = ("Your base metabolic rate burns " + calories+
                        break;
                    case "Female"
                        femalebmr = weight * 10 + height * 6.25 - age * 5 - 161;
                        MessageBox.Show("You should eat:" + femalebmr + "calories");
                        break;
                 }
            }
            if (exerciseList.SelectedIndex !=-1)
            {
                string exercise;
                exercise = exerciseList.SelectedItem.ToString();
                switch (exercise)
                {
                                    case "Light exercise (1–3 days per week)":
                                    bmrmult = (int)1.375m;
                                    break;
                                    case "Moderate exercise (3–5 days per week)":
                                    bmrmult = (int)1.55m;
                                    break;
                                    case "Heavy exercise (6–7 days per week)":
                                    bmrmult = (int)1.725m;
                                    break;
                                    case "Very heavy exercise (twice per day, extra heavy workouts)":
                                    bmrmult = (int)1.9m;
                                    break;
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
