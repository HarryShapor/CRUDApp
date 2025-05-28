using System.ComponentModel;
using System.Windows.Forms;

namespace CRUDApp
{
    partial class FormUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            this.labelNameCountryUpdate = new System.Windows.Forms.Label();
            this.textBoxNameCountryUpdate = new System.Windows.Forms.TextBox();
            this.textBoxCapitalUpdate = new System.Windows.Forms.TextBox();
            this.textBoxCountPeopleUpdate = new System.Windows.Forms.TextBox();
            this.labelNameCountry = new System.Windows.Forms.Label();
            this.labelCapital = new System.Windows.Forms.Label();
            this.labelContitnent = new System.Windows.Forms.Label();
            this.comboBoxContinentUpdate = new System.Windows.Forms.ComboBox();
            this.labelCountPeople = new System.Windows.Forms.Label();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.textBoxNameLanguageUpdate = new System.Windows.Forms.TextBox();
            this.textBoxLanguageGroupUpdate = new System.Windows.Forms.TextBox();
            this.textBoxSignSystemTypeUpdate = new System.Windows.Forms.TextBox();
            this.labelNameLanguage = new System.Windows.Forms.Label();
            this.labelLanguageGroup = new System.Windows.Forms.Label();
            this.labelSignSystemType = new System.Windows.Forms.Label();
            this.labelEtnosCountry = new System.Windows.Forms.Label();
            this.labelEtnosLanguage = new System.Windows.Forms.Label();
            this.comboBoxEtnosCountryUpdate = new System.Windows.Forms.ComboBox();
            this.comboBoxEtnosLanguageUpdate = new System.Windows.Forms.ComboBox();
            this.comboBoxYearUpdate = new System.Windows.Forms.ComboBox();
            this.textBoxStrenghtUpdate = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelStrenght = new System.Windows.Forms.Label();
            this.buttonUpdateCountry = new System.Windows.Forms.Button();
            this.buttonUpdateLanguage = new System.Windows.Forms.Button();
            this.buttonUpdateEtnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNameCountryUpdate
            // 
            this.labelNameCountryUpdate.Location = new System.Drawing.Point(20, 10);
            this.labelNameCountryUpdate.Name = "labelNameCountryUpdate";
            this.labelNameCountryUpdate.Size = new System.Drawing.Size(187, 23);
            this.labelNameCountryUpdate.TabIndex = 0;
            this.labelNameCountryUpdate.Text = "Страна";
            this.labelNameCountryUpdate.Visible = false;
            // 
            // textBoxNameCountryUpdate
            // 
            this.textBoxNameCountryUpdate.Location = new System.Drawing.Point(20, 60);
            this.textBoxNameCountryUpdate.Name = "textBoxNameCountryUpdate";
            this.textBoxNameCountryUpdate.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameCountryUpdate.TabIndex = 1;
            this.textBoxNameCountryUpdate.Visible = false;
            // 
            // textBoxCapitalUpdate
            // 
            this.textBoxCapitalUpdate.Location = new System.Drawing.Point(140, 60);
            this.textBoxCapitalUpdate.Name = "textBoxCapitalUpdate";
            this.textBoxCapitalUpdate.Size = new System.Drawing.Size(100, 20);
            this.textBoxCapitalUpdate.TabIndex = 2;
            this.textBoxCapitalUpdate.Visible = false;
            // 
            // textBoxCountPeopleUpdate
            // 
            this.textBoxCountPeopleUpdate.Location = new System.Drawing.Point(380, 60);
            this.textBoxCountPeopleUpdate.Name = "textBoxCountPeopleUpdate";
            this.textBoxCountPeopleUpdate.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountPeopleUpdate.TabIndex = 4;
            this.textBoxCountPeopleUpdate.Visible = false;
            // 
            // labelNameCountry
            // 
            this.labelNameCountry.Location = new System.Drawing.Point(20, 40);
            this.labelNameCountry.Name = "labelNameCountry";
            this.labelNameCountry.Size = new System.Drawing.Size(100, 17);
            this.labelNameCountry.TabIndex = 5;
            this.labelNameCountry.Text = "Название";
            this.labelNameCountry.Visible = false;
            // 
            // labelCapital
            // 
            this.labelCapital.Location = new System.Drawing.Point(140, 40);
            this.labelCapital.Name = "labelCapital";
            this.labelCapital.Size = new System.Drawing.Size(100, 19);
            this.labelCapital.TabIndex = 6;
            this.labelCapital.Text = "Столица";
            this.labelCapital.Visible = false;
            // 
            // labelContitnent
            // 
            this.labelContitnent.Location = new System.Drawing.Point(260, 40);
            this.labelContitnent.Name = "labelContitnent";
            this.labelContitnent.Size = new System.Drawing.Size(100, 23);
            this.labelContitnent.TabIndex = 7;
            this.labelContitnent.Text = "Материк";
            this.labelContitnent.Visible = false;
            // 
            // comboBoxContinentUpdate
            // 
            this.comboBoxContinentUpdate.FormattingEnabled = true;
            this.comboBoxContinentUpdate.Location = new System.Drawing.Point(260, 60);
            this.comboBoxContinentUpdate.Name = "comboBoxContinentUpdate";
            this.comboBoxContinentUpdate.Size = new System.Drawing.Size(100, 21);
            this.comboBoxContinentUpdate.TabIndex = 8;
            this.comboBoxContinentUpdate.Visible = false;
            this.comboBoxContinentUpdate.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // labelCountPeople
            // 
            this.labelCountPeople.Location = new System.Drawing.Point(380, 40);
            this.labelCountPeople.Name = "labelCountPeople";
            this.labelCountPeople.Size = new System.Drawing.Size(101, 19);
            this.labelCountPeople.TabIndex = 9;
            this.labelCountPeople.Text = "Количество жителей";
            this.labelCountPeople.Visible = false;
            // 
            // labelLanguage
            // 
            this.labelLanguage.Location = new System.Drawing.Point(20, 10);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(211, 19);
            this.labelLanguage.TabIndex = 10;
            this.labelLanguage.Text = "Язык";
            this.labelLanguage.Visible = false;
            // 
            // textBoxNameLanguageUpdate
            // 
            this.textBoxNameLanguageUpdate.Location = new System.Drawing.Point(20, 60);
            this.textBoxNameLanguageUpdate.Name = "textBoxNameLanguageUpdate";
            this.textBoxNameLanguageUpdate.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameLanguageUpdate.TabIndex = 11;
            this.textBoxNameLanguageUpdate.Visible = false;
            // 
            // textBoxLanguageGroupUpdate
            // 
            this.textBoxLanguageGroupUpdate.Location = new System.Drawing.Point(140, 60);
            this.textBoxLanguageGroupUpdate.Name = "textBoxLanguageGroupUpdate";
            this.textBoxLanguageGroupUpdate.Size = new System.Drawing.Size(100, 20);
            this.textBoxLanguageGroupUpdate.TabIndex = 12;
            this.textBoxLanguageGroupUpdate.Visible = false;
            // 
            // textBoxSignSystemTypeUpdate
            // 
            this.textBoxSignSystemTypeUpdate.Location = new System.Drawing.Point(260, 60);
            this.textBoxSignSystemTypeUpdate.Name = "textBoxSignSystemTypeUpdate";
            this.textBoxSignSystemTypeUpdate.Size = new System.Drawing.Size(107, 20);
            this.textBoxSignSystemTypeUpdate.TabIndex = 13;
            this.textBoxSignSystemTypeUpdate.Visible = false;
            // 
            // labelNameLanguage
            // 
            this.labelNameLanguage.Location = new System.Drawing.Point(20, 40);
            this.labelNameLanguage.Name = "labelNameLanguage";
            this.labelNameLanguage.Size = new System.Drawing.Size(88, 17);
            this.labelNameLanguage.TabIndex = 14;
            this.labelNameLanguage.Text = "Название";
            this.labelNameLanguage.Visible = false;
            // 
            // labelLanguageGroup
            // 
            this.labelLanguageGroup.Location = new System.Drawing.Point(140, 40);
            this.labelLanguageGroup.Name = "labelLanguageGroup";
            this.labelLanguageGroup.Size = new System.Drawing.Size(100, 17);
            this.labelLanguageGroup.TabIndex = 15;
            this.labelLanguageGroup.Text = "Языковая группа";
            this.labelLanguageGroup.Visible = false;
            // 
            // labelSignSystemType
            // 
            this.labelSignSystemType.Location = new System.Drawing.Point(260, 40);
            this.labelSignSystemType.Name = "labelSignSystemType";
            this.labelSignSystemType.Size = new System.Drawing.Size(137, 17);
            this.labelSignSystemType.TabIndex = 16;
            this.labelSignSystemType.Text = "Вид знаковой системы";
            this.labelSignSystemType.Visible = false;
            // 
            // labelEtnosCountry
            // 
            this.labelEtnosCountry.Location = new System.Drawing.Point(20, 10);
            this.labelEtnosCountry.Name = "labelEtnosCountry";
            this.labelEtnosCountry.Size = new System.Drawing.Size(79, 16);
            this.labelEtnosCountry.TabIndex = 17;
            this.labelEtnosCountry.Text = "Страна";
            this.labelEtnosCountry.Visible = false;
            // 
            // labelEtnosLanguage
            // 
            this.labelEtnosLanguage.Location = new System.Drawing.Point(140, 10);
            this.labelEtnosLanguage.Name = "labelEtnosLanguage";
            this.labelEtnosLanguage.Size = new System.Drawing.Size(100, 16);
            this.labelEtnosLanguage.TabIndex = 18;
            this.labelEtnosLanguage.Text = "Язык";
            this.labelEtnosLanguage.Visible = false;
            // 
            // comboBoxEtnosCountryUpdate
            // 
            this.comboBoxEtnosCountryUpdate.FormattingEnabled = true;
            this.comboBoxEtnosCountryUpdate.Location = new System.Drawing.Point(20, 40);
            this.comboBoxEtnosCountryUpdate.Name = "comboBoxEtnosCountryUpdate";
            this.comboBoxEtnosCountryUpdate.Size = new System.Drawing.Size(102, 21);
            this.comboBoxEtnosCountryUpdate.TabIndex = 19;
            this.comboBoxEtnosCountryUpdate.Visible = false;
            this.comboBoxEtnosCountryUpdate.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // comboBoxEtnosLanguageUpdate
            // 
            this.comboBoxEtnosLanguageUpdate.FormattingEnabled = true;
            this.comboBoxEtnosLanguageUpdate.Location = new System.Drawing.Point(140, 40);
            this.comboBoxEtnosLanguageUpdate.Name = "comboBoxEtnosLanguageUpdate";
            this.comboBoxEtnosLanguageUpdate.Size = new System.Drawing.Size(100, 21);
            this.comboBoxEtnosLanguageUpdate.TabIndex = 20;
            this.comboBoxEtnosLanguageUpdate.Visible = false;
            this.comboBoxEtnosLanguageUpdate.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // comboBoxYearUpdate
            // 
            this.comboBoxYearUpdate.FormattingEnabled = true;
            this.comboBoxYearUpdate.Location = new System.Drawing.Point(260, 40);
            this.comboBoxYearUpdate.Name = "comboBoxYearUpdate";
            this.comboBoxYearUpdate.Size = new System.Drawing.Size(50, 21);
            this.comboBoxYearUpdate.TabIndex = 21;
            this.comboBoxYearUpdate.Visible = false;
            this.comboBoxYearUpdate.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // textBoxStrenghtUpdate
            // 
            this.textBoxStrenghtUpdate.Location = new System.Drawing.Point(330, 40);
            this.textBoxStrenghtUpdate.Name = "textBoxStrenghtUpdate";
            this.textBoxStrenghtUpdate.Size = new System.Drawing.Size(100, 20);
            this.textBoxStrenghtUpdate.TabIndex = 22;
            this.textBoxStrenghtUpdate.Visible = false;
            // 
            // labelYear
            // 
            this.labelYear.Location = new System.Drawing.Point(260, 10);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(100, 23);
            this.labelYear.TabIndex = 23;
            this.labelYear.Text = "Год";
            this.labelYear.Visible = false;
            // 
            // labelStrenght
            // 
            this.labelStrenght.Location = new System.Drawing.Point(330, 10);
            this.labelStrenght.Name = "labelStrenght";
            this.labelStrenght.Size = new System.Drawing.Size(100, 23);
            this.labelStrenght.TabIndex = 24;
            this.labelStrenght.Text = "Численность";
            this.labelStrenght.Visible = false;
            // 
            // buttonUpdateCountry
            // 
            this.buttonUpdateCountry.Location = new System.Drawing.Point(500, 40);
            this.buttonUpdateCountry.Name = "buttonUpdateCountry";
            this.buttonUpdateCountry.Size = new System.Drawing.Size(83, 38);
            this.buttonUpdateCountry.TabIndex = 25;
            this.buttonUpdateCountry.Text = "Обновить";
            this.buttonUpdateCountry.UseVisualStyleBackColor = true;
            this.buttonUpdateCountry.Visible = false;
            this.buttonUpdateCountry.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonUpdateLanguage
            // 
            this.buttonUpdateLanguage.Location = new System.Drawing.Point(380, 57);
            this.buttonUpdateLanguage.Name = "buttonUpdateLanguage";
            this.buttonUpdateLanguage.Size = new System.Drawing.Size(100, 25);
            this.buttonUpdateLanguage.TabIndex = 26;
            this.buttonUpdateLanguage.Text = "Обновить";
            this.buttonUpdateLanguage.UseVisualStyleBackColor = true;
            this.buttonUpdateLanguage.Visible = false;
            this.buttonUpdateLanguage.Click += new System.EventHandler(this.buttonUpdateLanguage_Click);
            // 
            // buttonUpdateEtnos
            // 
            this.buttonUpdateEtnos.Location = new System.Drawing.Point(450, 40);
            this.buttonUpdateEtnos.Name = "buttonUpdateEtnos";
            this.buttonUpdateEtnos.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateEtnos.TabIndex = 27;
            this.buttonUpdateEtnos.Text = "Обновить";
            this.buttonUpdateEtnos.UseVisualStyleBackColor = true;
            this.buttonUpdateEtnos.Visible = false;
            this.buttonUpdateEtnos.Click += new System.EventHandler(this.buttonUpdateEtnos_Click);
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 97);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Controls.Add(this.buttonUpdateEtnos);
            this.Controls.Add(this.buttonUpdateLanguage);
            this.Controls.Add(this.buttonUpdateCountry);
            this.Controls.Add(this.labelStrenght);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textBoxStrenghtUpdate);
            this.Controls.Add(this.comboBoxYearUpdate);
            this.Controls.Add(this.comboBoxEtnosLanguageUpdate);
            this.Controls.Add(this.comboBoxEtnosCountryUpdate);
            this.Controls.Add(this.labelEtnosLanguage);
            this.Controls.Add(this.labelEtnosCountry);
            this.Controls.Add(this.labelSignSystemType);
            this.Controls.Add(this.labelLanguageGroup);
            this.Controls.Add(this.labelNameLanguage);
            this.Controls.Add(this.textBoxSignSystemTypeUpdate);
            this.Controls.Add(this.textBoxLanguageGroupUpdate);
            this.Controls.Add(this.textBoxNameLanguageUpdate);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.labelCountPeople);
            this.Controls.Add(this.comboBoxContinentUpdate);
            this.Controls.Add(this.labelContitnent);
            this.Controls.Add(this.labelCapital);
            this.Controls.Add(this.labelNameCountry);
            this.Controls.Add(this.textBoxCountPeopleUpdate);
            this.Controls.Add(this.textBoxCapitalUpdate);
            this.Controls.Add(this.textBoxNameCountryUpdate);
            this.Controls.Add(this.labelNameCountryUpdate);
            this.Name = "FormUpdate";
            this.Text = "Форма для обновления";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonUpdateLanguage;
        private System.Windows.Forms.Button buttonUpdateEtnos;

        private System.Windows.Forms.Button buttonUpdateCountry;

        private System.Windows.Forms.Label labelLanguageGroup;

        private System.Windows.Forms.ComboBox comboBoxYearUpdate;
        private System.Windows.Forms.TextBox textBoxStrenghtUpdate;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelStrenght;

        private System.Windows.Forms.ComboBox comboBoxEtnosCountryUpdate;
        private System.Windows.Forms.ComboBox comboBoxEtnosLanguageUpdate;

        private System.Windows.Forms.Label labelEtnosCountry;

        private System.Windows.Forms.Label labelEtnosLanguage;

        private System.Windows.Forms.TextBox textBoxNameLanguageUpdate;
        private System.Windows.Forms.TextBox textBoxLanguageGroupUpdate;
        private System.Windows.Forms.TextBox textBoxSignSystemTypeUpdate;
        private System.Windows.Forms.Label labelNameLanguage;
        private System.Windows.Forms.Label labelSignSystemType;

        private System.Windows.Forms.Label labelLanguage;

        private System.Windows.Forms.Label labelCountPeople;

        private System.Windows.Forms.ComboBox comboBoxContinentUpdate;

        private System.Windows.Forms.Label labelNameCountry;
        private System.Windows.Forms.Label labelCapital;
        private System.Windows.Forms.Label labelContitnent;

        private System.Windows.Forms.TextBox textBoxCountPeopleUpdate;

        private System.Windows.Forms.Label labelNameCountryUpdate;
        private System.Windows.Forms.TextBox textBoxNameCountryUpdate;
        private System.Windows.Forms.TextBox textBoxCapitalUpdate;

        #endregion
    }
}