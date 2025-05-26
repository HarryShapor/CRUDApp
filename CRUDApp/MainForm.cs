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
            cb.GetColumnInComboBox("Языки", "Название", comboBoxLanguageDelete);
            cb.GetColumnInComboBox("Языки", "Название", comboBoxLanguageUpdate);
            cb.GetColumnInComboBox("Языки", "Название", comboBoxEtnosLanguageDelete);
            cb.GetColumnInComboBox("Языки", "Название", comboBoxEtnosLanguageUpdate);
            cb.GetColumnInComboBox("Страны", "Название", comboBoxEtnosCountryDelete);
            cb.GetColumnInComboBox("Страны", "Название", comboBoxEtnosCountryUpdate);
            
            
            SelectCountry();
            SelectLanguage();
            SelectEtnos();
            setYear();
        }


        

        #region Country

        private void SelectCountry()
        {
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

            Form form = new FormInsert(btnInsertCountry.Name);
            form.Show();

        }

        private void btnDeleteCountry_Click(object sender, EventArgs e)
        {
            var country = contextLNW.Страны
                   .FirstOrDefault(c => c.Название == comboBoxCountryDelete.Text);
            if (country != null)
            {
                contextLNW.Страны.Remove(country);
                contextLNW.SaveChanges();
                SelectCountry();
            }
        }

        #endregion

        #region Language

        private void SelectLanguage()
        {
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
            Form form = new FormInsert(btnInsertLanguage.Name);
            form.Show();
        }

        #endregion

        #region Etnos

        private void SelectEtnos()
        {
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
            foreach (var el in contextLNW.ЭтническийСостав.
                         Select(e => e.Год).Distinct().ToList().OrderByDescending(elem => elem))
            {
                comboBoxEtnosYearUpdate.Items.Add(el);
                comboBoxEtnosYearDelete.Items.Add(el);
            }
        }
        
        private void btnInsertEtnos_Click(object sender, EventArgs e)
        {
            Form form = new FormInsert(btnInsertEtnos.Name);
            form.Show();
        }

        #endregion
    }
}
