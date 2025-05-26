using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CRUDApp
{
    public class ColumnComboBox
    {
        LanguageNationWorld contextLNW = new LanguageNationWorld(
            "Data Source = DESKTOP-OT35EF4\\SQLEXPRESS;"
            + "Initial Catalog=Языки_народов_мира3;"
            + "User ID =DESKTOP-OT35EF4\\HarryShapor;"
            + "Integrated Security=true;"); 
        
        public void GetColumnInComboBox(string table, string column, ComboBox comboBox)
        {

            comboBox.Items.Clear();
            var list = new List<object>();
            switch (table)
            {
                case "Страны":
                    list = contextLNW.Страны.ToList<object>();
                    break;
                case "Языки":
                    list = contextLNW.Языки.ToList<object>();
                    break;
                case "ЭтническийСостав":
                    list = contextLNW.ЭтническийСостав.ToList<object>();
                    break;
            }

            foreach (var el in list)
            {
                var value = el.GetType().GetProperty(column)?.GetValue(el)?.ToString();
                if (value != null)
                {
                    comboBox.Items.Add(value);
                }
            }
        }
    }
}