﻿using System.Drawing;
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
            this.comboBoxCountryDelete.Location = new System.Drawing.Point(582, 265);
            this.comboBoxCountryDelete.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCountryDelete.Name = "comboBoxCountryDelete";
            this.comboBoxCountryDelete.Size = new System.Drawing.Size(128, 21);
            this.comboBoxCountryDelete.TabIndex = 7;
            this.comboBoxCountryDelete.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // labelCountryDelete
            // 
            this.labelCountryDelete.AutoSize = true;
            this.labelCountryDelete.Location = new System.Drawing.Point(575, 224);
            this.labelCountryDelete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountryDelete.Name = "labelCountryDelete";
            this.labelCountryDelete.Size = new System.Drawing.Size(165, 13);
            this.labelCountryDelete.TabIndex = 6;
            this.labelCountryDelete.Text = "Выберите страну для удаления";
            // 
            // comboBoxCountryUpdate
            // 
            this.comboBoxCountryUpdate.FormattingEnabled = true;
            this.comboBoxCountryUpdate.Location = new System.Drawing.Point(578, 120);
            this.comboBoxCountryUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCountryUpdate.Name = "comboBoxCountryUpdate";
            this.comboBoxCountryUpdate.Size = new System.Drawing.Size(130, 21);
            this.comboBoxCountryUpdate.TabIndex = 5;
            this.comboBoxCountryUpdate.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // labelCountryUpdate
            // 
            this.labelCountryUpdate.AutoSize = true;
            this.labelCountryUpdate.Location = new System.Drawing.Point(575, 85);
            this.labelCountryUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountryUpdate.Name = "labelCountryUpdate";
            this.labelCountryUpdate.Size = new System.Drawing.Size(178, 13);
            this.labelCountryUpdate.TabIndex = 4;
            this.labelCountryUpdate.Text = "Выберите страну для обновления";
            // 
            // btnDeleteCountry
            // 
            this.btnDeleteCountry.Location = new System.Drawing.Point(600, 306);
            this.btnDeleteCountry.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteCountry.Name = "btnDeleteCountry";
            this.btnDeleteCountry.Size = new System.Drawing.Size(94, 38);
            this.btnDeleteCountry.TabIndex = 2;
            this.btnDeleteCountry.Text = "Удалить";
            this.btnDeleteCountry.UseVisualStyleBackColor = true;
            this.btnDeleteCountry.Click += new System.EventHandler(this.btnDeleteCountry_Click);
            // 
            // btnUpdateCountry
            // 
            this.btnUpdateCountry.Location = new System.Drawing.Point(600, 165);
            this.btnUpdateCountry.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateCountry.Name = "btnUpdateCountry";
            this.btnUpdateCountry.Size = new System.Drawing.Size(94, 33);
            this.btnUpdateCountry.TabIndex = 1;
            this.btnUpdateCountry.Text = "Обновить";
            this.btnUpdateCountry.UseVisualStyleBackColor = true;
            this.btnUpdateCountry.Click += new System.EventHandler(this.btnUpdateCountry_Click);
            // 
            // btnInsertCountry
            // 
            this.btnInsertCountry.Location = new System.Drawing.Point(582, 27);
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
            this.buttonLanguageDelete.Location = new System.Drawing.Point(624, 305);
            this.buttonLanguageDelete.Name = "buttonLanguageDelete";
            this.buttonLanguageDelete.Size = new System.Drawing.Size(88, 35);
            this.buttonLanguageDelete.TabIndex = 7;
            this.buttonLanguageDelete.Text = "Удалить";
            this.buttonLanguageDelete.UseVisualStyleBackColor = true;
            this.buttonLanguageDelete.Click += new System.EventHandler(this.buttonLanguageDelete_Click);
            // 
            // buttonLanguageUpdate
            // 
            this.buttonLanguageUpdate.Location = new System.Drawing.Point(624, 172);
            this.buttonLanguageUpdate.Name = "buttonLanguageUpdate";
            this.buttonLanguageUpdate.Size = new System.Drawing.Size(88, 33);
            this.buttonLanguageUpdate.TabIndex = 6;
            this.buttonLanguageUpdate.Text = "Обновить";
            this.buttonLanguageUpdate.UseVisualStyleBackColor = true;
            this.buttonLanguageUpdate.Click += new System.EventHandler(this.buttonLanguageUpdate_Click);
            // 
            // comboBoxLanguageDelete
            // 
            this.comboBoxLanguageDelete.FormattingEnabled = true;
            this.comboBoxLanguageDelete.Location = new System.Drawing.Point(601, 261);
            this.comboBoxLanguageDelete.Name = "comboBoxLanguageDelete";
            this.comboBoxLanguageDelete.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLanguageDelete.TabIndex = 5;
            // this.comboBoxLanguageDelete.Text = "русский";
            this.comboBoxLanguageDelete.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // comboBoxLanguageUpdate
            // 
            this.comboBoxLanguageUpdate.FormattingEnabled = true;
            this.comboBoxLanguageUpdate.Location = new System.Drawing.Point(601, 130);
            this.comboBoxLanguageUpdate.Name = "comboBoxLanguageUpdate";
            this.comboBoxLanguageUpdate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLanguageUpdate.TabIndex = 4;
            // this.comboBoxLanguageUpdate.Text = "китайский";
            this.comboBoxLanguageUpdate.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // labelLanguageDelete
            // 
            this.labelLanguageDelete.AutoSize = true;
            this.labelLanguageDelete.Location = new System.Drawing.Point(578, 225);
            this.labelLanguageDelete.Name = "labelLanguageDelete";
            this.labelLanguageDelete.Size = new System.Drawing.Size(157, 13);
            this.labelLanguageDelete.TabIndex = 3;
            this.labelLanguageDelete.Text = "Выберите язык для удаления";
            // 
            // labelLanguageUpdate
            // 
            this.labelLanguageUpdate.AutoSize = true;
            this.labelLanguageUpdate.Location = new System.Drawing.Point(578, 96);
            this.labelLanguageUpdate.Name = "labelLanguageUpdate";
            this.labelLanguageUpdate.Size = new System.Drawing.Size(170, 13);
            this.labelLanguageUpdate.TabIndex = 2;
            this.labelLanguageUpdate.Text = "Выберите язык для обновления";
            // 
            // btnInsertLanguage
            // 
            this.btnInsertLanguage.Location = new System.Drawing.Point(609, 36);
            this.btnInsertLanguage.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertLanguage.Name = "btnInsertLanguage";
            this.btnInsertLanguage.Size = new System.Drawing.Size(113, 37);
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
            this.labelEtnosYearUpdate.Location = new System.Drawing.Point(558, 177);
            this.labelEtnosYearUpdate.Name = "labelEtnosYearUpdate";
            this.labelEtnosYearUpdate.Size = new System.Drawing.Size(77, 13);
            this.labelEtnosYearUpdate.TabIndex = 16;
            this.labelEtnosYearUpdate.Text = "Выберите год";
            // 
            // comboBoxEtnosYearUpdate
            // 
            this.comboBoxEtnosYearUpdate.FormattingEnabled = true;
            this.comboBoxEtnosYearUpdate.Location = new System.Drawing.Point(652, 177);
            this.comboBoxEtnosYearUpdate.Name = "comboBoxEtnosYearUpdate";
            this.comboBoxEtnosYearUpdate.Size = new System.Drawing.Size(74, 21);
            this.comboBoxEtnosYearUpdate.TabIndex = 15;
            this.comboBoxEtnosYearUpdate.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // comboBoxEtnosYearDelete
            // 
            this.comboBoxEtnosYearDelete.FormattingEnabled = true;
            this.comboBoxEtnosYearDelete.Location = new System.Drawing.Point(652, 345);
            this.comboBoxEtnosYearDelete.Name = "comboBoxEtnosYearDelete";
            this.comboBoxEtnosYearDelete.Size = new System.Drawing.Size(74, 21);
            this.comboBoxEtnosYearDelete.TabIndex = 14;
            this.comboBoxEtnosYearDelete.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // labelEtnosYearDelete
            // 
            this.labelEtnosYearDelete.AutoSize = true;
            this.labelEtnosYearDelete.Location = new System.Drawing.Point(558, 345);
            this.labelEtnosYearDelete.Name = "labelEtnosYearDelete";
            this.labelEtnosYearDelete.Size = new System.Drawing.Size(77, 13);
            this.labelEtnosYearDelete.TabIndex = 13;
            this.labelEtnosYearDelete.Text = "Выберите год";
            // 
            // labelEtnosLanguageDelete
            // 
            this.labelEtnosLanguageDelete.AutoSize = true;
            this.labelEtnosLanguageDelete.Location = new System.Drawing.Point(678, 274);
            this.labelEtnosLanguageDelete.Name = "labelEtnosLanguageDelete";
            this.labelEtnosLanguageDelete.Size = new System.Drawing.Size(86, 13);
            this.labelEtnosLanguageDelete.TabIndex = 12;
            this.labelEtnosLanguageDelete.Text = "Выберите язык";
            // 
            // comboBoxEtnosLanguageDelete
            // 
            this.comboBoxEtnosLanguageDelete.FormattingEnabled = true;
            this.comboBoxEtnosLanguageDelete.Location = new System.Drawing.Point(681, 301);
            this.comboBoxEtnosLanguageDelete.Name = "comboBoxEtnosLanguageDelete";
            this.comboBoxEtnosLanguageDelete.Size = new System.Drawing.Size(83, 21);
            this.comboBoxEtnosLanguageDelete.TabIndex = 11;
            this.comboBoxEtnosLanguageDelete.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // comboBoxEtnosLanguageUpdate
            // 
            this.comboBoxEtnosLanguageUpdate.FormattingEnabled = true;
            this.comboBoxEtnosLanguageUpdate.Location = new System.Drawing.Point(663, 127);
            this.comboBoxEtnosLanguageUpdate.Name = "comboBoxEtnosLanguageUpdate";
            this.comboBoxEtnosLanguageUpdate.Size = new System.Drawing.Size(92, 21);
            this.comboBoxEtnosLanguageUpdate.TabIndex = 10;
            this.comboBoxEtnosLanguageUpdate.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // labelEtnosLanguageUpdate
            // 
            this.labelEtnosLanguageUpdate.AutoSize = true;
            this.labelEtnosLanguageUpdate.Location = new System.Drawing.Point(669, 95);
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
            this.comboBoxEtnosCountryDelete.Location = new System.Drawing.Point(558, 301);
            this.comboBoxEtnosCountryDelete.Name = "comboBoxEtnosCountryDelete";
            this.comboBoxEtnosCountryDelete.Size = new System.Drawing.Size(91, 21);
            this.comboBoxEtnosCountryDelete.TabIndex = 7;
            this.comboBoxEtnosCountryDelete.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // comboBoxEtnosCountryUpdate
            // 
            this.comboBoxEtnosCountryUpdate.FormattingEnabled = true;
            this.comboBoxEtnosCountryUpdate.Location = new System.Drawing.Point(555, 127);
            this.comboBoxEtnosCountryUpdate.Name = "comboBoxEtnosCountryUpdate";
            this.comboBoxEtnosCountryUpdate.Size = new System.Drawing.Size(91, 21);
            this.comboBoxEtnosCountryUpdate.TabIndex = 6;
            this.comboBoxEtnosCountryUpdate.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // labelEtnosCountryDelete
            // 
            this.labelEtnosCountryDelete.AutoSize = true;
            this.labelEtnosCountryDelete.Location = new System.Drawing.Point(555, 274);
            this.labelEtnosCountryDelete.Name = "labelEtnosCountryDelete";
            this.labelEtnosCountryDelete.Size = new System.Drawing.Size(94, 13);
            this.labelEtnosCountryDelete.TabIndex = 5;
            this.labelEtnosCountryDelete.Text = "Выберите страну";
            // 
            // labelEtnosCountryUpdate
            // 
            this.labelEtnosCountryUpdate.AutoSize = true;
            this.labelEtnosCountryUpdate.Location = new System.Drawing.Point(555, 95);
            this.labelEtnosCountryUpdate.Name = "labelEtnosCountryUpdate";
            this.labelEtnosCountryUpdate.Size = new System.Drawing.Size(94, 13);
            this.labelEtnosCountryUpdate.TabIndex = 4;
            this.labelEtnosCountryUpdate.Text = "Выберите страну";
            // 
            // buttonEtnosUpdate
            // 
            this.buttonEtnosUpdate.Location = new System.Drawing.Point(613, 214);
            this.buttonEtnosUpdate.Name = "buttonEtnosUpdate";
            this.buttonEtnosUpdate.Size = new System.Drawing.Size(82, 34);
            this.buttonEtnosUpdate.TabIndex = 3;
            this.buttonEtnosUpdate.Text = "Обновить";
            this.buttonEtnosUpdate.UseVisualStyleBackColor = true;
            this.buttonEtnosUpdate.Click += new System.EventHandler(this.buttonEtnosUpdate_Click);
            // 
            // buttonEtnosDelete
            // 
            this.buttonEtnosDelete.Location = new System.Drawing.Point(613, 382);
            this.buttonEtnosDelete.Name = "buttonEtnosDelete";
            this.buttonEtnosDelete.Size = new System.Drawing.Size(82, 33);
            this.buttonEtnosDelete.TabIndex = 2;
            this.buttonEtnosDelete.Text = "Удалить";
            this.buttonEtnosDelete.UseVisualStyleBackColor = true;
            this.buttonEtnosDelete.Click += new System.EventHandler(this.buttonEtnosDelete_Click);
            // 
            // btnInsertEtnos
            // 
            this.btnInsertEtnos.Location = new System.Drawing.Point(555, 17);
            this.btnInsertEtnos.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertEtnos.Name = "btnInsertEtnos";
            this.btnInsertEtnos.Size = new System.Drawing.Size(200, 37);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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

        private System.Windows.Forms.Button button1;

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
        private System.Windows.Forms.Button buttonLanguageDelete;
        private System.Windows.Forms.Button buttonLanguageUpdate;
        private System.Windows.Forms.ComboBox comboBoxLanguageDelete;
        private System.Windows.Forms.ComboBox comboBoxLanguageUpdate;
        private System.Windows.Forms.Label labelLanguageDelete;
        private System.Windows.Forms.Label labelLanguageUpdate;
        private System.Windows.Forms.ComboBox comboBoxEtnosCountryDelete;
        private System.Windows.Forms.ComboBox comboBoxEtnosCountryUpdate;
        private System.Windows.Forms.Label labelEtnosCountryDelete;
        private System.Windows.Forms.Label labelEtnosCountryUpdate;
        private System.Windows.Forms.Button buttonEtnosUpdate;
        private System.Windows.Forms.Button buttonEtnosDelete;
        private System.Windows.Forms.ListView listViewCountry;
        private ListView listViewLanguage;
        private ListView listViewEtnos;
        private System.Windows.Forms.Label labelEtnosLanguageUpdate;
        private System.Windows.Forms.ComboBox comboBoxEtnosLanguageUpdate;
        private System.Windows.Forms.ComboBox comboBoxEtnosLanguageDelete;
        private System.Windows.Forms.Label labelEtnosLanguageDelete;
        private System.Windows.Forms.Label labelEtnosYearDelete;
        private System.Windows.Forms.Label labelEtnosYearUpdate;
        private System.Windows.Forms.ComboBox comboBoxEtnosYearUpdate;
        private System.Windows.Forms.ComboBox comboBoxEtnosYearDelete;
    }
}

