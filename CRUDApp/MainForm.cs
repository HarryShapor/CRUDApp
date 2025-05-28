using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDApp
{
    public partial class MainForm : Form
    {
        private Form _form;
        private ColumnComboBox cb = new ColumnComboBox();
        private LanguageNationWorld contextLNW = new LanguageNationWorld(
            "Data Source = DESKTOP-OT35EF4\\SQLEXPRESS;"
                   + "Initial Catalog=Языки_народов_мира3;"
                   + "User ID =DESKTOP-OT35EF4\\HarryShapor;"
                   + "Integrated Security=true;");
        public MainForm()
        {
            InitializeComponent();
            cb.GetColumnInComboBox("Страны","Название", comboBoxCountryDelete);
            cb.GetColumnInComboBox("Страны", "Название", comboBoxCountryUpdate);
            cb.GetColumnInComboBox("Страны", "Название", comboBoxEtnosCountryDelete);
            cb.GetColumnInComboBox("Страны", "Название", comboBoxEtnosCountryUpdate);
            cb.GetColumnInComboBox("Языки", "Название", comboBoxLanguageDelete);
            cb.GetColumnInComboBox("Языки", "Название", comboBoxLanguageUpdate);
            cb.GetColumnInComboBox("Языки", "Название", comboBoxEtnosLanguageDelete);
            cb.GetColumnInComboBox("Языки", "Название", comboBoxEtnosLanguageUpdate);
            
            SelectCountry();
            SelectLanguage();
            SelectEtnos();
            setYear();
        }

        public void SelectAll()
        {
            
            cb.GetColumnInComboBox("Страны","Название", comboBoxCountryDelete);
            cb.GetColumnInComboBox("Страны", "Название", comboBoxCountryUpdate);
            cb.GetColumnInComboBox("Страны", "Название", comboBoxEtnosCountryDelete);
            cb.GetColumnInComboBox("Страны", "Название", comboBoxEtnosCountryUpdate);
            cb.GetColumnInComboBox("Языки", "Название", comboBoxLanguageDelete);
            cb.GetColumnInComboBox("Языки", "Название", comboBoxLanguageUpdate);
            cb.GetColumnInComboBox("Языки", "Название", comboBoxEtnosLanguageDelete);
            cb.GetColumnInComboBox("Языки", "Название", comboBoxEtnosLanguageUpdate);
            SelectCountry();
            SelectLanguage();
            SelectEtnos();
            setYear();
        }
        

        #region Country

        private void SelectCountry()
        {
            listViewCountry.Clear();
            var list = contextLNW.Страны.ToList();
            listViewCountry.View = View.Details;
            listViewCountry.Columns.Add("Название", 150);
            listViewCountry.Columns.Add("Столица", 100);
            listViewCountry.Columns.Add("Материк", 130);
            listViewCountry.Columns.Add("Количество жителей", 150);

            foreach (var item in list)
            {
                var listItem = new ListViewItem(item.Название);
                listItem.SubItems.Add(item.Столица);
                listItem.SubItems.Add(item.Материк);
                listItem.SubItems.Add(item.Количество_жителей.ToString());
                listViewCountry.Items.Add(listItem);
            }
        }
        
        private void listViewCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnInsertCountry_Click(object sender, EventArgs e)
        {
            if (_form != null)
            {
                _form.Dispose();
            }
            _form = new FormInsert(btnInsertCountry.Name, this);
            _form.Show(); 
        }
        
        private void btnUpdateCountry_Click(object sender, EventArgs e)
        {
            int country = contextLNW.Страны.Where(el => el.Название == comboBoxCountryUpdate.Text)
                .Select(el => el.Код).FirstOrDefault();
            if (comboBoxCountryUpdate.SelectedIndex == -1)
            {
                MessageBox.Show("Страна не выбрана!");
                return;
            }

            if (contextLNW.Страны.Where(el => el.Код == country).Count() != 0)
            {
                if (_form != null)
                {
                    _form.Dispose();
                }
                _form = new FormUpdate(btnUpdateCountry.Name, country, this);
                _form.Show();
            }
            else
            {
                MessageBox.Show("Такой страны нет!");
                return;
            }
        }
        
        private void btnDeleteCountry_Click(object sender, EventArgs e)
        {
            if (comboBoxCountryDelete.SelectedIndex == -1)
            {
                MessageBox.Show("Страна не выбрана!");
                return;
            }

            var country = contextLNW.Страны.Where(el =>
                el.Название == comboBoxCountryDelete.Text).FirstOrDefault();
            if (country != null)
            {
                string message = "Вы точно хотите удалить страну: " + country.Название 
                          + " | " + country.Столица +  " | " + country.Материк +  " | " +country.Количество_жителей;
                DialogResult dialogCountry= MessageBox.Show(message, "Подтвердите удаление", MessageBoxButtons.YesNo);
                if(dialogCountry == DialogResult.Yes)
                {
                    if (contextLNW.ЭтническийСостав.Where(el => el.Страна == country.Код).Count() != 0)
                    {
                        DialogResult dialogResultEtnos = 
                            MessageBox.Show("Страна используется в других таблицах, удалить эти данные?", 
                                "Подтвердите удаление", MessageBoxButtons.YesNo);
                        if (dialogResultEtnos == DialogResult.Yes)
                        {
                            var etnos = contextLNW.ЭтническийСостав
                                .Where(el => el.Страна == country.Код).ToList();
                            contextLNW.ЭтническийСостав.RemoveRange(etnos);
                        }
                        else
                        {
                            return;
                        }
                    }
                        contextLNW.Страны.Remove(country);
                        contextLNW.SaveChanges();
                        MessageBox.Show("Страна успешно удалена!");
                        comboBoxCountryDelete.SelectedIndex = -1;
                }
                else if (dialogCountry == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Такой страны нет!");
            }
            SelectAll();
        }

        #endregion

        #region Language

        private void SelectLanguage()
        {
            listViewLanguage.Clear();
            var list = contextLNW.Языки.ToList();
            listViewLanguage.View = View.Details;
            listViewLanguage.Columns.Add("Название", 150);
            listViewLanguage.Columns.Add("Языковая группа", 100);
            listViewLanguage.Columns.Add("Вид знаковой системы", 130);

            foreach (var item in list)
            {
                var listItem = new ListViewItem(item.Название);
                listItem.SubItems.Add(item.Языковая_группа);
                listItem.SubItems.Add(item.Вид_знаковой_системы);
                listViewLanguage.Items.Add(listItem);
            }
        }

        private void btnInsertLanguage_Click(object sender, EventArgs e)
        {
            if (_form != null)
            {
                _form.Dispose();
            }
            _form = new FormInsert(btnInsertLanguage.Name, this);
            _form.Show();
        }

        private void buttonLanguageUpdate_Click(object sender, EventArgs e)
        {
            int language = contextLNW.Языки.Where(el => el.Название == comboBoxLanguageUpdate.Text)
                .Select(el => el.Код).FirstOrDefault();
            if (comboBoxLanguageUpdate.SelectedIndex == -1)
            {
                MessageBox.Show("Язык не выбран!");
                return;
            }

            if (contextLNW.Языки.Where(el => el.Код == language).Count() != 0)
            {
                if (_form != null)
                {
                    _form.Dispose();
                }
                _form = new FormUpdate(buttonLanguageUpdate.Name, language, this);
                _form.Show();
            }
            else
            {
                MessageBox.Show("Такой страны нет!");
                return;
            }
        }
        
        private void buttonLanguageDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxLanguageDelete.SelectedIndex == -1)
            {
                MessageBox.Show("Язык не выбран!");
                return;
            }

            var language = contextLNW.Языки.Where(el =>
                el.Название == comboBoxLanguageDelete.Text).FirstOrDefault();
            if (language != null)
            {
                string message = "Вы точно хотите удалить язык: " + language.Название 
                          + " | " + language.Языковая_группа +  " | " + language.Вид_знаковой_системы;
                DialogResult dialogLanguage= MessageBox.Show(message, "Подтвердите удаление", MessageBoxButtons.YesNo);
                if(dialogLanguage == DialogResult.Yes)
                {
                    if (contextLNW.ЭтническийСостав.Where(el => el.Язык == language.Код).Count() != 0)
                    {
                        DialogResult dialogResultEtnos = 
                            MessageBox.Show("Язык используется в других таблицах, удалить эти данные?", 
                                "Подтвердите удаление", MessageBoxButtons.YesNo);
                        if (dialogResultEtnos == DialogResult.Yes)
                        {
                            var etnos = contextLNW.ЭтническийСостав
                                .Where(el => el.Язык == language.Код).ToList();
                            contextLNW.ЭтническийСостав.RemoveRange(etnos);
                        }
                        else
                        {
                            return;
                        }
                    }
                    contextLNW.Языки.Remove(language);
                    contextLNW.SaveChanges();
                    MessageBox.Show("Язык успешно удален!");
                    comboBoxLanguageDelete.SelectedIndex = -1;
                }
                else if (dialogLanguage == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Такого языка нет!");
            }
            SelectAll();
        }
        
        #endregion

        #region Etnos

        private void SelectEtnos()
        {
            listViewEtnos.Clear();
            var list = contextLNW.ЭтническийСостав.ToList();
            listViewEtnos.View = View.Details;
            listViewEtnos.Columns.Add("Страна", 150);
            listViewEtnos.Columns.Add("Язык", 100);
            listViewEtnos.Columns.Add("Год", 130);
            listViewEtnos.Columns.Add("Численность", 130);

            foreach (var item in list)
            {
                string country = "";
                string language = "";
                foreach (var coun in contextLNW.Страны.Where(c => c.Код == item.Страна).ToList())
                {
                    country = coun.Название;
                }
                foreach (var lang in contextLNW.Языки.Where(l => l.Код == item.Язык).ToList())
                {
                    language = lang.Название;
                }
                var listItem = new ListViewItem(country);
                listItem.SubItems.Add(language);
                listItem.SubItems.Add(item.Год.ToString());
                listItem.SubItems.Add(item.Численность.ToString());
                listViewEtnos.Items.Add(listItem);
            }
        }

        private void setYear()
        {
            comboBoxEtnosYearUpdate.Items.Clear();
            foreach (var el in contextLNW.ЭтническийСостав.
                         Select(e => e.Год).Distinct().ToList().OrderByDescending(elem => elem))
            {
                comboBoxEtnosYearUpdate.Items.Add(el);
                comboBoxEtnosYearDelete.Items.Add(el);
            }
        }
        
        private void btnInsertEtnos_Click(object sender, EventArgs e)
        {
            if (_form != null)
            {
                _form.Dispose();
            }
            _form = new FormInsert(btnInsertEtnos.Name, this);
            _form.Show();
        }

        private void buttonEtnosUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxEtnosCountryUpdate.SelectedIndex == -1)
            {
                MessageBox.Show("Страна не выбрана!");
                return;
            }
            if (comboBoxEtnosLanguageUpdate.SelectedIndex == -1)
            {
                MessageBox.Show("Язык не выбран!");
                return;
            }
            if (comboBoxEtnosYearUpdate.SelectedIndex == -1)
            {
                MessageBox.Show("Год не выбран!");
                return;
            }

            int year = int.Parse(comboBoxEtnosYearUpdate.Text);
            if (contextLNW.ЭтническийСостав.Where(el => 
                    el.Страна == contextLNW.Страны.Where(c => c.Название == comboBoxEtnosCountryUpdate.Text)
                        .Select(c => c.Код).FirstOrDefault()
                    && el.Язык == contextLNW.Языки.Where(c => c.Название == comboBoxEtnosLanguageUpdate.Text)
                        .Select(c => c.Код).FirstOrDefault()
                    && el.Год == year).Count() != 0)
            {
                if (_form != null)
                {
                    _form.Dispose();
                }
                _form = new FormUpdate(buttonEtnosUpdate.Name, comboBoxEtnosCountryUpdate.Text,
                    comboBoxEtnosLanguageUpdate.Text, comboBoxEtnosYearUpdate.Text, this);
                _form.Show();
            }
            else
            {
                MessageBox.Show("Такой записи нет!");
            }

        }
        
        private void buttonEtnosDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxEtnosCountryDelete.SelectedIndex == -1)
            {
                MessageBox.Show("Страна не выбрана!");
                return;
            }
            if (comboBoxEtnosLanguageDelete.SelectedIndex == -1)
            {
                MessageBox.Show("Язык не выбран!");
                return;
            }
            if (comboBoxEtnosYearDelete.SelectedIndex == -1)
            {
                MessageBox.Show("Год не выбран!");
                return;
            }
            int year = int.Parse(comboBoxEtnosYearDelete.Text);
            var etnos = contextLNW.ЭтническийСостав.Where(el =>
                el.Страна == contextLNW.Страны
                    .Where(c => c.Название == comboBoxEtnosCountryDelete.Text)
                    .Select(c => c.Код)
                    .FirstOrDefault()
                && el.Язык == contextLNW.Языки
                    .Where(c => c.Название == comboBoxEtnosLanguageDelete.Text)
                    .Select(c => c.Код)
                    .FirstOrDefault()
                && el.Год == year).FirstOrDefault();
            if (etnos != null)
            {
                string message = "Вы точно хотите удалить запись: " + comboBoxEtnosCountryDelete.Text +
                                 " | " + comboBoxEtnosLanguageDelete.Text + " | " + etnos.Год +  " | " + etnos.Численность;
                DialogResult dialogResult = MessageBox.Show(message, "Подтвердите удаление", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    contextLNW.ЭтническийСостав.Remove(etnos);
                    contextLNW.SaveChanges();
                    MessageBox.Show("Запись успешно удалена!");
                    comboBoxEtnosCountryDelete.SelectedIndex = -1;
                    comboBoxEtnosLanguageDelete.SelectedIndex = -1;
                    comboBoxEtnosYearDelete.SelectedIndex = -1;
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Такой записи нет!");
            }
            SelectAll();
        }
        
        #endregion
        
    }
}
