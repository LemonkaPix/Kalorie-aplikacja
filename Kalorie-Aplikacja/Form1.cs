using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalorie_Aplikacja
{
    public partial class Form1 : Form
    {

        List<Label> calorieLabels = new List<Label>();
        public Form1()
        {
            InitializeComponent();
            calorieLabels.Add(FastFoodKalorie);
            calorieLabels.Add(ZdroweKalorie);
        }


        private double countDifference(Food fastFood, Food healthyFood)
        {
            
            double difference = fastFood.calories / healthyFood.calories;
            difference = Math.Round(difference, 1);

            return difference;
        }


        private void changeSelection(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            int index = comboBox.TabIndex;
            switch (index)
            {
                case 0:
                    {
                        Food unHealthyFood = foodData.fastFoodFoodData.Find(x => x.name.Trim().Equals(comboBox.Text.Trim()));
                        calorieLabels[index].Text = $"{Convert.ToString(unHealthyFood.calories)}kcal";

                        if (zdroweLista.SelectedIndex != -1)
                        {
                            Food healthyFood = foodData.healthyFoodFoodData.Find(x => x.name.Trim().Equals(zdroweLista.Text.Trim()));
                            string differenceText = $"100g  {unHealthyFood.name} ma tyle samo kalorii co {100 * countDifference(unHealthyFood, healthyFood)}g {healthyFood.name}";

                            RoznicaLabel.Text = differenceText;
                        }
                    }
                    break;

                case 1:
                    {
                        Food healthyFood = foodData.healthyFoodFoodData.Find(x => x.name.Trim().Equals(comboBox.Text.Trim()));
                        calorieLabels[index].Text = $"{Convert.ToString(healthyFood.calories)}kcal";

                        if(niezdroweLista.SelectedIndex != -1)
                        {
                            Food unHealthyFood = foodData.fastFoodFoodData.Find(x => x.name.Trim().Equals(niezdroweLista.Text.Trim()));
                            string differenceText = $"100g {unHealthyFood.name} ma tyle samo kalorii co {100 * countDifference(unHealthyFood, healthyFood)}g {healthyFood.name}";

                            RoznicaLabel.Text = differenceText;
                        }
                    }
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
