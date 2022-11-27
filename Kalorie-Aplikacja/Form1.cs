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
        public Form1()
        {
            InitializeComponent();
        }

        private void changeSelection(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            int index = comboBox.TabIndex;

            Food part = (foodData.fastFoodFoodData.Find(x => x.name.Equals("Indyk")));

            MessageBox.Show(part.name);

            if(index == 0 && zdroweLista.SelectedIndex != -1)
            {
                //MessageBox.Show(foodData.fastFoodFoodData.Find(x => x.name.Contains(comboBox.Text)).ToString());
            }

        }

    }
}
