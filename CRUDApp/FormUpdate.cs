using System;
using System.Linq;
using System.Windows.Forms;

namespace CRUDApp
{
    public partial class FormUpdate : Form
    {
        private string nameButton;
        private ColumnComboBox cb = new ColumnComboBox();
        private LanguageNationWorld contextLNW = new LanguageNationWorld(
            "Data Source = DESKTOP-OT35EF4\\SQLEXPRESS;"
            + "Initial Catalog=Языки_народов_мира3;"
            + "User ID =DESKTOP-OT35EF4\\HarryShapor;"
            + "Integrated Security=true;");
        public FormUpdate(string nameBtn)
        {
            this.nameButton = nameBtn;
            InitializeComponent();
            buttonUpdate.Visible = true;
            if (this.nameButton == "btnUpdateCountry")
            {
                // this.ClientSize = new System.Drawing.Size(200, 400);
                labelNameCountryUpdate.Visible = true;
                labelNameCountry.Visible = true;
                labelCapital.Visible = true;
                labelContitnent.Visible = true;
                labelCountPeople.Visible = true;
                comboBoxContinentUpdate.Visible = true;
                textBoxNameCountryUpdate.Visible = true;
                textBoxCapitalUpdate.Visible = true;
                textBoxCountPeopleUpdate.Visible = true;
                
                // this.listBoxInserted.Location = new System.Drawing.Point(29, 376);

                comboBoxContinentUpdate.Items.Add("Евразия");
                comboBoxContinentUpdate.Items.Add("Африка");
                comboBoxContinentUpdate.Items.Add("Северная Америка");
                comboBoxContinentUpdate.Items.Add("Южная Америка");
                comboBoxContinentUpdate.Items.Add("Антарктида");
                comboBoxContinentUpdate.Items.Add("Австралия");
                // comboBoxContinent.Items.Add("");
            }
            else if (this.nameButton == "buttonLanguageUpdate")
            {
                // this.ClientSize = new System.Drawing.Size(200, 330);
                labelNameLanguage.Visible = true;
                labelLanguageGroup.Visible = true;
                labelLanguage.Visible = true;
                labelSignSystemType.Visible = true;
                textBoxNameLanguageUpdate.Visible = true;
                textBoxLanguageGroupUpdate.Visible = true;
                textBoxSignSystemTypeUpdate.Visible = true;
                
                // this.listBoxInserted.Location = new System.Drawing.Point(29, 300);
            }
            else if (this.nameButton == "buttonEtnosUpdate")
            {
                // this.ClientSize = new System.Drawing.Size(200, 330);
                labelEtnosCountry.Visible = true;
                labelEtnosLanguage.Visible = true;
                labelYear.Visible = true;
                textBoxStrenghtUpdate.Visible = true;
                comboBoxYearUpdate.Visible = true;
                comboBoxEtnosCountryUpdate.Visible = true;
                comboBoxEtnosLanguageUpdate.Visible = true;
                labelStrenght.Visible = true;
                // this.listBoxInserted.Location = new System.Drawing.Point(29, 300);
                
                cb.GetColumnInComboBox("Страны", "Название", comboBoxEtnosCountryUpdate);
                cb.GetColumnInComboBox("Языки", "Название", comboBoxEtnosLanguageUpdate);
                
                foreach (var el in Enumerable.Range(1950, DateTime.UtcNow.Year - 1949).Reverse().ToList())
                {
                    comboBoxYearUpdate.Items.Add(el);
                }
            }
        }

        public FormUpdate(string nameBtn, string country, string language, string year)
        {
            this.nameButton = nameBtn;
            InitializeComponent();
            // this.ClientSize = new System.Drawing.Size(200, 330);
            labelEtnosCountry.Visible = true;
            labelEtnosLanguage.Visible = true;
            labelYear.Visible = true;
            textBoxStrenghtUpdate.Visible = true;
            comboBoxYearUpdate.Visible = true;
            comboBoxEtnosCountryUpdate.Visible = true;
            comboBoxEtnosLanguageUpdate.Visible = true;
            labelStrenght.Visible = true;
            // this.listBoxInserted.Location = new System.Drawing.Point(29, 300);
                
            comboBoxEtnosCountryUpdate.Text = country;
            comboBoxEtnosLanguageUpdate.Text = language;
            comboBoxYearUpdate.Text = year;
            
            cb.GetColumnInComboBox("Страны", "Название", comboBoxEtnosCountryUpdate);
            cb.GetColumnInComboBox("Языки", "Название", comboBoxEtnosLanguageUpdate);
                
            foreach (var el in Enumerable.Range(1950, DateTime.UtcNow.Year - 1949).Reverse().ToList())
            {
                comboBoxYearUpdate.Items.Add(el);
            }
        }
    }
}