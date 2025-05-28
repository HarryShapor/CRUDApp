using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDApp
{
    public partial class FormInsert : Form
    {
        private string nameButton;
        private MainForm form;
        private ColumnComboBox cb = new ColumnComboBox();
        private LanguageNationWorld contextLNW = new LanguageNationWorld(
            "Data Source = DESKTOP-OT35EF4\\SQLEXPRESS;"
                   + "Initial Catalog=Языки_народов_мира3;"
                   + "User ID =DESKTOP-OT35EF4\\HarryShapor;"
                   + "Integrated Security=true;");
        public FormInsert(string nameBtn, MainForm form)
        {
            this.form = form;
            this.nameButton = nameBtn;
            InitializeComponent();
            if (this.nameButton == "btnInsertCountry")
            {
                this.ClientSize = new System.Drawing.Size(200, 260);
                labelNameCountry.Visible = true;
                labelCapital.Visible = true;
                labelContinent.Visible = true;
                labelCountPeople.Visible = true;
                comboBoxContinent.Visible = true;
                textBoxNameCountry.Visible = true;
                textBoxCapital.Visible = true;
                textBoxCountPeople.Visible = true;
                btnCountryInsert.Visible = true;

                comboBoxContinent.Items.Add("Евразия");
                comboBoxContinent.Items.Add("Африка");
                comboBoxContinent.Items.Add("Северная Америка");
                comboBoxContinent.Items.Add("Южная Америка");
                comboBoxContinent.Items.Add("Антарктида");
                comboBoxContinent.Items.Add("Австралия");
                comboBoxContinent.Items.Add("");
            }
            else if (this.nameButton == "btnInsertLanguage")
            {
                this.ClientSize = new System.Drawing.Size(200, 260);
                labelNameLanguage.Visible = true;
                labelLanguageGroup.Visible = true;
                labelTypeSignSystem.Visible = true;
                textBoxTypeSignSystem.Visible = true;
                textBoxNameLanguage.Visible = true;
                textBoxLanguageGroup.Visible = true;
                btnLanguageInsert.Visible = true;
            }
            else if (this.nameButton == "btnInsertEtnos")
            {
                this.ClientSize = new System.Drawing.Size(200, 280);
                labelEtnosCountry.Visible = true;
                labelEtnosLanguage.Visible = true;
                labelYear.Visible = true;
                textBoxStrenght.Visible = true;
                comboBoxEtnosLanguage.Visible = true;
                comboBoxYear.Visible = true;
                comboBoxEtnosCountry.Visible = true;
                btnEtnosInsert.Visible = true;
                labelStrenght.Visible = true;
                
                cb.GetColumnInComboBox("Страны", "Название", comboBoxEtnosCountry);
                cb.GetColumnInComboBox("Языки", "Название", comboBoxEtnosLanguage);
                
                foreach (var el in Enumerable.Range(1950, DateTime.UtcNow.Year - 1949).Reverse().ToList())
                {
                    comboBoxYear.Items.Add(el);
                }
            }
        }
        
        private void btnCountryInsert_Click(object sender, EventArgs e)
        {
            int countPeople = Convert.ToInt32(textBoxCountPeople.Text);
            if (countPeople <= 0)
            {
                MessageBox.Show("Количество жителей должно быть положительным!");
                return;
            }
            if (IsOnlyLetters(textBoxNameCountry.Text) && IsOnlyLetters(textBoxCapital.Text))
            {
                string continent = comboBoxContinent.Text == "" ? null : comboBoxContinent.Text;
                var country = new Страны
                {
                            Название = textBoxNameCountry.Text,
                            Столица = textBoxCapital.Text,
                            Материк = continent,
                            Количество_жителей = Convert.ToInt32(textBoxCountPeople.Text)
                        };
                        if (contextLNW.Страны.Where(el => el.Название == country.Название).ToList().Count == 0)
                        {
                            contextLNW.Страны.Add(country);
                            contextLNW.SaveChanges();
                            MessageBox.Show("Новая страна успешно добавлена!");
                            form.SelectAll();
                        }
                        else
                        {
                            MessageBox.Show("Такая страна уже есть!");
                        }
                        return;
            }
            else
            {
                MessageBox.Show("Поля содержат запрещенные символы!");
                return;
            }
        }

        private void btnLanguageInsert_Click(object sender, EventArgs e)
        {
            if (IsOnlyLetters(textBoxNameLanguage.Text) && IsOnlyLetters(textBoxLanguageGroup.Text)
                                                        && IsOnlyLetters(textBoxTypeSignSystem.Text))
            {
                var language = new Языки
                {
                    Название = textBoxNameLanguage.Text,
                    Языковая_группа = textBoxLanguageGroup.Text,
                    Вид_знаковой_системы = textBoxTypeSignSystem.Text,
                };
                if (contextLNW.Языки.Where(el => el.Название == language.Название).ToList().Count == 0)
                {
                    contextLNW.Языки.Add(language);
                    contextLNW.SaveChanges();
                    MessageBox.Show("Новый язык успешно добавлен!");
                    form.SelectAll();
                }
                else
                {
                    MessageBox.Show("Такой язык уже есть!");
                }
                return;
            }
            else
            {
                MessageBox.Show("Поля содержат запрещенные символы!");
                return;
            }
        }
        

        private void btnEtnosInsert_Click(object sender, EventArgs e)
        {
            int strenght = Convert.ToInt32(textBoxStrenght.Text);
            if (strenght <= 0)
            {
                MessageBox.Show("Количество жителей должно быть положительным!");
                return;
            }
            var etnos = new ЭтническийСостав
            {
                Страна = Convert.ToInt32(contextLNW.Страны.Where(el => el.Название == comboBoxEtnosCountry.Text)
                    .Select(el => el.Код).SingleOrDefault()),
                Язык = Convert.ToInt32(contextLNW.Языки.Where(el => el.Название == comboBoxEtnosLanguage.Text)
                    .Select(el => el.Код).SingleOrDefault()),
                Год = Convert.ToInt32(comboBoxYear.Text),
                Численность = Convert.ToInt64(textBoxStrenght.Text)   
            };
            if (contextLNW.ЭтническийСостав.Where(el => el.Страна == etnos.Страна 
                    && el.Язык == etnos.Язык && el.Год == etnos.Год).ToList().Count == 0)
            {
                contextLNW.ЭтническийСостав.Add(etnos);
                contextLNW.SaveChanges();
                MessageBox.Show("Новая запись успешно добавлена!");
                form.SelectAll();
            }
            else
            {
                MessageBox.Show("Такая запись уже есть!");
            }
            return;
        }
        
        private static bool IsOnlyLetters(string input)
        {
            return !string.IsNullOrEmpty(input) && 
                   input.All(char.IsLetter);
        }
    }
}
