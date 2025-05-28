using System;
using System.Linq;
using System.Windows.Forms;

namespace CRUDApp
{
    public partial class FormUpdate : Form
    {
        private MainForm form;
        private string nameButton;
        private int country;
        private int language;
        private string etnosCountry;
        private string etnosLanguage;
        private int year;
        private ColumnComboBox cb = new ColumnComboBox();
        private LanguageNationWorld contextLNW = new LanguageNationWorld(
            "Data Source = DESKTOP-OT35EF4\\SQLEXPRESS;"
            + "Initial Catalog=Языки_народов_мира3;"
            + "User ID =DESKTOP-OT35EF4\\HarryShapor;"
            + "Integrated Security=true;");
        public FormUpdate(string nameBtn, int code, MainForm form)
        {
            this.form = form;
            this.nameButton = nameBtn;
            InitializeComponent();
            if (this.nameButton == "btnUpdateCountry")
            {
                this.country = code;
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
                buttonUpdateCountry.Visible = true;
                // this.listBoxInserted.Location = new System.Drawing.Point(29, 376);
                string country = contextLNW.Страны.Where(el => el.Код == this.country)
                    .Select(el => el.Название).FirstOrDefault();
                labelNameCountryUpdate.Text = "Изменяемая страна " + country;
                textBoxNameCountryUpdate.Text = country;
                textBoxCapitalUpdate.Text = contextLNW.Страны.Where(el => el.Код == this.country)
                    .Select(el => el.Столица).FirstOrDefault();
                textBoxCountPeopleUpdate.Text = contextLNW.Страны.Where(el => el.Код == this.country) 
                    .Select(el => el.Количество_жителей).FirstOrDefault().ToString();
                comboBoxContinentUpdate.Text = contextLNW.Страны.Where(el => el.Код == this.country)
                    .Select(el => el.Материк).FirstOrDefault();
                
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
                this.language = code;
                labelNameLanguage.Visible = true;
                labelLanguageGroup.Visible = true;
                labelLanguage.Visible = true;
                labelSignSystemType.Visible = true;
                textBoxNameLanguageUpdate.Visible = true;
                textBoxLanguageGroupUpdate.Visible = true;
                textBoxSignSystemTypeUpdate.Visible = true;
                buttonUpdateLanguage.Visible = true;
                
                string language = contextLNW.Языки.Where(el => el.Код == this.language)
                    .Select(el => el.Название).FirstOrDefault();
                labelLanguage.Text = "Изменяемый язык " + language;
                textBoxNameLanguageUpdate.Text = language;
                textBoxLanguageGroupUpdate.Text = contextLNW.Языки.Where(el => el.Код == this.language)
                    .Select(el => el.Языковая_группа).FirstOrDefault();
                textBoxSignSystemTypeUpdate.Text = contextLNW.Языки.Where(el => el.Код == this.language)
                    .Select(el => el.Вид_знаковой_системы).FirstOrDefault();
                
                // this.listBoxInserted.Location = new System.Drawing.Point(29, 300);
            }
        }

        public FormUpdate(string nameBtn, string country, string language, string year, MainForm form)
        {
            this.nameButton = nameBtn;
            this.form = form;
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
            buttonUpdateEtnos.Visible = true;
            // this.listBoxInserted.Location = new System.Drawing.Point(29, 300);
                
            comboBoxEtnosCountryUpdate.Text = country;
            comboBoxEtnosLanguageUpdate.Text = language;
            comboBoxYearUpdate.Text = year;
            int yearInt = int.Parse(year);
            this.year = yearInt;
            string strenght = contextLNW.ЭтническийСостав.Where(el =>
                el.Страна == contextLNW.Страны.Where(c => c.Название == this.etnosCountry)
                    .Select(c => c.Код).FirstOrDefault()
                && el.Язык == contextLNW.Языки.Where(c => c.Название == this.etnosLanguage)
                    .Select(c => c.Код).FirstOrDefault()
                && el.Год == yearInt).Select(el => el.Численность).FirstOrDefault().ToString();
            Console.WriteLine(strenght.GetType());
            textBoxStrenghtUpdate.Text = strenght;
            
            cb.GetColumnInComboBox("Страны", "Название", comboBoxEtnosCountryUpdate);
            cb.GetColumnInComboBox("Языки", "Название", comboBoxEtnosLanguageUpdate);
                
            foreach (var el in Enumerable.Range(1950, DateTime.UtcNow.Year - 1949).Reverse().ToList())
            {
                comboBoxYearUpdate.Items.Add(el);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
                var countryUpdate = contextLNW.Страны.Where(el => el.Код == this.country).FirstOrDefault();
                if (textBoxNameCountryUpdate.Text != "")
                {
                    countryUpdate.Название = textBoxNameCountryUpdate.Text;
                }
                if (textBoxCapitalUpdate.Text != ""){
                    countryUpdate.Столица = textBoxCapitalUpdate.Text;
                }
                else
                {
                    countryUpdate.Столица = null;
                }
                if (comboBoxContinentUpdate.SelectedIndex != -1)
                {
                    countryUpdate.Материк = comboBoxContinentUpdate.Text;
                }
                if ((int.Parse(textBoxCountPeopleUpdate.Text) > 0))
                {
                    countryUpdate.Количество_жителей = int.Parse(textBoxCountPeopleUpdate.Text);
                }
                // contextLNW.Страны.Where()
                contextLNW.SaveChanges();
                MessageBox.Show("Данные успешно обновлены!");
                // form.SelectAll();
                return;
        }
        

        private void buttonUpdateLanguage_Click(object sender, EventArgs e)
        {
            var languageUpdate = contextLNW.Языки.Where(el => el.Код == this.language).FirstOrDefault();
            if (textBoxNameLanguageUpdate.Text != "")
            {
                languageUpdate.Название = textBoxNameLanguageUpdate.Text;
            }
            if (textBoxSignSystemTypeUpdate.Text != ""){
                languageUpdate.Вид_знаковой_системы = textBoxSignSystemTypeUpdate.Text;
            }
            else
            {
                languageUpdate.Вид_знаковой_системы = null;
            }
            if (textBoxLanguageGroupUpdate.Text != "")
            {
                languageUpdate.Языковая_группа = textBoxLanguageGroupUpdate.Text;
            }
            contextLNW.SaveChanges();
            form.SelectAll();
            return;
        }

        private void buttonUpdateEtnos_Click(object sender, EventArgs e)
        {
            var etnosUpdate = contextLNW.ЭтническийСостав.Where(el =>
                el.Страна == contextLNW.Страны.Where(c => c.Название == this.etnosCountry)
                    .Select(c => c.Код).FirstOrDefault()
                && el.Язык == contextLNW.Языки.Where(c => c.Название == this.etnosLanguage)
                    .Select(c => c.Код).FirstOrDefault()
                && el.Год == this.year).FirstOrDefault();
            if (comboBoxEtnosCountryUpdate.SelectedIndex != -1)
            {
                etnosUpdate.Страна = contextLNW.Страны
                    .Where(el => el.Название == comboBoxEtnosCountryUpdate.Text)
                    .Select(el => el.Код).FirstOrDefault();
            }
            if (comboBoxEtnosLanguageUpdate.SelectedIndex != -1){
                etnosUpdate.Язык = contextLNW.Языки
                    .Where(el => el.Название == comboBoxEtnosLanguageUpdate.Text)
                    .Select(el => el.Код).FirstOrDefault();
            }
            else
            if (comboBoxYearUpdate.SelectedIndex != -1)
            {
                etnosUpdate.Год = int.Parse(comboBoxYearUpdate.Text);
            }
            if (int.Parse(textBoxStrenghtUpdate.Text) > 0)
            {
                etnosUpdate.Численность = int.Parse(textBoxStrenghtUpdate.Text);
            }
            contextLNW.SaveChanges();
            form.SelectAll();
            return;
        }
    }
}