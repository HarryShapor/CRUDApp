using System.Drawing;
using System.Windows.Forms;

namespace CRUDApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.CountryTab = new System.Windows.Forms.TabPage();
            this.listViewCountry = new System.Windows.Forms.ListView();
            this.comboBoxCountryDelete = new System.Windows.Forms.ComboBox();
            this.labelCountryDelete = new System.Windows.Forms.Label();
            this.comboBoxCountryUpdate = new System.Windows.Forms.ComboBox();
            this.labelCountryUpdate = new System.Windows.Forms.Label();
            this.btnDeleteCountry = new System.Windows.Forms.Button();
            this.btnUpdateCountry = new System.Windows.Forms.Button();
            this.btnInsertCountry = new System.Windows.Forms.Button();
            this.LanguageTab = new System.Windows.Forms.TabPage();
            this.listViewLanguage = new System.Windows.Forms.ListView();
            this.buttonLanguageDelete = new System.Windows.Forms.Button();
            this.buttonLanguageUpdate = new System.Windows.Forms.Button();
            this.comboBoxLanguageDelete = new System.Windows.Forms.ComboBox();
            this.comboBoxLanguageUpdate = new System.Windows.Forms.ComboBox();
            this.labelLanguageDelete = new System.Windows.Forms.Label();
            this.labelLanguageUpdate = new System.Windows.Forms.Label();
            this.btnInsertLanguage = new System.Windows.Forms.Button();
            this.EtnosTab = new System.Windows.Forms.TabPage();
            this.labelEtnosYearUpdate = new System.Windows.Forms.Label();
            this.comboBoxEtnosYearUpdate = new System.Windows.Forms.ComboBox();
            this.comboBoxEtnosYearDelete = new System.Windows.Forms.ComboBox();
            this.labelEtnosYearDelete = new System.Windows.Forms.Label();
            this.labelEtnosLanguageDelete = new System.Windows.Forms.Label();
            this.comboBoxEtnosLanguageDelete = new System.Windows.Forms.ComboBox();
            this.comboBoxEtnosLanguageUpdate = new System.Windows.Forms.ComboBox();
            this.labelEtnosLanguageUpdate = new System.Windows.Forms.Label();
            this.listViewEtnos = new System.Windows.Forms.ListView();
            this.comboBoxEtnosCountryDelete = new System.Windows.Forms.ComboBox();
            this.comboBoxEtnosCountryUpdate = new System.Windows.Forms.ComboBox();
            this.labelEtnosCountryDelete = new System.Windows.Forms.Label();
            this.labelEtnosCountryUpdate = new System.Windows.Forms.Label();
            this.buttonEtnosUpdate = new System.Windows.Forms.Button();
            this.buttonEtnosDelete = new System.Windows.Forms.Button();
            this.btnInsertEtnos = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.CountryTab.SuspendLayout();
            this.LanguageTab.SuspendLayout();
            this.EtnosTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.CountryTab);
            this.tabControl.Controls.Add(this.LanguageTab);
            this.tabControl.Controls.Add(this.EtnosTab);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(785, 465);
            this.tabControl.TabIndex = 0;
            // 
            // CountryTab
            // 
            this.CountryTab.Controls.Add(this.listViewCountry);
            this.CountryTab.Controls.Add(this.comboBoxCountryDelete);
            this.CountryTab.Controls.Add(this.labelCountryDelete);
            this.CountryTab.Controls.Add(this.comboBoxCountryUpdate);
            this.CountryTab.Controls.Add(this.labelCountryUpdate);
            this.CountryTab.Controls.Add(this.btnDeleteCountry);
            this.CountryTab.Controls.Add(this.btnUpdateCountry);
            this.CountryTab.Controls.Add(this.btnInsertCountry);
            this.CountryTab.Location = new System.Drawing.Point(4, 22);
            this.CountryTab.Margin = new System.Windows.Forms.Padding(2);
            this.CountryTab.Name = "CountryTab";
            this.CountryTab.Padding = new System.Windows.Forms.Padding(2);
            this.CountryTab.Size = new System.Drawing.Size(777, 439);
            this.CountryTab.TabIndex = 0;
            this.CountryTab.Text = "Страны";
            this.CountryTab.UseVisualStyleBackColor = true;
            // 
            // listViewCountry
            // 
            this.listViewCountry.HideSelection = false;
            this.listViewCountry.Location = new System.Drawing.Point(0, 0);
            this.listViewCountry.Name = "listViewCountry";
            this.listViewCountry.Size = new System.Drawing.Size(557, 439);
            this.listViewCountry.TabIndex = 8;
            this.listViewCountry.UseCompatibleStateImageBehavior = false;
            this.listViewCountry.SelectedIndexChanged += new System.EventHandler(this.listViewCountry_SelectedIndexChanged);
            // 
            // comboBoxCountryDelete
            // 
            this.comboBoxCountryDelete.FormattingEnabled = true;
            this.comboBoxCountryDelete.Location = new System.Drawing.Point(589, 280);
            this.comboBoxCountryDelete.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCountryDelete.Name = "comboBoxCountryDelete";
            this.comboBoxCountryDelete.Size = new System.Drawing.Size(128, 21);
            this.comboBoxCountryDelete.TabIndex = 7;
            this.comboBoxCountryDelete.Text = "Казахстан";
            // 
            // labelCountryDelete
            // 
            this.labelCountryDelete.AutoSize = true;
            this.labelCountryDelete.Location = new System.Drawing.Point(575, 234);
            this.labelCountryDelete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountryDelete.Name = "labelCountryDelete";
            this.labelCountryDelete.Size = new System.Drawing.Size(165, 13);
            this.labelCountryDelete.TabIndex = 6;
            this.labelCountryDelete.Text = "Выберите страну для удаления";
            // 
            // comboBoxCountryUpdate
            // 
            this.comboBoxCountryUpdate.FormattingEnabled = true;
            this.comboBoxCountryUpdate.Location = new System.Drawing.Point(589, 122);
            this.comboBoxCountryUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCountryUpdate.Name = "comboBoxCountryUpdate";
            this.comboBoxCountryUpdate.Size = new System.Drawing.Size(130, 21);
            this.comboBoxCountryUpdate.TabIndex = 5;
            this.comboBoxCountryUpdate.Text = "Россия";
            // 
            // labelCountryUpdate
            // 
            this.labelCountryUpdate.AutoSize = true;
            this.labelCountryUpdate.Location = new System.Drawing.Point(562, 81);
            this.labelCountryUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountryUpdate.Name = "labelCountryUpdate";
            this.labelCountryUpdate.Size = new System.Drawing.Size(178, 13);
            this.labelCountryUpdate.TabIndex = 4;
            this.labelCountryUpdate.Text = "Выберите страну для обновления";
            // 
            // btnDeleteCountry
            // 
            this.btnDeleteCountry.Location = new System.Drawing.Point(627, 332);
            this.btnDeleteCountry.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteCountry.Name = "btnDeleteCountry";
            this.btnDeleteCountry.Size = new System.Drawing.Size(62, 23);
            this.btnDeleteCountry.TabIndex = 2;
            this.btnDeleteCountry.Text = "Удалить";
            this.btnDeleteCountry.UseVisualStyleBackColor = true;
            this.btnDeleteCountry.Click += new System.EventHandler(this.btnDeleteCountry_Click);
            // 
            // btnUpdateCountry
            // 
            this.btnUpdateCountry.Location = new System.Drawing.Point(610, 175);
            this.btnUpdateCountry.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateCountry.Name = "btnUpdateCountry";
            this.btnUpdateCountry.Size = new System.Drawing.Size(79, 20);
            this.btnUpdateCountry.TabIndex = 1;
            this.btnUpdateCountry.Text = "Обновить";
            this.btnUpdateCountry.UseVisualStyleBackColor = true;
            // 
            // btnInsertCountry
            // 
            this.btnInsertCountry.Location = new System.Drawing.Point(593, 26);
            this.btnInsertCountry.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertCountry.Name = "btnInsertCountry";
            this.btnInsertCountry.Size = new System.Drawing.Size(126, 35);
            this.btnInsertCountry.TabIndex = 0;
            this.btnInsertCountry.Text = "Добавить страну";
            this.btnInsertCountry.UseVisualStyleBackColor = true;
            this.btnInsertCountry.Click += new System.EventHandler(this.btnInsertCountry_Click);
            // 
            // LanguageTab
            // 
            this.LanguageTab.Controls.Add(this.listViewLanguage);
            this.LanguageTab.Controls.Add(this.buttonLanguageDelete);
            this.LanguageTab.Controls.Add(this.buttonLanguageUpdate);
            this.LanguageTab.Controls.Add(this.comboBoxLanguageDelete);
            this.LanguageTab.Controls.Add(this.comboBoxLanguageUpdate);
            this.LanguageTab.Controls.Add(this.labelLanguageDelete);
            this.LanguageTab.Controls.Add(this.labelLanguageUpdate);
            this.LanguageTab.Controls.Add(this.btnInsertLanguage);
            this.LanguageTab.Location = new System.Drawing.Point(4, 22);
            this.LanguageTab.Margin = new System.Windows.Forms.Padding(2);
            this.LanguageTab.Name = "LanguageTab";
            this.LanguageTab.Padding = new System.Windows.Forms.Padding(2);
            this.LanguageTab.Size = new System.Drawing.Size(777, 439);
            this.LanguageTab.TabIndex = 1;
            this.LanguageTab.Text = "Языки";
            this.LanguageTab.UseVisualStyleBackColor = true;
            // 
            // listViewLanguage
            // 
            this.listViewLanguage.HideSelection = false;
            this.listViewLanguage.Location = new System.Drawing.Point(-4, 0);
            this.listViewLanguage.Name = "listViewLanguage";
            this.listViewLanguage.Size = new System.Drawing.Size(571, 439);
            this.listViewLanguage.TabIndex = 8;
            this.listViewLanguage.UseCompatibleStateImageBehavior = false;
            // 
            // buttonLanguageDelete
            // 
            this.buttonLanguageDelete.Location = new System.Drawing.Point(617, 358);
            this.buttonLanguageDelete.Name = "buttonLanguageDelete";
            this.buttonLanguageDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonLanguageDelete.TabIndex = 7;
            this.buttonLanguageDelete.Text = "Удалить";
            this.buttonLanguageDelete.UseVisualStyleBackColor = true;
            // 
            // buttonLanguageUpdate
            // 
            this.buttonLanguageUpdate.Location = new System.Drawing.Point(617, 201);
            this.buttonLanguageUpdate.Name = "buttonLanguageUpdate";
            this.buttonLanguageUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonLanguageUpdate.TabIndex = 6;
            this.buttonLanguageUpdate.Text = "Обновить";
            this.buttonLanguageUpdate.UseVisualStyleBackColor = true;
            // 
            // comboBoxLanguageDelete
            // 
            this.comboBoxLanguageDelete.FormattingEnabled = true;
            this.comboBoxLanguageDelete.Location = new System.Drawing.Point(591, 300);
            this.comboBoxLanguageDelete.Name = "comboBoxLanguageDelete";
            this.comboBoxLanguageDelete.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLanguageDelete.TabIndex = 5;
            this.comboBoxLanguageDelete.Text = "русский";
            // 
            // comboBoxLanguageUpdate
            // 
            this.comboBoxLanguageUpdate.FormattingEnabled = true;
            this.comboBoxLanguageUpdate.Location = new System.Drawing.Point(591, 141);
            this.comboBoxLanguageUpdate.Name = "comboBoxLanguageUpdate";
            this.comboBoxLanguageUpdate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLanguageUpdate.TabIndex = 4;
            this.comboBoxLanguageUpdate.Text = "китайский";
            // 
            // labelLanguageDelete
            // 
            this.labelLanguageDelete.AutoSize = true;
            this.labelLanguageDelete.Location = new System.Drawing.Point(573, 259);
            this.labelLanguageDelete.Name = "labelLanguageDelete";
            this.labelLanguageDelete.Size = new System.Drawing.Size(157, 13);
            this.labelLanguageDelete.TabIndex = 3;
            this.labelLanguageDelete.Text = "Выберите язык для удаления";
            // 
            // labelLanguageUpdate
            // 
            this.labelLanguageUpdate.AutoSize = true;
            this.labelLanguageUpdate.Location = new System.Drawing.Point(573, 100);
            this.labelLanguageUpdate.Name = "labelLanguageUpdate";
            this.labelLanguageUpdate.Size = new System.Drawing.Size(170, 13);
            this.labelLanguageUpdate.TabIndex = 2;
            this.labelLanguageUpdate.Text = "Выберите язык для обновления";
            // 
            // btnInsertLanguage
            // 
            this.btnInsertLanguage.Location = new System.Drawing.Point(591, 41);
            this.btnInsertLanguage.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertLanguage.Name = "btnInsertLanguage";
            this.btnInsertLanguage.Size = new System.Drawing.Size(106, 26);
            this.btnInsertLanguage.TabIndex = 0;
            this.btnInsertLanguage.Text = "Добавить язык";
            this.btnInsertLanguage.UseVisualStyleBackColor = true;
            this.btnInsertLanguage.Click += new System.EventHandler(this.btnInsertLanguage_Click);
            // 
            // EtnosTab
            // 
            this.EtnosTab.Controls.Add(this.labelEtnosYearUpdate);
            this.EtnosTab.Controls.Add(this.comboBoxEtnosYearUpdate);
            this.EtnosTab.Controls.Add(this.comboBoxEtnosYearDelete);
            this.EtnosTab.Controls.Add(this.labelEtnosYearDelete);
            this.EtnosTab.Controls.Add(this.labelEtnosLanguageDelete);
            this.EtnosTab.Controls.Add(this.comboBoxEtnosLanguageDelete);
            this.EtnosTab.Controls.Add(this.comboBoxEtnosLanguageUpdate);
            this.EtnosTab.Controls.Add(this.labelEtnosLanguageUpdate);
            this.EtnosTab.Controls.Add(this.listViewEtnos);
            this.EtnosTab.Controls.Add(this.comboBoxEtnosCountryDelete);
            this.EtnosTab.Controls.Add(this.comboBoxEtnosCountryUpdate);
            this.EtnosTab.Controls.Add(this.labelEtnosCountryDelete);
            this.EtnosTab.Controls.Add(this.labelEtnosCountryUpdate);
            this.EtnosTab.Controls.Add(this.buttonEtnosUpdate);
            this.EtnosTab.Controls.Add(this.buttonEtnosDelete);
            this.EtnosTab.Controls.Add(this.btnInsertEtnos);
            this.EtnosTab.Location = new System.Drawing.Point(4, 22);
            this.EtnosTab.Margin = new System.Windows.Forms.Padding(2);
            this.EtnosTab.Name = "EtnosTab";
            this.EtnosTab.Padding = new System.Windows.Forms.Padding(2);
            this.EtnosTab.Size = new System.Drawing.Size(777, 439);
            this.EtnosTab.TabIndex = 2;
            this.EtnosTab.Text = "Этнический состав";
            this.EtnosTab.UseVisualStyleBackColor = true;
            // 
            // labelEtnosYearUpdate
            // 
            this.labelEtnosYearUpdate.AutoSize = true;
            this.labelEtnosYearUpdate.Location = new System.Drawing.Point(547, 195);
            this.labelEtnosYearUpdate.Name = "labelEtnosYearUpdate";
            this.labelEtnosYearUpdate.Size = new System.Drawing.Size(77, 13);
            this.labelEtnosYearUpdate.TabIndex = 16;
            this.labelEtnosYearUpdate.Text = "Выберите год";
            // 
            // comboBoxEtnosYearUpdate
            // 
            this.comboBoxEtnosYearUpdate.FormattingEnabled = true;
            this.comboBoxEtnosYearUpdate.Location = new System.Drawing.Point(661, 188);
            this.comboBoxEtnosYearUpdate.Name = "comboBoxEtnosYearUpdate";
            this.comboBoxEtnosYearUpdate.Size = new System.Drawing.Size(74, 21);
            this.comboBoxEtnosYearUpdate.TabIndex = 15;
            // 
            // comboBoxEtnosYearDelete
            // 
            this.comboBoxEtnosYearDelete.FormattingEnabled = true;
            this.comboBoxEtnosYearDelete.Location = new System.Drawing.Point(661, 346);
            this.comboBoxEtnosYearDelete.Name = "comboBoxEtnosYearDelete";
            this.comboBoxEtnosYearDelete.Size = new System.Drawing.Size(74, 21);
            this.comboBoxEtnosYearDelete.TabIndex = 14;
            // 
            // labelEtnosYearDelete
            // 
            this.labelEtnosYearDelete.AutoSize = true;
            this.labelEtnosYearDelete.Location = new System.Drawing.Point(547, 346);
            this.labelEtnosYearDelete.Name = "labelEtnosYearDelete";
            this.labelEtnosYearDelete.Size = new System.Drawing.Size(77, 13);
            this.labelEtnosYearDelete.TabIndex = 13;
            this.labelEtnosYearDelete.Text = "Выберите год";
            // 
            // labelEtnosLanguageDelete
            // 
            this.labelEtnosLanguageDelete.AutoSize = true;
            this.labelEtnosLanguageDelete.Location = new System.Drawing.Point(667, 267);
            this.labelEtnosLanguageDelete.Name = "labelEtnosLanguageDelete";
            this.labelEtnosLanguageDelete.Size = new System.Drawing.Size(86, 13);
            this.labelEtnosLanguageDelete.TabIndex = 12;
            this.labelEtnosLanguageDelete.Text = "Выберите язык";
            // 
            // comboBoxEtnosLanguageDelete
            // 
            this.comboBoxEtnosLanguageDelete.FormattingEnabled = true;
            this.comboBoxEtnosLanguageDelete.Location = new System.Drawing.Point(670, 307);
            this.comboBoxEtnosLanguageDelete.Name = "comboBoxEtnosLanguageDelete";
            this.comboBoxEtnosLanguageDelete.Size = new System.Drawing.Size(54, 21);
            this.comboBoxEtnosLanguageDelete.TabIndex = 11;
            // 
            // comboBoxEtnosLanguageUpdate
            // 
            this.comboBoxEtnosLanguageUpdate.FormattingEnabled = true;
            this.comboBoxEtnosLanguageUpdate.Location = new System.Drawing.Point(661, 139);
            this.comboBoxEtnosLanguageUpdate.Name = "comboBoxEtnosLanguageUpdate";
            this.comboBoxEtnosLanguageUpdate.Size = new System.Drawing.Size(54, 21);
            this.comboBoxEtnosLanguageUpdate.TabIndex = 10;
            // 
            // labelEtnosLanguageUpdate
            // 
            this.labelEtnosLanguageUpdate.AutoSize = true;
            this.labelEtnosLanguageUpdate.Location = new System.Drawing.Point(658, 104);
            this.labelEtnosLanguageUpdate.Name = "labelEtnosLanguageUpdate";
            this.labelEtnosLanguageUpdate.Size = new System.Drawing.Size(86, 13);
            this.labelEtnosLanguageUpdate.TabIndex = 9;
            this.labelEtnosLanguageUpdate.Text = "Выберите язык";
            // 
            // listViewEtnos
            // 
            this.listViewEtnos.HideSelection = false;
            this.listViewEtnos.Location = new System.Drawing.Point(-4, 0);
            this.listViewEtnos.Name = "listViewEtnos";
            this.listViewEtnos.Size = new System.Drawing.Size(536, 439);
            this.listViewEtnos.TabIndex = 8;
            this.listViewEtnos.UseCompatibleStateImageBehavior = false;
            // 
            // comboBoxEtnosCountryDelete
            // 
            this.comboBoxEtnosCountryDelete.FormattingEnabled = true;
            this.comboBoxEtnosCountryDelete.Location = new System.Drawing.Point(547, 307);
            this.comboBoxEtnosCountryDelete.Name = "comboBoxEtnosCountryDelete";
            this.comboBoxEtnosCountryDelete.Size = new System.Drawing.Size(60, 21);
            this.comboBoxEtnosCountryDelete.TabIndex = 7;
            // 
            // comboBoxEtnosCountryUpdate
            // 
            this.comboBoxEtnosCountryUpdate.FormattingEnabled = true;
            this.comboBoxEtnosCountryUpdate.Location = new System.Drawing.Point(547, 140);
            this.comboBoxEtnosCountryUpdate.Name = "comboBoxEtnosCountryUpdate";
            this.comboBoxEtnosCountryUpdate.Size = new System.Drawing.Size(60, 21);
            this.comboBoxEtnosCountryUpdate.TabIndex = 6;
            // 
            // labelEtnosCountryDelete
            // 
            this.labelEtnosCountryDelete.AutoSize = true;
            this.labelEtnosCountryDelete.Location = new System.Drawing.Point(544, 267);
            this.labelEtnosCountryDelete.Name = "labelEtnosCountryDelete";
            this.labelEtnosCountryDelete.Size = new System.Drawing.Size(94, 13);
            this.labelEtnosCountryDelete.TabIndex = 5;
            this.labelEtnosCountryDelete.Text = "Выберите страну";
            // 
            // labelEtnosCountryUpdate
            // 
            this.labelEtnosCountryUpdate.AutoSize = true;
            this.labelEtnosCountryUpdate.Location = new System.Drawing.Point(544, 104);
            this.labelEtnosCountryUpdate.Name = "labelEtnosCountryUpdate";
            this.labelEtnosCountryUpdate.Size = new System.Drawing.Size(94, 13);
            this.labelEtnosCountryUpdate.TabIndex = 4;
            this.labelEtnosCountryUpdate.Text = "Выберите страну";
            // 
            // buttonEtnosUpdate
            // 
            this.buttonEtnosUpdate.Location = new System.Drawing.Point(609, 228);
            this.buttonEtnosUpdate.Name = "buttonEtnosUpdate";
            this.buttonEtnosUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonEtnosUpdate.TabIndex = 3;
            this.buttonEtnosUpdate.Text = "Обновить";
            this.buttonEtnosUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonEtnosDelete
            // 
            this.buttonEtnosDelete.Location = new System.Drawing.Point(609, 391);
            this.buttonEtnosDelete.Name = "buttonEtnosDelete";
            this.buttonEtnosDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonEtnosDelete.TabIndex = 2;
            this.buttonEtnosDelete.Text = "Удалить";
            this.buttonEtnosDelete.UseVisualStyleBackColor = true;
            // 
            // btnInsertEtnos
            // 
            this.btnInsertEtnos.Location = new System.Drawing.Point(547, 40);
            this.btnInsertEtnos.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertEtnos.Name = "btnInsertEtnos";
            this.btnInsertEtnos.Size = new System.Drawing.Size(188, 24);
            this.btnInsertEtnos.TabIndex = 0;
            this.btnInsertEtnos.Text = "Добавить этнический состав";
            this.btnInsertEtnos.UseVisualStyleBackColor = true;
            this.btnInsertEtnos.Click += new System.EventHandler(this.btnInsertEtnos_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "CRUD операции";
            this.tabControl.ResumeLayout(false);
            this.CountryTab.ResumeLayout(false);
            this.CountryTab.PerformLayout();
            this.LanguageTab.ResumeLayout(false);
            this.LanguageTab.PerformLayout();
            this.EtnosTab.ResumeLayout(false);
            this.EtnosTab.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage CountryTab;
        private System.Windows.Forms.TabPage LanguageTab;
        private System.Windows.Forms.TabPage EtnosTab;
        private System.Windows.Forms.Button btnDeleteCountry;
        private System.Windows.Forms.Button btnUpdateCountry;
        private System.Windows.Forms.Button btnInsertCountry;
        private System.Windows.Forms.Label labelCountryUpdate;
        private System.Windows.Forms.ComboBox comboBoxCountryUpdate;
        private System.Windows.Forms.ComboBox comboBoxCountryDelete;
        private System.Windows.Forms.Label labelCountryDelete;
        private System.Windows.Forms.Button btnInsertLanguage;
        private System.Windows.Forms.Button btnInsertEtnos;
        private Button buttonLanguageDelete;
        private Button buttonLanguageUpdate;
        private ComboBox comboBoxLanguageDelete;
        private ComboBox comboBoxLanguageUpdate;
        private Label labelLanguageDelete;
        private Label labelLanguageUpdate;
        private ComboBox comboBoxEtnosCountryDelete;
        private ComboBox comboBoxEtnosCountryUpdate;
        private Label labelEtnosCountryDelete;
        private Label labelEtnosCountryUpdate;
        private Button buttonEtnosUpdate;
        private Button buttonEtnosDelete;
        private ListView listViewCountry;
        private ListView listViewLanguage;
        private ListView listViewEtnos;
        private Label labelEtnosLanguageUpdate;
        private ComboBox comboBoxEtnosLanguageUpdate;
        private ComboBox comboBoxEtnosLanguageDelete;
        private Label labelEtnosLanguageDelete;
        private Label labelEtnosYearDelete;
        private Label labelEtnosYearUpdate;
        private ComboBox comboBoxEtnosYearUpdate;
        private ComboBox comboBoxEtnosYearDelete;
    }
}

