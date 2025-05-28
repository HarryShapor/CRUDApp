namespace CRUDApp
{
    partial class FormInsert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                labelNameCountry.Visible = false;
                labelCapital.Visible = false;
                labelContinent.Visible = false;
                labelCountPeople.Visible = false;
                comboBoxContinent.Visible = false;
                textBoxNameCountry.Visible = false;
                textBoxCapital.Visible = false;
                textBoxCountPeople.Visible = false;
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEtnosInsert = new System.Windows.Forms.Button();
            this.textBoxStrenght = new System.Windows.Forms.TextBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxEtnosLanguage = new System.Windows.Forms.ComboBox();
            this.comboBoxEtnosCountry = new System.Windows.Forms.ComboBox();
            this.labelEtnosCountry = new System.Windows.Forms.Label();
            this.labelEtnosLanguage = new System.Windows.Forms.Label();
            this.labelStrenght = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxNameCountry = new System.Windows.Forms.TextBox();
            this.labelNameCountry = new System.Windows.Forms.Label();
            this.labelCapital = new System.Windows.Forms.Label();
            this.labelContinent = new System.Windows.Forms.Label();
            this.labelCountPeople = new System.Windows.Forms.Label();
            this.comboBoxContinent = new System.Windows.Forms.ComboBox();
            this.textBoxCapital = new System.Windows.Forms.TextBox();
            this.textBoxCountPeople = new System.Windows.Forms.TextBox();
            this.btnCountryInsert = new System.Windows.Forms.Button();
            this.labelNameLanguage = new System.Windows.Forms.Label();
            this.textBoxNameLanguage = new System.Windows.Forms.TextBox();
            this.labelLanguageGroup = new System.Windows.Forms.Label();
            this.labelTypeSignSystem = new System.Windows.Forms.Label();
            this.textBoxLanguageGroup = new System.Windows.Forms.TextBox();
            this.textBoxTypeSignSystem = new System.Windows.Forms.TextBox();
            this.btnLanguageInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEtnosInsert
            // 
            this.btnEtnosInsert.Location = new System.Drawing.Point(30, 230);
            this.btnEtnosInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnEtnosInsert.Name = "btnEtnosInsert";
            this.btnEtnosInsert.Size = new System.Drawing.Size(90, 25);
            this.btnEtnosInsert.TabIndex = 16;
            this.btnEtnosInsert.Text = "Добавить";
            this.btnEtnosInsert.UseVisualStyleBackColor = true;
            this.btnEtnosInsert.Visible = false;
            this.btnEtnosInsert.Click += new System.EventHandler(this.btnEtnosInsert_Click);
            // 
            // textBoxStrenght
            // 
            this.textBoxStrenght.Location = new System.Drawing.Point(28, 200);
            this.textBoxStrenght.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStrenght.Name = "textBoxStrenght";
            this.textBoxStrenght.Size = new System.Drawing.Size(91, 20);
            this.textBoxStrenght.TabIndex = 23;
            this.textBoxStrenght.Visible = false;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.Location = new System.Drawing.Point(30, 150);
            this.comboBoxYear.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(91, 21);
            this.comboBoxYear.TabIndex = 22;
            this.comboBoxYear.Visible = false;
            // 
            // comboBoxEtnosLanguage
            // 
            this.comboBoxEtnosLanguage.Location = new System.Drawing.Point(30, 100);
            this.comboBoxEtnosLanguage.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxEtnosLanguage.Name = "comboBoxEtnosLanguage";
            this.comboBoxEtnosLanguage.Size = new System.Drawing.Size(91, 21);
            this.comboBoxEtnosLanguage.TabIndex = 21;
            this.comboBoxEtnosLanguage.Visible = false;
            // 
            // comboBoxEtnosCountry
            // 
            this.comboBoxEtnosCountry.Location = new System.Drawing.Point(30, 50);
            this.comboBoxEtnosCountry.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxEtnosCountry.Name = "comboBoxEtnosCountry";
            this.comboBoxEtnosCountry.Size = new System.Drawing.Size(91, 21);
            this.comboBoxEtnosCountry.TabIndex = 20;
            this.comboBoxEtnosCountry.Visible = false;
            // 
            // labelEtnosCountry
            // 
            this.labelEtnosCountry.Location = new System.Drawing.Point(30, 20);
            this.labelEtnosCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEtnosCountry.Name = "labelEtnosCountry";
            this.labelEtnosCountry.Size = new System.Drawing.Size(150, 18);
            this.labelEtnosCountry.TabIndex = 17;
            this.labelEtnosCountry.Text = "Выберите страну";
            this.labelEtnosCountry.Visible = false;
            // 
            // labelEtnosLanguage
            // 
            this.labelEtnosLanguage.Location = new System.Drawing.Point(30, 80);
            this.labelEtnosLanguage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEtnosLanguage.Name = "labelEtnosLanguage";
            this.labelEtnosLanguage.Size = new System.Drawing.Size(90, 18);
            this.labelEtnosLanguage.TabIndex = 18;
            this.labelEtnosLanguage.Text = "Выберите язык";
            this.labelEtnosLanguage.Visible = false;
            // 
            // labelStrenght
            // 
            this.labelStrenght.Location = new System.Drawing.Point(25, 180);
            this.labelStrenght.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStrenght.Name = "labelStrenght";
            this.labelStrenght.Size = new System.Drawing.Size(200, 18);
            this.labelStrenght.TabIndex = 23;
            this.labelStrenght.Text = "Введите численность населения";
            this.labelStrenght.Visible = false;
            // 
            // labelYear
            // 
            this.labelYear.Location = new System.Drawing.Point(30, 130);
            this.labelYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(90, 18);
            this.labelYear.TabIndex = 19;
            this.labelYear.Text = "Выбери год";
            this.labelYear.Visible = false;
            // 
            // textBoxNameCountry
            // 
            this.textBoxNameCountry.Location = new System.Drawing.Point(30, 50);
            this.textBoxNameCountry.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNameCountry.Name = "textBoxNameCountry";
            this.textBoxNameCountry.Size = new System.Drawing.Size(76, 20);
            this.textBoxNameCountry.TabIndex = 0;
            this.textBoxNameCountry.Visible = false;
            // 
            // labelNameCountry
            // 
            this.labelNameCountry.AutoSize = true;
            this.labelNameCountry.Location = new System.Drawing.Point(30, 20);
            this.labelNameCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameCountry.Name = "labelNameCountry";
            this.labelNameCountry.Size = new System.Drawing.Size(97, 13);
            this.labelNameCountry.TabIndex = 1;
            this.labelNameCountry.Text = "Название страны";
            this.labelNameCountry.Visible = false;
            // 
            // labelCapital
            // 
            this.labelCapital.AutoSize = true;
            this.labelCapital.Location = new System.Drawing.Point(30, 80);
            this.labelCapital.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCapital.Name = "labelCapital";
            this.labelCapital.Size = new System.Drawing.Size(49, 13);
            this.labelCapital.TabIndex = 2;
            this.labelCapital.Text = "Столица";
            this.labelCapital.Visible = false;
            // 
            // labelContinent
            // 
            this.labelContinent.AutoSize = true;
            this.labelContinent.Location = new System.Drawing.Point(30, 130);
            this.labelContinent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContinent.Name = "labelContinent";
            this.labelContinent.Size = new System.Drawing.Size(51, 13);
            this.labelContinent.TabIndex = 3;
            this.labelContinent.Text = "Материк";
            this.labelContinent.Visible = false;
            // 
            // labelCountPeople
            // 
            this.labelCountPeople.AutoSize = true;
            this.labelCountPeople.Location = new System.Drawing.Point(30, 180);
            this.labelCountPeople.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountPeople.Name = "labelCountPeople";
            this.labelCountPeople.Size = new System.Drawing.Size(138, 13);
            this.labelCountPeople.TabIndex = 4;
            this.labelCountPeople.Text = "Количество жителей, млн";
            this.labelCountPeople.Visible = false;
            // 
            // comboBoxContinent
            // 
            this.comboBoxContinent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContinent.FormattingEnabled = true;
            this.comboBoxContinent.Location = new System.Drawing.Point(30, 150);
            this.comboBoxContinent.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxContinent.Name = "comboBoxContinent";
            this.comboBoxContinent.Size = new System.Drawing.Size(92, 21);
            this.comboBoxContinent.TabIndex = 5;
            this.comboBoxContinent.Visible = false;
            // 
            // textBoxCapital
            // 
            this.textBoxCapital.Location = new System.Drawing.Point(30, 100);
            this.textBoxCapital.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCapital.Name = "textBoxCapital";
            this.textBoxCapital.Size = new System.Drawing.Size(76, 20);
            this.textBoxCapital.TabIndex = 6;
            this.textBoxCapital.Visible = false;
            // 
            // textBoxCountPeople
            // 
            this.textBoxCountPeople.Location = new System.Drawing.Point(30, 200);
            this.textBoxCountPeople.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCountPeople.Name = "textBoxCountPeople";
            this.textBoxCountPeople.Size = new System.Drawing.Size(76, 20);
            this.textBoxCountPeople.TabIndex = 7;
            this.textBoxCountPeople.Visible = false;
            // 
            // btnCountryInsert
            // 
            this.btnCountryInsert.Location = new System.Drawing.Point(30, 230);
            this.btnCountryInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnCountryInsert.Name = "btnCountryInsert";
            this.btnCountryInsert.Size = new System.Drawing.Size(90, 25);
            this.btnCountryInsert.TabIndex = 8;
            this.btnCountryInsert.Text = "Добавить";
            this.btnCountryInsert.UseVisualStyleBackColor = true;
            this.btnCountryInsert.Visible = false;
            this.btnCountryInsert.Click += new System.EventHandler(this.btnCountryInsert_Click);
            // 
            // labelNameLanguage
            // 
            this.labelNameLanguage.AutoSize = true;
            this.labelNameLanguage.Location = new System.Drawing.Point(30, 20);
            this.labelNameLanguage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameLanguage.Name = "labelNameLanguage";
            this.labelNameLanguage.Size = new System.Drawing.Size(92, 13);
            this.labelNameLanguage.TabIndex = 9;
            this.labelNameLanguage.Text = "Название языка";
            this.labelNameLanguage.Visible = false;
            // 
            // textBoxNameLanguage
            // 
            this.textBoxNameLanguage.Location = new System.Drawing.Point(30, 50);
            this.textBoxNameLanguage.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNameLanguage.Name = "textBoxNameLanguage";
            this.textBoxNameLanguage.Size = new System.Drawing.Size(76, 20);
            this.textBoxNameLanguage.TabIndex = 10;
            this.textBoxNameLanguage.Visible = false;
            // 
            // labelLanguageGroup
            // 
            this.labelLanguageGroup.AutoSize = true;
            this.labelLanguageGroup.Location = new System.Drawing.Point(30, 80);
            this.labelLanguageGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLanguageGroup.Name = "labelLanguageGroup";
            this.labelLanguageGroup.Size = new System.Drawing.Size(96, 13);
            this.labelLanguageGroup.TabIndex = 11;
            this.labelLanguageGroup.Text = "Языковая группа";
            this.labelLanguageGroup.Visible = false;
            // 
            // labelTypeSignSystem
            // 
            this.labelTypeSignSystem.AutoSize = true;
            this.labelTypeSignSystem.Location = new System.Drawing.Point(30, 130);
            this.labelTypeSignSystem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTypeSignSystem.Name = "labelTypeSignSystem";
            this.labelTypeSignSystem.Size = new System.Drawing.Size(125, 13);
            this.labelTypeSignSystem.TabIndex = 12;
            this.labelTypeSignSystem.Text = "Вид знаковой системы";
            this.labelTypeSignSystem.Visible = false;
            // 
            // textBoxLanguageGroup
            // 
            this.textBoxLanguageGroup.Location = new System.Drawing.Point(30, 100);
            this.textBoxLanguageGroup.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLanguageGroup.Name = "textBoxLanguageGroup";
            this.textBoxLanguageGroup.Size = new System.Drawing.Size(76, 20);
            this.textBoxLanguageGroup.TabIndex = 13;
            this.textBoxLanguageGroup.Visible = false;
            // 
            // textBoxTypeSignSystem
            // 
            this.textBoxTypeSignSystem.Location = new System.Drawing.Point(30, 150);
            this.textBoxTypeSignSystem.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTypeSignSystem.Name = "textBoxTypeSignSystem";
            this.textBoxTypeSignSystem.Size = new System.Drawing.Size(91, 20);
            this.textBoxTypeSignSystem.TabIndex = 14;
            this.textBoxTypeSignSystem.Visible = false;
            // 
            // btnLanguageInsert
            // 
            this.btnLanguageInsert.Location = new System.Drawing.Point(30, 180);
            this.btnLanguageInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnLanguageInsert.Name = "btnLanguageInsert";
            this.btnLanguageInsert.Size = new System.Drawing.Size(90, 25);
            this.btnLanguageInsert.TabIndex = 15;
            this.btnLanguageInsert.Text = "Добавить";
            this.btnLanguageInsert.UseVisualStyleBackColor = true;
            this.btnLanguageInsert.Visible = false;
            this.btnLanguageInsert.Click += new System.EventHandler(this.btnLanguageInsert_Click);
            // 
            // FormInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(191, 364);
            this.Controls.Add(this.btnLanguageInsert);
            this.Controls.Add(this.textBoxTypeSignSystem);
            this.Controls.Add(this.textBoxLanguageGroup);
            this.Controls.Add(this.labelTypeSignSystem);
            this.Controls.Add(this.labelLanguageGroup);
            this.Controls.Add(this.textBoxNameLanguage);
            this.Controls.Add(this.labelNameLanguage);
            this.Controls.Add(this.btnCountryInsert);
            this.Controls.Add(this.textBoxCountPeople);
            this.Controls.Add(this.textBoxCapital);
            this.Controls.Add(this.comboBoxContinent);
            this.Controls.Add(this.labelCountPeople);
            this.Controls.Add(this.labelContinent);
            this.Controls.Add(this.labelCapital);
            this.Controls.Add(this.labelNameCountry);
            this.Controls.Add(this.textBoxNameCountry);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelStrenght);
            this.Controls.Add(this.labelEtnosLanguage);
            this.Controls.Add(this.labelEtnosCountry);
            this.Controls.Add(this.comboBoxEtnosCountry);
            this.Controls.Add(this.comboBoxEtnosLanguage);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.textBoxStrenght);
            this.Controls.Add(this.btnEtnosInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormInsert";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnLanguageInsert;

        #endregion

        private System.Windows.Forms.TextBox textBoxNameCountry;
        private System.Windows.Forms.Label labelNameCountry;
        private System.Windows.Forms.Label labelCapital;
        private System.Windows.Forms.Label labelContinent;
        private System.Windows.Forms.Label labelCountPeople;
        private System.Windows.Forms.Label labelEtnosCountry;
        private System.Windows.Forms.Label labelEtnosLanguage;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelStrenght;
        private System.Windows.Forms.ComboBox comboBoxContinent;
        private System.Windows.Forms.ComboBox comboBoxEtnosCountry;
        private System.Windows.Forms.ComboBox comboBoxEtnosLanguage;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.TextBox textBoxCapital;
        private System.Windows.Forms.TextBox textBoxCountPeople;
        private System.Windows.Forms.TextBox textBoxStrenght;
        private System.Windows.Forms.Button btnCountryInsert;
        private System.Windows.Forms.Label labelNameLanguage;
        private System.Windows.Forms.TextBox textBoxNameLanguage;
        private System.Windows.Forms.Label labelLanguageGroup;
        private System.Windows.Forms.Label labelTypeSignSystem;
        private System.Windows.Forms.TextBox textBoxLanguageGroup;
        private System.Windows.Forms.TextBox textBoxTypeSignSystem;
        private System.Windows.Forms.Button btnEtnosInsert;
    }
}