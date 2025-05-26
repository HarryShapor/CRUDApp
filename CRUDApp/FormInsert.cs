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
        LanguageNationWorld contextLNW = new LanguageNationWorld(
            "Data Source = DESKTOP-OT35EF4\\SQLEXPRESS;"
                   + "Initial Catalog=Языки_народов_мира3;"
                   + "User ID =DESKTOP-OT35EF4\\HarryShapor;"
                   + "Integrated Security=true;");
        public FormInsert(string nameBtn)
        {
            this.nameButton = nameBtn;
            InitializeComponent();
            listBoxInserted.Visible = true;
            if (this.nameButton == "btnInsertCountry")
            {
                this.ClientSize = new System.Drawing.Size(200, 400);
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
                //comboBoxContinent.Items.Add(null);
            }
            else if (this.nameButton == "btnInsertLanguage")
            {
                this.ClientSize = new System.Drawing.Size(200, 330);
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
                this.ClientSize = new System.Drawing.Size(200, 330);
                labelEtnosCountry.Visible = true;
                labelEtnosLanguage.Visible = true;
                labelYear.Visible = true;
                textBoxStrenght.Visible = true;
                comboBoxEtnosLanguage.Visible = true;
                comboBoxYear.Visible = true;
                comboBoxEtnosCountry.Visible = true;
                btnEtnosInsert.Visible = true;
                labelStrenght.Visible = true;
            }
        }

        private void btnCountryInsert_Click(object sender, EventArgs e)
        {
            listBoxInserted.Items.Clear();
            switch (this.nameButton)
            {
                case "btnInsertCountry":
                    int countPeople = Convert.ToInt32(textBoxCountPeople.Text);
                    if (countPeople <= 0)
                    {
                        listBoxInserted.Items.Add("Количество жителей должно быть положительным!");
                        break;
                    }

                    if (IsOnlyLetters(textBoxNameCountry.Text) && IsOnlyLetters(textBoxCapital.Text))
                    {
                        var country = new Страны
                        {
                            Название = textBoxNameCountry.Text,
                            Столица = textBoxCapital.Text,
                            Материк = comboBoxContinent.Text,
                            Количество_жителей = Convert.ToInt32(textBoxCountPeople.Text)
                        };
                        if (contextLNW.Страны.Where(el => el.Название == country.Название).ToList().Count == 0)
                        {
                            contextLNW.Страны.Add(country);
                            contextLNW.SaveChanges();
                            listBoxInserted.Items.Add("Новая страна успешно добавлена!");
                        }
                        else
                        {
                            listBoxInserted.Items.Add("Такая страна уже есть!");
                        }
                        break;
                    }
                    else
                    {
                        listBoxInserted.Items.Add("Поля содержат запрещенные символы!");
                        break;
                    }
                case "btnInsertLanguage":
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
                            listBoxInserted.Items.Add("Новый язык успешно добавлен!");
                        }
                        else
                        {
                            listBoxInserted.Items.Add("Такой язык уже есть!");
                        }
                        break;
                    }
                    else
                    {
                        listBoxInserted.Items.Add("Поля содержат запрещенные символы!");
                        break;
                    }
                case "btnInsertEtnos":
                    int strenght = Convert.ToInt32(textBoxStrenght.Text);
                    if (strenght <= 0)
                    {
                        listBoxInserted.Items.Add("Количество жителей должно быть положительным!");
                        break;
                    }
                    var etnos = new ЭтническийСостав
                    {
                        Страна = Convert.ToInt32(comboBoxEtnosCountry.Text),
                        Язык = Convert.ToInt32(comboBoxEtnosLanguage.Text),
                        Год = Convert.ToInt32(comboBoxYear.Text),
                        Численность = Convert.ToInt32(textBoxCountPeople.Text)
                    };
                    if (contextLNW.ЭтническийСостав.Where(el => el.Страна == etnos.Страна 
                            && el.Язык == etnos.Язык).ToList().Count == 0)
                    {
                        contextLNW.ЭтническийСостав.Add(etnos);
                        contextLNW.SaveChanges();
                        listBoxInserted.Items.Add("Новая запись успешно добавлена!");
                    }
                    else
                    {
                        listBoxInserted.Items.Add("Такая запись уже есть!");
                    }
                    break;
            }
        }
        
        private static bool IsOnlyLetters(string input)
        {
            return !string.IsNullOrEmpty(input) && 
                   input.All(char.IsLetter);
        }
    }
}
