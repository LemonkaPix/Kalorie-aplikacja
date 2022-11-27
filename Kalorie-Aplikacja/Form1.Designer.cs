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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.niezdroweLista = new System.Windows.Forms.ComboBox();
            this.zdroweLista = new System.Windows.Forms.ComboBox();
            this.FastFoods = new System.Windows.Forms.Label();
            this.healthy = new System.Windows.Forms.Label();
            this.FastFoodKalorie = new System.Windows.Forms.Label();
            this.iloscFastFoodow = new System.Windows.Forms.Label();
            this.iloscZdrowego = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FastFoodPizzaIcon2 = new System.Windows.Forms.Label();
            this.FastFoodPizzaIcon1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ZdroweKalorie = new System.Windows.Forms.Label();
            this.HealthyIcon2 = new System.Windows.Forms.Label();
            this.HealthyIcon1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.RoznicaLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // niezdroweLista
            // 
            this.niezdroweLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.niezdroweLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.niezdroweLista.FormattingEnabled = true;
            this.niezdroweLista.IntegralHeight = false;
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
            this.niezdroweLista.Location = new System.Drawing.Point(10, 47);
            this.niezdroweLista.Name = "niezdroweLista";
            this.niezdroweLista.Size = new System.Drawing.Size(238, 32);
            this.niezdroweLista.TabIndex = 0;
            this.niezdroweLista.SelectedIndexChanged += new System.EventHandler(this.changeSelection);
            // 
            // zdroweLista
            // 
            this.zdroweLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zdroweLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zdroweLista.FormattingEnabled = true;
            this.zdroweLista.IntegralHeight = false;
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
            "Mandarynka",
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
            this.zdroweLista.Location = new System.Drawing.Point(13, 47);
            this.zdroweLista.Name = "zdroweLista";
            this.zdroweLista.Size = new System.Drawing.Size(235, 32);
            this.zdroweLista.TabIndex = 1;
            this.zdroweLista.SelectedIndexChanged += new System.EventHandler(this.changeSelection);
            // 
            // FastFoods
            // 
            this.FastFoods.AutoSize = true;
            this.FastFoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FastFoods.Location = new System.Drawing.Point(77, 11);
            this.FastFoods.Name = "FastFoods";
            this.FastFoods.Size = new System.Drawing.Size(104, 24);
            this.FastFoods.TabIndex = 2;
            this.FastFoods.Text = "Fast Foody";
            // 
            // healthy
            // 
            this.healthy.AutoSize = true;
            this.healthy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.healthy.Location = new System.Drawing.Point(61, 11);
            this.healthy.Name = "healthy";
            this.healthy.Size = new System.Drawing.Size(152, 24);
            this.healthy.TabIndex = 3;
            this.healthy.Text = "Zdrowa żywność";
            // 
            // FastFoodKalorie
            // 
            this.FastFoodKalorie.AutoSize = true;
            this.FastFoodKalorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FastFoodKalorie.Location = new System.Drawing.Point(76, 132);
            this.FastFoodKalorie.Name = "FastFoodKalorie";
            this.FastFoodKalorie.Size = new System.Drawing.Size(0, 29);
            this.FastFoodKalorie.TabIndex = 4;
            // 
            // iloscFastFoodow
            // 
            this.iloscFastFoodow.AutoSize = true;
            this.iloscFastFoodow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloscFastFoodow.Location = new System.Drawing.Point(105, 93);
            this.iloscFastFoodow.Name = "iloscFastFoodow";
            this.iloscFastFoodow.Size = new System.Drawing.Size(66, 29);
            this.iloscFastFoodow.TabIndex = 5;
            this.iloscFastFoodow.Text = "100g";
            // 
            // iloscZdrowego
            // 
            this.iloscZdrowego.AutoSize = true;
            this.iloscZdrowego.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloscZdrowego.Location = new System.Drawing.Point(94, 93);
            this.iloscZdrowego.Name = "iloscZdrowego";
            this.iloscZdrowego.Size = new System.Drawing.Size(66, 29);
            this.iloscZdrowego.TabIndex = 6;
            this.iloscZdrowego.Text = "100g";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.FastFoodPizzaIcon2);
            this.panel1.Controls.Add(this.FastFoodPizzaIcon1);
            this.panel1.Controls.Add(this.FastFoodKalorie);
            this.panel1.Controls.Add(this.niezdroweLista);
            this.panel1.Controls.Add(this.iloscZdrowego);
            this.panel1.Controls.Add(this.FastFoods);
            this.panel1.Location = new System.Drawing.Point(62, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 175);
            this.panel1.TabIndex = 7;
            // 
            // FastFoodPizzaIcon2
            // 
            this.FastFoodPizzaIcon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FastFoodPizzaIcon2.ForeColor = System.Drawing.Color.Yellow;
            this.FastFoodPizzaIcon2.Location = new System.Drawing.Point(214, 0);
            this.FastFoodPizzaIcon2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FastFoodPizzaIcon2.Name = "FastFoodPizzaIcon2";
            this.FastFoodPizzaIcon2.Size = new System.Drawing.Size(34, 44);
            this.FastFoodPizzaIcon2.TabIndex = 15;
            this.FastFoodPizzaIcon2.Text = "🍕";
            // 
            // FastFoodPizzaIcon1
            // 
            this.FastFoodPizzaIcon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FastFoodPizzaIcon1.ForeColor = System.Drawing.Color.Yellow;
            this.FastFoodPizzaIcon1.Location = new System.Drawing.Point(3, 0);
            this.FastFoodPizzaIcon1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FastFoodPizzaIcon1.Name = "FastFoodPizzaIcon1";
            this.FastFoodPizzaIcon1.Size = new System.Drawing.Size(34, 44);
            this.FastFoodPizzaIcon1.TabIndex = 14;
            this.FastFoodPizzaIcon1.Text = "🍕";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Chartreuse;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.ZdroweKalorie);
            this.panel2.Controls.Add(this.HealthyIcon2);
            this.panel2.Controls.Add(this.HealthyIcon1);
            this.panel2.Controls.Add(this.zdroweLista);
            this.panel2.Controls.Add(this.healthy);
            this.panel2.Controls.Add(this.iloscFastFoodow);
            this.panel2.Location = new System.Drawing.Point(513, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 175);
            this.panel2.TabIndex = 8;
            // 
            // ZdroweKalorie
            // 
            this.ZdroweKalorie.AutoSize = true;
            this.ZdroweKalorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZdroweKalorie.Location = new System.Drawing.Point(88, 132);
            this.ZdroweKalorie.Name = "ZdroweKalorie";
            this.ZdroweKalorie.Size = new System.Drawing.Size(0, 29);
            this.ZdroweKalorie.TabIndex = 16;
            // 
            // HealthyIcon2
            // 
            this.HealthyIcon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HealthyIcon2.ForeColor = System.Drawing.Color.Red;
            this.HealthyIcon2.Location = new System.Drawing.Point(212, 0);
            this.HealthyIcon2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HealthyIcon2.Name = "HealthyIcon2";
            this.HealthyIcon2.Size = new System.Drawing.Size(44, 44);
            this.HealthyIcon2.TabIndex = 13;
            this.HealthyIcon2.Text = "🍎";
            // 
            // HealthyIcon1
            // 
            this.HealthyIcon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HealthyIcon1.ForeColor = System.Drawing.Color.Red;
            this.HealthyIcon1.Location = new System.Drawing.Point(2, 0);
            this.HealthyIcon1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HealthyIcon1.Name = "HealthyIcon1";
            this.HealthyIcon1.Size = new System.Drawing.Size(44, 44);
            this.HealthyIcon1.TabIndex = 12;
            this.HealthyIcon1.Text = "🍎";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(254, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Wybierz pożywienie z listy rozwijanej";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(-22, 50);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(794, 391);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.BlueViolet;
            this.panel4.Controls.Add(this.RoznicaLabel);
            this.panel4.Location = new System.Drawing.Point(62, 251);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(709, 137);
            this.panel4.TabIndex = 10;
            // 
            // RoznicaLabel
            // 
            this.RoznicaLabel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.RoznicaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RoznicaLabel.Location = new System.Drawing.Point(3, 0);
            this.RoznicaLabel.Name = "RoznicaLabel";
            this.RoznicaLabel.Size = new System.Drawing.Size(703, 137);
            this.RoznicaLabel.TabIndex = 17;
            this.RoznicaLabel.Text = "😀";
            this.RoznicaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator kalorii";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox niezdroweLista;
        private System.Windows.Forms.ComboBox zdroweLista;
        private System.Windows.Forms.Label FastFoods;
        private System.Windows.Forms.Label healthy;
        private System.Windows.Forms.Label FastFoodKalorie;
        private System.Windows.Forms.Label iloscFastFoodow;
        private System.Windows.Forms.Label iloscZdrowego;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label FastFoodPizzaIcon2;
        private System.Windows.Forms.Label FastFoodPizzaIcon1;
        private System.Windows.Forms.Label HealthyIcon2;
        private System.Windows.Forms.Label HealthyIcon1;
        private System.Windows.Forms.Label ZdroweKalorie;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label RoznicaLabel;
    }
}

