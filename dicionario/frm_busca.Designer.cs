﻿namespace dicionario
{
    partial class frm_busca
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResultsListBox = new System.Windows.Forms.ListBox();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.extraFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.extraComboBox1 = new System.Windows.Forms.ComboBox();
            this.extraComboBox2 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administrativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verbetesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.similarListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Country",
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei Darussalam",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Costa Rica",
            "Côte d\'Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Democratic People\'s Republic of Korea (North Korea)",
            "Democratic Republic of the Cong",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Kuwait",
            "Kyrgyzstan",
            "Lao People\'s Democratic Republic (Laos)",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia (Federated States of)",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Republic of Korea (South Korea)",
            "Republic of Moldova",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syrian Arab Republic",
            "Tajikistan",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom of Great Britain and Northern Ireland",
            "United Republic of Tanzania",
            "United States of America",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(29, 106);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(263, 30);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.searchLabel.Location = new System.Drawing.Point(29, 54);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(98, 36);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Busca";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(604, 105);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(147, 32);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Procurar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchResultsListBox
            // 
            this.searchResultsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.searchResultsListBox.FormattingEnabled = true;
            this.searchResultsListBox.ItemHeight = 20;
            this.searchResultsListBox.Location = new System.Drawing.Point(232, 236);
            this.searchResultsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchResultsListBox.Name = "searchResultsListBox";
            this.searchResultsListBox.Size = new System.Drawing.Size(516, 244);
            this.searchResultsListBox.TabIndex = 3;
            this.searchResultsListBox.SelectedIndexChanged += new System.EventHandler(this.searchResultsListBox_SelectedIndexChanged);
            this.searchResultsListBox.DoubleClick += new System.EventHandler(this.searchResultsListBox_DoubleClick);
            // 
            // filterComboBox
            // 
            this.filterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "Exatamente",
            "Contém na entrada",
            "Anagrama",
            "Contém no conteúdo",
            "Exemplo",
            "Heterogenérico",
            "Heterotônico"});
            this.filterComboBox.Location = new System.Drawing.Point(301, 106);
            this.filterComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(203, 30);
            this.filterComboBox.TabIndex = 16;
            this.filterComboBox.Text = "Filtros";
            // 
            // extraFilterCheckBox
            // 
            this.extraFilterCheckBox.AutoSize = true;
            this.extraFilterCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.extraFilterCheckBox.Location = new System.Drawing.Point(29, 146);
            this.extraFilterCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.extraFilterCheckBox.Name = "extraFilterCheckBox";
            this.extraFilterCheckBox.Size = new System.Drawing.Size(129, 24);
            this.extraFilterCheckBox.TabIndex = 17;
            this.extraFilterCheckBox.Text = "Filtros extras";
            this.extraFilterCheckBox.UseVisualStyleBackColor = true;
            this.extraFilterCheckBox.CheckedChanged += new System.EventHandler(this.extraFilterCheckBox_CheckedChanged);
            // 
            // extraComboBox1
            // 
            this.extraComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraComboBox1.FormattingEnabled = true;
            this.extraComboBox1.Location = new System.Drawing.Point(301, 146);
            this.extraComboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.extraComboBox1.Name = "extraComboBox1";
            this.extraComboBox1.Size = new System.Drawing.Size(203, 28);
            this.extraComboBox1.TabIndex = 18;
            // 
            // extraComboBox2
            // 
            this.extraComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraComboBox2.FormattingEnabled = true;
            this.extraComboBox2.Location = new System.Drawing.Point(301, 180);
            this.extraComboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.extraComboBox2.Name = "extraComboBox2";
            this.extraComboBox2.Size = new System.Drawing.Size(203, 28);
            this.extraComboBox2.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrativoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 36);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administrativoToolStripMenuItem
            // 
            this.administrativoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verbetesToolStripMenuItem,
            this.toolStripSeparator1,
            this.configuraçãoToolStripMenuItem});
            this.administrativoToolStripMenuItem.Name = "administrativoToolStripMenuItem";
            this.administrativoToolStripMenuItem.Size = new System.Drawing.Size(135, 32);
            this.administrativoToolStripMenuItem.Text = "Manutenção";
            // 
            // verbetesToolStripMenuItem
            // 
            this.verbetesToolStripMenuItem.Name = "verbetesToolStripMenuItem";
            this.verbetesToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.verbetesToolStripMenuItem.Text = "Verbetes";
            this.verbetesToolStripMenuItem.Click += new System.EventHandler(this.editModeButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            this.configuraçãoToolStripMenuItem.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // similarListBox
            // 
            this.similarListBox.Enabled = false;
            this.similarListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.similarListBox.FormattingEnabled = true;
            this.similarListBox.ItemHeight = 20;
            this.similarListBox.Location = new System.Drawing.Point(29, 236);
            this.similarListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.similarListBox.Name = "similarListBox";
            this.similarListBox.Size = new System.Drawing.Size(193, 244);
            this.similarListBox.TabIndex = 22;
            this.similarListBox.DoubleClick += new System.EventHandler(this.similarListBox_DoubleClick);
            // 
            // frm_busca
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 507);
            this.Controls.Add(this.similarListBox);
            this.Controls.Add(this.extraComboBox2);
            this.Controls.Add(this.extraComboBox1);
            this.Controls.Add(this.extraFilterCheckBox);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.searchResultsListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(794, 543);
            this.Name = "frm_busca";
            this.Text = "Dicionário";
            this.Load += new System.EventHandler(this.Frm_busca_Load);
            this.Resize += new System.EventHandler(this.frm_busca_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox searchResultsListBox;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.CheckBox extraFilterCheckBox;
        private System.Windows.Forms.ComboBox extraComboBox1;
        private System.Windows.Forms.ComboBox extraComboBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administrativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verbetesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ListBox similarListBox;
    }
}

