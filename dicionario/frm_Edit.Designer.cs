﻿namespace dicionario
{
    partial class frm_Edit
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
            this.components = new System.ComponentModel.Container();
            this.txtpalavra = new System.Windows.Forms.TextBox();
            this.txtDefinicao = new System.Windows.Forms.TextBox();
            this.ComboGenero = new System.Windows.Forms.ComboBox();
            this.ComboIdioma = new System.Windows.Forms.ComboBox();
            this.ComboClasseGram = new System.Windows.Forms.ComboBox();
            this.label_palavra = new System.Windows.Forms.Label();
            this.label_acep = new System.Windows.Forms.Label();
            this.label_catgrama = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnApaga = new System.Windows.Forms.Button();
            this.menu_barra = new System.Windows.Forms.MenuStrip();
            this.acessoRápidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MarcaUsoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tip_Dicas = new System.Windows.Forms.ToolTip(this.components);
            this.txtSubLema = new System.Windows.Forms.TextBox();
            this.btnEquiv = new System.Windows.Forms.Button();
            this.btnConjuga = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProx = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboFiltroPrecisao = new System.Windows.Forms.ComboBox();
            this.comboFiltroIdiomas = new System.Windows.Forms.ComboBox();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboSinonimo2 = new System.Windows.Forms.ComboBox();
            this.comboSinonimo1 = new System.Windows.Forms.ComboBox();
            this.timerSinonimo = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.menu_barra.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtpalavra
            // 
            this.txtpalavra.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.txtpalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpalavra.Location = new System.Drawing.Point(60, 166);
            this.txtpalavra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpalavra.MaxLength = 45;
            this.txtpalavra.Name = "txtpalavra";
            this.txtpalavra.Size = new System.Drawing.Size(389, 30);
            this.txtpalavra.TabIndex = 0;
            this.tip_Dicas.SetToolTip(this.txtpalavra, "Digite a palavra ou conjunto de palavras que identificará está entrada");
            // 
            // txtDefinicao
            // 
            this.txtDefinicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefinicao.Location = new System.Drawing.Point(60, 306);
            this.txtDefinicao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDefinicao.Multiline = true;
            this.txtDefinicao.Name = "txtDefinicao";
            this.txtDefinicao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDefinicao.Size = new System.Drawing.Size(1020, 131);
            this.txtDefinicao.TabIndex = 5;
            this.tip_Dicas.SetToolTip(this.txtDefinicao, "Insira aqui alguma explicação que defina o lema");
            // 
            // ComboGenero
            // 
            this.ComboGenero.AutoCompleteCustomSource.AddRange(new string[] {
            "Masculino",
            "Feminino",
            "Neutro",
            "Masculino/Feminino"});
            this.ComboGenero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboGenero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboGenero.FormattingEnabled = true;
            this.ComboGenero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Neutro",
            "Masculino/Feminino"});
            this.ComboGenero.Location = new System.Drawing.Point(471, 239);
            this.ComboGenero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboGenero.Name = "ComboGenero";
            this.ComboGenero.Size = new System.Drawing.Size(211, 33);
            this.ComboGenero.TabIndex = 4;
            this.tip_Dicas.SetToolTip(this.ComboGenero, "Indique o gênero do lema");
            // 
            // ComboIdioma
            // 
            this.ComboIdioma.AutoCompleteCustomSource.AddRange(new string[] {
            "Português",
            "Espanhol",
            "Inglês"});
            this.ComboIdioma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboIdioma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ComboIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboIdioma.FormattingEnabled = true;
            this.ComboIdioma.Items.AddRange(new object[] {
            "Português",
            "Espanhol",
            "Inglês"});
            this.ComboIdioma.Location = new System.Drawing.Point(60, 239);
            this.ComboIdioma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboIdioma.Name = "ComboIdioma";
            this.ComboIdioma.Size = new System.Drawing.Size(181, 33);
            this.ComboIdioma.TabIndex = 2;
            this.tip_Dicas.SetToolTip(this.ComboIdioma, "Defina o idioma do lema");
            // 
            // ComboClasseGram
            // 
            this.ComboClasseGram.AutoCompleteCustomSource.AddRange(new string[] {
            "Artigo",
            "Substantivo",
            "Adjetivo",
            "Advérbio",
            "Preposição",
            "Conjunção",
            "Interjeição",
            "Pronome",
            "Verbo",
            "Numeral",
            "Substantivo-Adjetivo"});
            this.ComboClasseGram.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboClasseGram.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboClasseGram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboClasseGram.FormattingEnabled = true;
            this.ComboClasseGram.Items.AddRange(new object[] {
            "Artigo",
            "Substantivo",
            "Adjetivo",
            "Advérbio",
            "Preposição",
            "Conjunção",
            "Interjeição",
            "Pronome",
            "Verbo",
            "Numeral",
            "Substantivo-Adjetivo",
            "Un. Pluriverbal"});
            this.ComboClasseGram.Location = new System.Drawing.Point(251, 239);
            this.ComboClasseGram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboClasseGram.Name = "ComboClasseGram";
            this.ComboClasseGram.Size = new System.Drawing.Size(211, 33);
            this.ComboClasseGram.TabIndex = 3;
            this.tip_Dicas.SetToolTip(this.ComboClasseGram, "Determine a classe gramatical.\r\nDigite um texto para buscar registros existentes");
            // 
            // label_palavra
            // 
            this.label_palavra.AutoSize = true;
            this.label_palavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_palavra.Location = new System.Drawing.Point(56, 140);
            this.label_palavra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_palavra.Name = "label_palavra";
            this.label_palavra.Size = new System.Drawing.Size(57, 24);
            this.label_palavra.TabIndex = 26;
            this.label_palavra.Text = "Lema";
            // 
            // label_acep
            // 
            this.label_acep.AutoSize = true;
            this.label_acep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_acep.Location = new System.Drawing.Point(56, 281);
            this.label_acep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_acep.Name = "label_acep";
            this.label_acep.Size = new System.Drawing.Size(88, 24);
            this.label_acep.TabIndex = 30;
            this.label_acep.Text = "Definição";
            // 
            // label_catgrama
            // 
            this.label_catgrama.AutoSize = true;
            this.label_catgrama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_catgrama.Location = new System.Drawing.Point(247, 213);
            this.label_catgrama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_catgrama.Name = "label_catgrama";
            this.label_catgrama.Size = new System.Drawing.Size(159, 24);
            this.label_catgrama.TabIndex = 34;
            this.label_catgrama.Text = "Classe Gramatical";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblGenero.Location = new System.Drawing.Point(467, 213);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(74, 24);
            this.lblGenero.TabIndex = 38;
            this.lblGenero.Text = "Gênero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(56, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Idioma";
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(1157, 167);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 37);
            this.btnNovo.TabIndex = 40;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(1157, 212);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(100, 41);
            this.btnSalva.TabIndex = 8;
            this.btnSalva.Text = "Salvar";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnApaga
            // 
            this.btnApaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApaga.Location = new System.Drawing.Point(1157, 260);
            this.btnApaga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApaga.Name = "btnApaga";
            this.btnApaga.Size = new System.Drawing.Size(100, 39);
            this.btnApaga.TabIndex = 44;
            this.btnApaga.Text = "Excluir";
            this.btnApaga.UseVisualStyleBackColor = true;
            this.btnApaga.Click += new System.EventHandler(this.btnApaga_Click);
            // 
            // menu_barra
            // 
            this.menu_barra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_barra.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_barra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessoRápidoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menu_barra.Location = new System.Drawing.Point(0, 0);
            this.menu_barra.Name = "menu_barra";
            this.menu_barra.Size = new System.Drawing.Size(1344, 36);
            this.menu_barra.TabIndex = 46;
            this.menu_barra.Text = "menuStrip1";
            // 
            // acessoRápidoToolStripMenuItem
            // 
            this.acessoRápidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MarcaUsoToolStripMenuItem,
            this.referênciasToolStripMenuItem,
            this.toolStripSeparator1,
            this.importarToolStripMenuItem});
            this.acessoRápidoToolStripMenuItem.Name = "acessoRápidoToolStripMenuItem";
            this.acessoRápidoToolStripMenuItem.Size = new System.Drawing.Size(154, 32);
            this.acessoRápidoToolStripMenuItem.Text = "Acesso Rápido";
            // 
            // MarcaUsoToolStripMenuItem
            // 
            this.MarcaUsoToolStripMenuItem.Name = "MarcaUsoToolStripMenuItem";
            this.MarcaUsoToolStripMenuItem.Size = new System.Drawing.Size(226, 32);
            this.MarcaUsoToolStripMenuItem.Text = "Marcas de Uso";
            this.MarcaUsoToolStripMenuItem.Click += new System.EventHandler(this.rubricaToolStripMenuItem_Click);
            // 
            // referênciasToolStripMenuItem
            // 
            this.referênciasToolStripMenuItem.Name = "referênciasToolStripMenuItem";
            this.referênciasToolStripMenuItem.Size = new System.Drawing.Size(226, 32);
            this.referênciasToolStripMenuItem.Text = "Referências";
            this.referênciasToolStripMenuItem.Click += new System.EventHandler(this.referênciasToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(226, 32);
            this.importarToolStripMenuItem.Text = "Importar...";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.importarToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem,
            this.contatoToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(90, 32);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(169, 32);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // contatoToolStripMenuItem
            // 
            this.contatoToolStripMenuItem.Name = "contatoToolStripMenuItem";
            this.contatoToolStripMenuItem.Size = new System.Drawing.Size(169, 32);
            this.contatoToolStripMenuItem.Text = "Contato";
            this.contatoToolStripMenuItem.Click += new System.EventHandler(this.contatoToolStripMenuItem_Click);
            // 
            // txtSubLema
            // 
            this.txtSubLema.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.txtSubLema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubLema.Location = new System.Drawing.Point(459, 166);
            this.txtSubLema.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubLema.MaxLength = 45;
            this.txtSubLema.Name = "txtSubLema";
            this.txtSubLema.Size = new System.Drawing.Size(621, 30);
            this.txtSubLema.TabIndex = 1;
            this.tip_Dicas.SetToolTip(this.txtSubLema, "Digite a palavra ou conjunto de palavras que identificará está entrada");
            // 
            // btnEquiv
            // 
            this.btnEquiv.Enabled = false;
            this.btnEquiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquiv.Location = new System.Drawing.Point(1131, 583);
            this.btnEquiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEquiv.Name = "btnEquiv";
            this.btnEquiv.Size = new System.Drawing.Size(164, 47);
            this.btnEquiv.TabIndex = 58;
            this.btnEquiv.Text = "Equivalentes";
            this.btnEquiv.UseVisualStyleBackColor = true;
            this.btnEquiv.Click += new System.EventHandler(this.btnEquiv_Click);
            // 
            // btnConjuga
            // 
            this.btnConjuga.Enabled = false;
            this.btnConjuga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConjuga.Location = new System.Drawing.Point(1131, 532);
            this.btnConjuga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConjuga.Name = "btnConjuga";
            this.btnConjuga.Size = new System.Drawing.Size(164, 44);
            this.btnConjuga.TabIndex = 59;
            this.btnConjuga.Text = "Conjugações";
            this.btnConjuga.UseVisualStyleBackColor = true;
            this.btnConjuga.Click += new System.EventHandler(this.btnConjuga_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Enabled = false;
            this.btnPrimeiro.Location = new System.Drawing.Point(1157, 348);
            this.btnPrimeiro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(100, 28);
            this.btnPrimeiro.TabIndex = 60;
            this.btnPrimeiro.Text = "|<";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Location = new System.Drawing.Point(1157, 382);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(100, 28);
            this.btnAnterior.TabIndex = 61;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProx
            // 
            this.btnProx.Enabled = false;
            this.btnProx.Location = new System.Drawing.Point(1157, 417);
            this.btnProx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(100, 28);
            this.btnProx.TabIndex = 62;
            this.btnProx.Text = ">";
            this.btnProx.UseVisualStyleBackColor = true;
            this.btnProx.Click += new System.EventHandler(this.btnProx_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Enabled = false;
            this.btnUltimo.Location = new System.Drawing.Point(1157, 453);
            this.btnUltimo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(100, 28);
            this.btnUltimo.TabIndex = 63;
            this.btnUltimo.Text = ">|";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComboFiltroPrecisao);
            this.groupBox1.Controls.Add(this.comboFiltroIdiomas);
            this.groupBox1.Controls.Add(this.filterComboBox);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.searchBox);
            this.groupBox1.Location = new System.Drawing.Point(60, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1021, 70);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // ComboFiltroPrecisao
            // 
            this.ComboFiltroPrecisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboFiltroPrecisao.FormattingEnabled = true;
            this.ComboFiltroPrecisao.Items.AddRange(new object[] {
            "Exatamente",
            "Contém"});
            this.ComboFiltroPrecisao.Location = new System.Drawing.Point(667, 18);
            this.ComboFiltroPrecisao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboFiltroPrecisao.Name = "ComboFiltroPrecisao";
            this.ComboFiltroPrecisao.Size = new System.Drawing.Size(160, 33);
            this.ComboFiltroPrecisao.TabIndex = 55;
            this.ComboFiltroPrecisao.Text = "Precisão";
            // 
            // comboFiltroIdiomas
            // 
            this.comboFiltroIdiomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFiltroIdiomas.FormattingEnabled = true;
            this.comboFiltroIdiomas.Items.AddRange(new object[] {
            "Qualquer",
            "BR",
            "EN",
            "ES"});
            this.comboFiltroIdiomas.Location = new System.Drawing.Point(295, 18);
            this.comboFiltroIdiomas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboFiltroIdiomas.Name = "comboFiltroIdiomas";
            this.comboFiltroIdiomas.Size = new System.Drawing.Size(145, 33);
            this.comboFiltroIdiomas.TabIndex = 54;
            this.comboFiltroIdiomas.Text = "Idiomas";
            // 
            // filterComboBox
            // 
            this.filterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "Lema",
            "Código"});
            this.filterComboBox.Location = new System.Drawing.Point(488, 18);
            this.filterComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(145, 33);
            this.filterComboBox.TabIndex = 53;
            this.filterComboBox.Text = "Filtro";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(855, 16);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(147, 34);
            this.searchButton.TabIndex = 52;
            this.searchButton.Text = "Procurar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
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
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(20, 21);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBox.MaxLength = 45;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(237, 30);
            this.searchBox.TabIndex = 51;
            this.searchBox.Text = "Buscar...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboSinonimo2);
            this.groupBox2.Controls.Add(this.comboSinonimo1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(60, 446);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1021, 73);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sinônimos";
            // 
            // comboSinonimo2
            // 
            this.comboSinonimo2.FormattingEnabled = true;
            this.comboSinonimo2.Location = new System.Drawing.Point(521, 28);
            this.comboSinonimo2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboSinonimo2.Name = "comboSinonimo2";
            this.comboSinonimo2.Size = new System.Drawing.Size(479, 30);
            this.comboSinonimo2.TabIndex = 7;
            this.comboSinonimo2.SelectedIndexChanged += new System.EventHandler(this.comboSinonimo2_SelectedIndexChanged);
            this.comboSinonimo2.TextUpdate += new System.EventHandler(this.comboSinonimo2_TextUpdate);
            // 
            // comboSinonimo1
            // 
            this.comboSinonimo1.FormattingEnabled = true;
            this.comboSinonimo1.Location = new System.Drawing.Point(20, 28);
            this.comboSinonimo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboSinonimo1.Name = "comboSinonimo1";
            this.comboSinonimo1.Size = new System.Drawing.Size(492, 30);
            this.comboSinonimo1.TabIndex = 6;
            this.comboSinonimo1.SelectedIndexChanged += new System.EventHandler(this.comboSinonimo1_SelectedIndexChanged);
            this.comboSinonimo1.TextUpdate += new System.EventHandler(this.comboSinonimo1_TextUpdate);
            // 
            // timerSinonimo
            // 
            this.timerSinonimo.Interval = 700;
            this.timerSinonimo.Tick += new System.EventHandler(this.timerSinonimo_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(455, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 69;
            this.label2.Text = "Sublema";
            // 
            // frm_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 667);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSubLema);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnProx);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnConjuga);
            this.Controls.Add(this.btnEquiv);
            this.Controls.Add(this.menu_barra);
            this.Controls.Add(this.btnApaga);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.label_catgrama);
            this.Controls.Add(this.label_acep);
            this.Controls.Add(this.label_palavra);
            this.Controls.Add(this.ComboClasseGram);
            this.Controls.Add(this.ComboIdioma);
            this.Controls.Add(this.ComboGenero);
            this.Controls.Add(this.txtDefinicao);
            this.Controls.Add(this.txtpalavra);
            this.MainMenuStrip = this.menu_barra;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1359, 703);
            this.Name = "frm_Edit";
            this.Text = "Edição de entradas";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.menu_barra.ResumeLayout(false);
            this.menu_barra.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtpalavra;
        private System.Windows.Forms.TextBox txtDefinicao;
        private System.Windows.Forms.ComboBox ComboGenero;
        private System.Windows.Forms.ComboBox ComboIdioma;
        private System.Windows.Forms.ComboBox ComboClasseGram;
        private System.Windows.Forms.Label label_palavra;
        private System.Windows.Forms.Label label_acep;
        private System.Windows.Forms.Label label_catgrama;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnApaga;
        private System.Windows.Forms.MenuStrip menu_barra;
        private System.Windows.Forms.ToolStripMenuItem acessoRápidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MarcaUsoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contatoToolStripMenuItem;
        private System.Windows.Forms.ToolTip tip_Dicas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.Button btnEquiv;
        private System.Windows.Forms.Button btnConjuga;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProx;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboFiltroPrecisao;
        private System.Windows.Forms.ComboBox comboFiltroIdiomas;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboSinonimo2;
        private System.Windows.Forms.ComboBox comboSinonimo1;
        private System.Windows.Forms.Timer timerSinonimo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubLema;
    }
}