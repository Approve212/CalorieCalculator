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
    

    }
}
