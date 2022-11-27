namespace Kalorie_Aplikacja
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        FoodData foodData = new FoodData();

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.niezdroweLista = new System.Windows.Forms.ComboBox();
            this.zdroweLista = new System.Windows.Forms.ComboBox();
            this.FastFoods = new System.Windows.Forms.Label();
            this.healthy = new System.Windows.Forms.Label();
            this.kalorie = new System.Windows.Forms.Label();
            this.iloscFastFoodow = new System.Windows.Forms.Label();
            this.iloscZdrowego = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // niezdroweLista
            // 
            this.niezdroweLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.niezdroweLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.niezdroweLista.FormattingEnabled = true;
            this.niezdroweLista.Items.AddRange(new object[] {
            "Big Mac z McDonald’s",
            "Brazer kanapka z KFC",
            "Burger wegetariański",
            "Cheeseburger\t",
            "Falafel\t\t",
            "Frytki\t\t",
            "Grander z KFC\t",
            "Hamburger\t",
            "Hot dog\t\t",
            "Indyk\t\t",
            "Kanapka z klopsikami",
            "Kanapka z kurczakiem",
            "Kanapka z rybą\t",
            "Kanapka z szynką",
            "Kebab\t\t",
            "Kiełbasa\t",
            "Kotlet wegetariański",
            "Krokiet\t\t",
            "Krążki cebulowe\t",
            "Lazania\t\t",
            "Nachos z serem\t",
            "Nuggetsy z kurczaka",
            "Piersi z kurczaka",
            "Skrzydełka z kurczaka",
            "Tortilla Wrap\t",
            "Tuńczyk\t",
            "Whopper z Burger King",
            "Wieśmac z McDonald’s",
            "Zapiekanka\t",
            "Zinger z KFC\t",
            "Żeberka grillowane"});
            this.niezdroweLista.Location = new System.Drawing.Point(16, 87);
            this.niezdroweLista.Margin = new System.Windows.Forms.Padding(4);
            this.niezdroweLista.Name = "niezdroweLista";
            this.niezdroweLista.Size = new System.Drawing.Size(332, 37);
            this.niezdroweLista.TabIndex = 0;
            this.niezdroweLista.SelectedIndexChanged += new System.EventHandler(this.changeSelection);
            // 
            // zdroweLista
            // 
            this.zdroweLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zdroweLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zdroweLista.FormattingEnabled = true;
            this.zdroweLista.Items.AddRange(new object[] {
            "Pomidor\t",
            "Banan\t",
            "Cebula\t",
            "Jabłko\t",
            "Marchew ",
            "Ogórek\t",
            "Chleb żytni",
            "Sałata\t",
            "Papryka ",
            "Rzodkiewka",
            "Miód\t",
            "Ziemniaki",
            "Kurczak ",
            "Awokado\t",
            "Kiwi \t",
            "Jajko \t",
            "Pomarańcza",
            "Gruszka\t",
            "Brokuły\t",
            "Sałata lodowa",
            "Mandaynka",
            "Kukurydza",
            "Truskawki",
            "Kalafior ",
            "Masło \t",
            "Por\t",
            "Chleb\t",
            "Musztarda",
            "Cytryna\t",
            "Mleko\t",
            "Ketchup\t",
            "Mango \t",
            "Grejpfrut",
            "Arbuz \t",
            "Ananas\t",
            "Burak \t",
            "Nektarynka",
            "Jajecznica "});
            this.zdroweLista.Location = new System.Drawing.Point(707, 89);
            this.zdroweLista.Margin = new System.Windows.Forms.Padding(4);
            this.zdroweLista.Name = "zdroweLista";
            this.zdroweLista.Size = new System.Drawing.Size(332, 37);
            this.zdroweLista.TabIndex = 1;
            this.zdroweLista.SelectedIndexChanged += new System.EventHandler(this.changeSelection);
            // 
            // FastFoods
            // 
            this.FastFoods.AutoSize = true;
            this.FastFoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FastFoods.Location = new System.Drawing.Point(104, 54);
            this.FastFoods.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FastFoods.Name = "FastFoods";
            this.FastFoods.Size = new System.Drawing.Size(133, 29);
            this.FastFoods.TabIndex = 2;
            this.FastFoods.Text = "Fast Foody";
            // 
            // healthy
            // 
            this.healthy.AutoSize = true;
            this.healthy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.healthy.Location = new System.Drawing.Point(765, 54);
            this.healthy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.healthy.Name = "healthy";
            this.healthy.Size = new System.Drawing.Size(191, 29);
            this.healthy.TabIndex = 3;
            this.healthy.Text = "Zdrowa żywność";
            // 
            // kalorie
            // 
            this.kalorie.AutoSize = true;
            this.kalorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kalorie.Location = new System.Drawing.Point(451, 143);
            this.kalorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kalorie.Name = "kalorie";
            this.kalorie.Size = new System.Drawing.Size(136, 36);
            this.kalorie.TabIndex = 4;
            this.kalorie.Text = "2137kcal";
            // 
            // iloscFastFoodow
            // 
            this.iloscFastFoodow.AutoSize = true;
            this.iloscFastFoodow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloscFastFoodow.Location = new System.Drawing.Point(119, 183);
            this.iloscFastFoodow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iloscFastFoodow.Name = "iloscFastFoodow";
            this.iloscFastFoodow.Size = new System.Drawing.Size(83, 36);
            this.iloscFastFoodow.TabIndex = 5;
            this.iloscFastFoodow.Text = "100g";
            // 
            // iloscZdrowego
            // 
            this.iloscZdrowego.AutoSize = true;
            this.iloscZdrowego.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloscZdrowego.Location = new System.Drawing.Point(815, 183);
            this.iloscZdrowego.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iloscZdrowego.Name = "iloscZdrowego";
            this.iloscZdrowego.Size = new System.Drawing.Size(83, 36);
            this.iloscZdrowego.TabIndex = 6;
            this.iloscZdrowego.Text = "100g";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.iloscZdrowego);
            this.Controls.Add(this.iloscFastFoodow);
            this.Controls.Add(this.kalorie);
            this.Controls.Add(this.healthy);
            this.Controls.Add(this.FastFoods);
            this.Controls.Add(this.zdroweLista);
            this.Controls.Add(this.niezdroweLista);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Kalkulator kalorii";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox niezdroweLista;
        private System.Windows.Forms.ComboBox zdroweLista;
        private System.Windows.Forms.Label FastFoods;
        private System.Windows.Forms.Label healthy;
        private System.Windows.Forms.Label kalorie;
        private System.Windows.Forms.Label iloscFastFoodow;
        private System.Windows.Forms.Label iloscZdrowego;
    }
}

