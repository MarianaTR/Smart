namespace ptobandoForms
{
    partial class Form1
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
            this.smartList = new System.Windows.Forms.Button();
            this.MuestraSmartPanel = new System.Windows.Forms.Panel();
            this.DeletePanel = new System.Windows.Forms.Panel();
            this.Atras1 = new System.Windows.Forms.Button();
            this.ListSmartDelete = new System.Windows.Forms.ComboBox();
            this.DeleteButtom = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.busqueda = new System.Windows.Forms.ComboBox();
            this.agregar = new System.Windows.Forms.Button();
            this.Atras = new System.Windows.Forms.Button();
            this.SentenceBox = new System.Windows.Forms.TextBox();
            this.ImageSmartPanel = new System.Windows.Forms.Panel();
            this.addSmart = new System.Windows.Forms.Panel();
            this.SeacherPattern = new System.Windows.Forms.TextBox();
            this.OpcionesPanel = new System.Windows.Forms.Panel();
            this.CalificationUp = new System.Windows.Forms.NumericUpDown();
            this.NationalityComboBox = new System.Windows.Forms.ComboBox();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.SexComboBox = new System.Windows.Forms.ComboBox();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.UnionComboBox = new System.Windows.Forms.ComboBox();
            this.Latitud = new System.Windows.Forms.NumericUpDown();
            this.YesNo = new System.Windows.Forms.DomainUpDown();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.Longitud = new System.Windows.Forms.NumericUpDown();
            this.AddSmarListButton = new System.Windows.Forms.Button();
            this.DeleteSmartButton = new System.Windows.Forms.Button();
            this.DeletePanel.SuspendLayout();
            this.ImageSmartPanel.SuspendLayout();
            this.addSmart.SuspendLayout();
            this.OpcionesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalificationUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Latitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Longitud)).BeginInit();
            this.SuspendLayout();
            // 
            // smartList
            // 
            this.smartList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.smartList.BackColor = System.Drawing.SystemColors.Control;
            this.smartList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.smartList.Location = new System.Drawing.Point(86, 419);
            this.smartList.MaximumSize = new System.Drawing.Size(150, 23);
            this.smartList.Name = "smartList";
            this.smartList.Size = new System.Drawing.Size(119, 23);
            this.smartList.TabIndex = 0;
            this.smartList.Text = "Smart List";
            this.smartList.UseVisualStyleBackColor = false;
            this.smartList.Click += new System.EventHandler(this.SmartList_Click);
            // 
            // MuestraSmartPanel
            // 
            this.MuestraSmartPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MuestraSmartPanel.AutoScroll = true;
            this.MuestraSmartPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MuestraSmartPanel.Location = new System.Drawing.Point(86, 448);
            this.MuestraSmartPanel.Name = "MuestraSmartPanel";
            this.MuestraSmartPanel.Size = new System.Drawing.Size(767, 234);
            this.MuestraSmartPanel.TabIndex = 1;
            // 
            // DeletePanel
            // 
            this.DeletePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeletePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DeletePanel.Controls.Add(this.Atras1);
            this.DeletePanel.Controls.Add(this.ListSmartDelete);
            this.DeletePanel.Controls.Add(this.DeleteButtom);
            this.DeletePanel.Location = new System.Drawing.Point(38, 49);
            this.DeletePanel.Name = "DeletePanel";
            this.DeletePanel.Size = new System.Drawing.Size(397, 127);
            this.DeletePanel.TabIndex = 5;
            this.DeletePanel.Visible = false;
            // 
            // Atras1
            // 
            this.Atras1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Atras1.Location = new System.Drawing.Point(38, 89);
            this.Atras1.Name = "Atras1";
            this.Atras1.Size = new System.Drawing.Size(311, 23);
            this.Atras1.TabIndex = 2;
            this.Atras1.Text = "Close";
            this.Atras1.UseVisualStyleBackColor = true;
            this.Atras1.Click += new System.EventHandler(this.Atras1_Click);
            // 
            // ListSmartDelete
            // 
            this.ListSmartDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListSmartDelete.Location = new System.Drawing.Point(19, 15);
            this.ListSmartDelete.Name = "ListSmartDelete";
            this.ListSmartDelete.Size = new System.Drawing.Size(357, 24);
            this.ListSmartDelete.TabIndex = 0;
            this.ListSmartDelete.Text = "Smart Lists";
            // 
            // DeleteButtom
            // 
            this.DeleteButtom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButtom.Location = new System.Drawing.Point(38, 53);
            this.DeleteButtom.Name = "DeleteButtom";
            this.DeleteButtom.Size = new System.Drawing.Size(311, 23);
            this.DeleteButtom.TabIndex = 1;
            this.DeleteButtom.Text = "Delete";
            this.DeleteButtom.UseVisualStyleBackColor = true;
            this.DeleteButtom.Click += new System.EventHandler(this.DeleteButtom_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(110, 67);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(117, 25);
            this.AddButton.TabIndex = 2;
            this.AddButton.TabStop = false;
            this.AddButton.Text = "Add Sentence";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Visible = false;
            this.AddButton.Click += new System.EventHandler(this.AddSmartListButton_Click);
            // 
            // busqueda
            // 
            this.busqueda.FormattingEnabled = true;
            this.busqueda.Items.AddRange(new object[] {
            "Sentence:",
            "Name:",
            "Surname:",
            "Filter:",
            "Birthdate:",
            "Sex:",
            "EyesColor:",
            "HairColor:",
            "Nationality:",
            "GeographicLocation:",
            "Address:",
            "Photographer:",
            "Photomotive:",
            "Selfie:",
            "Calification:"});
            this.busqueda.Location = new System.Drawing.Point(38, 84);
            this.busqueda.Name = "busqueda";
            this.busqueda.Size = new System.Drawing.Size(121, 24);
            this.busqueda.TabIndex = 7;
            this.busqueda.Text = "Busqueda";
            this.busqueda.SelectedIndexChanged += new System.EventHandler(this.Busqueda_SelectedIndexChanged);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(38, 159);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(144, 27);
            this.agregar.TabIndex = 8;
            this.agregar.Text = "Add Pattern";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Atras
            // 
            this.Atras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Atras.Location = new System.Drawing.Point(267, 160);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(144, 26);
            this.Atras.TabIndex = 3;
            this.Atras.Text = "Close";
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // SentenceBox
            // 
            this.SentenceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SentenceBox.BackColor = System.Drawing.Color.White;
            this.SentenceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SentenceBox.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F);
            this.SentenceBox.ForeColor = System.Drawing.Color.Black;
            this.SentenceBox.Location = new System.Drawing.Point(51, 20);
            this.SentenceBox.Name = "SentenceBox";
            this.SentenceBox.Size = new System.Drawing.Size(171, 24);
            this.SentenceBox.TabIndex = 1;
            this.SentenceBox.Text = "Sentence";
            this.SentenceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SentenceBox.Visible = false;
            // 
            // ImageSmartPanel
            // 
            this.ImageSmartPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageSmartPanel.AutoScroll = true;
            this.ImageSmartPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ImageSmartPanel.Controls.Add(this.addSmart);
            this.ImageSmartPanel.Location = new System.Drawing.Point(260, 448);
            this.ImageSmartPanel.Name = "ImageSmartPanel";
            this.ImageSmartPanel.Size = new System.Drawing.Size(894, 234);
            this.ImageSmartPanel.TabIndex = 2;
            // 
            // addSmart
            // 
            this.addSmart.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addSmart.Controls.Add(this.DeletePanel);
            this.addSmart.Controls.Add(this.SeacherPattern);
            this.addSmart.Controls.Add(this.agregar);
            this.addSmart.Controls.Add(this.Atras);
            this.addSmart.Controls.Add(this.busqueda);
            this.addSmart.Controls.Add(this.OpcionesPanel);
            this.addSmart.Location = new System.Drawing.Point(61, 3);
            this.addSmart.Name = "addSmart";
            this.addSmart.Size = new System.Drawing.Size(471, 226);
            this.addSmart.TabIndex = 5;
            this.addSmart.Visible = false;
            // 
            // SeacherPattern
            // 
            this.SeacherPattern.Location = new System.Drawing.Point(56, 18);
            this.SeacherPattern.Name = "SeacherPattern";
            this.SeacherPattern.Size = new System.Drawing.Size(355, 22);
            this.SeacherPattern.TabIndex = 0;
            this.SeacherPattern.Text = "Seacher Pattern";
            this.SeacherPattern.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SeacherPattern.TextChanged += new System.EventHandler(this.SeacherPattern_TextChanged);
            // 
            // OpcionesPanel
            // 
            this.OpcionesPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OpcionesPanel.Controls.Add(this.CalificationUp);
            this.OpcionesPanel.Controls.Add(this.SentenceBox);
            this.OpcionesPanel.Controls.Add(this.NationalityComboBox);
            this.OpcionesPanel.Controls.Add(this.ColorComboBox);
            this.OpcionesPanel.Controls.Add(this.SexComboBox);
            this.OpcionesPanel.Controls.Add(this.AddButton);
            this.OpcionesPanel.Controls.Add(this.FiltroComboBox);
            this.OpcionesPanel.Controls.Add(this.UnionComboBox);
            this.OpcionesPanel.Controls.Add(this.Latitud);
            this.OpcionesPanel.Controls.Add(this.YesNo);
            this.OpcionesPanel.Controls.Add(this.BirthDate);
            this.OpcionesPanel.Controls.Add(this.Longitud);
            this.OpcionesPanel.Location = new System.Drawing.Point(189, 46);
            this.OpcionesPanel.Name = "OpcionesPanel";
            this.OpcionesPanel.Size = new System.Drawing.Size(246, 97);
            this.OpcionesPanel.TabIndex = 6;
            // 
            // CalificationUp
            // 
            this.CalificationUp.Location = new System.Drawing.Point(110, 20);
            this.CalificationUp.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.CalificationUp.Name = "CalificationUp";
            this.CalificationUp.Size = new System.Drawing.Size(61, 22);
            this.CalificationUp.TabIndex = 6;
            this.CalificationUp.Visible = false;
            // 
            // NationalityComboBox
            // 
            this.NationalityComboBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NationalityComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NationalityComboBox.ForeColor = System.Drawing.Color.White;
            this.NationalityComboBox.FormattingEnabled = true;
            this.NationalityComboBox.Items.AddRange(new object[] {
            "None",
            "Afganistán",
            "Albania",
            "Alemania",
            "Andorra",
            "Angola",
            "AntiguayBarbuda",
            "ArabiaSaudita",
            "Argelia",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaiyán",
            "Bahamas",
            "Bangladés",
            "Barbados",
            "Baréin",
            "Bélgica",
            "Belice",
            "Benín",
            "Bielorrusia",
            "BirmaniaMyanmar",
            "Bolivia",
            "BosniayHerzegovina",
            "Botsuana",
            "Brasil",
            "Brunéi",
            "Bulgaria",
            "BurkinaFaso",
            "Burundi",
            "Bután",
            "CaboVerde",
            "Camboya",
            "Camerún",
            "Canada",
            "Catar",
            "Chad",
            "Chile",
            "China",
            "Chipre",
            "CiudaddelVaticano",
            "Colombia",
            "Comoras",
            "CoreadelNorte",
            "CoreadelSur",
            "CostadeMarfil",
            "CostaRica",
            "Croacia",
            "Cuba",
            "Dinamarca",
            "Dominica",
            "Ecuador",
            "Egipto",
            "ElSalvador",
            "EmiratosÁrabesUnidos",
            "Eritrea",
            "Eslovaquia",
            "Eslovenia",
            "España",
            "EstadosUnidos",
            "Estonia",
            "Etiopía",
            "Filipinas",
            "Finlandia",
            "Fiyi",
            "Francia",
            "Gabón",
            "Gambia",
            "Georgia",
            "Ghana",
            "Granada",
            "Grecia",
            "Guatemala",
            "Guyana",
            "Guinea",
            "Guineaecuatorial",
            "GuineaBisáu",
            "Haití",
            "Honduras",
            "Hungría",
            "India",
            "Indonesia",
            "Irak",
            "Irán",
            "Irlanda",
            "Islandia",
            "IslasMarshall",
            "IslasSalomón",
            "Israel",
            "Italia",
            "Jamaica",
            "Japón",
            "Jordania",
            "Kazajistán",
            "Kenia",
            "Kirguistán",
            "Kiribati",
            "Kuwait",
            "Laos",
            "Lesoto",
            "Letonia",
            "Líbano",
            "Liberia",
            "Libia",
            "Liechtenstein",
            "Lituania",
            "Luxemburgo",
            "MacedoniadelNorte",
            "Madagascar",
            "Malasia",
            "Malaui",
            "Maldivas",
            "Malí",
            "Malta",
            "Marruecos",
            "Mauricio",
            "Mauritania",
            "México",
            "Micronesia",
            "Moldavia",
            "Mónaco",
            "Mongolia",
            "Montenegro",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Nepal",
            "Nicaragua",
            "Níger",
            "Nigeria",
            "Noruega",
            "NuevaZelanda",
            "Omán",
            "PaísesBajos",
            "Pakistán",
            "Palaos",
            "Panamá",
            "PapúaNuevaGuinea",
            "Paraguay",
            "Perú",
            "Polonia",
            "Portugal",
            "ReinoUnido",
            "RepúblicaCentroafricana",
            "RepúblicaCheca",
            "RepúblicadelCongo",
            "RepúblicaDemocráticadelCongo",
            "RepúblicaDominicana",
            "RepúblicaSudafricana",
            "Ruanda",
            "Rumanía",
            "Rusia",
            "Samoa",
            "SanCristóbalyNieves",
            "SanMarino",
            "SanVicenteylasGranadinas",
            "SantaLucía",
            "SantoToméyPríncipe",
            "Senegal",
            "Serbia",
            "Seychelles",
            "SierraLeona",
            "Singapur",
            "Siria",
            "Somalia",
            "SriLanka",
            "Suazilandia",
            "Sudán",
            "SudándelSur",
            "Suecia",
            "Suiza",
            "Surinam",
            "Tailandia",
            "Tanzania",
            "Tayikistán",
            "TimorOriental",
            "Togo",
            "Tonga",
            "TrinidadyTobago",
            "Túnez",
            "Turkmenistán",
            "Turquía",
            "Tuvalu",
            "Ucrania",
            "Uganda",
            "Uruguay",
            "Uzbekistán",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Yibuti",
            "Zambia",
            "Zimbabue"});
            this.NationalityComboBox.Location = new System.Drawing.Point(78, 19);
            this.NationalityComboBox.Name = "NationalityComboBox";
            this.NationalityComboBox.Size = new System.Drawing.Size(121, 24);
            this.NationalityComboBox.TabIndex = 2;
            this.NationalityComboBox.Text = "None";
            this.NationalityComboBox.Visible = false;
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Items.AddRange(new object[] {
            "Rojo",
            "Azul",
            "Verde",
            "Amarillo",
            "Naranja",
            "Morado",
            "Rosa",
            "Marron",
            "Blanco",
            "Negro",
            "Gris",
            "Fucsia",
            "None"});
            this.ColorComboBox.Location = new System.Drawing.Point(78, 22);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(121, 24);
            this.ColorComboBox.TabIndex = 7;
            this.ColorComboBox.Text = "None";
            this.ColorComboBox.Visible = false;
            // 
            // SexComboBox
            // 
            this.SexComboBox.FormattingEnabled = true;
            this.SexComboBox.Items.AddRange(new object[] {
            "Mujer",
            "Hombre",
            "None"});
            this.SexComboBox.Location = new System.Drawing.Point(78, 20);
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.Size = new System.Drawing.Size(121, 24);
            this.SexComboBox.TabIndex = 6;
            this.SexComboBox.Text = "None";
            this.SexComboBox.Visible = false;
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "AutomaticAdjustmentFilter",
            "BlackNWhiteFilter",
            "BrightnessFilter",
            "ColorFilter",
            "InvertFilter",
            "SepiaFilter",
            "RotateFlipFilter",
            "MirrorFilter",
            "OldFilmFilter",
            "WindowsFilter"});
            this.FiltroComboBox.Location = new System.Drawing.Point(78, 20);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(121, 24);
            this.FiltroComboBox.TabIndex = 9;
            this.FiltroComboBox.Text = "None";
            this.FiltroComboBox.Visible = false;
            // 
            // UnionComboBox
            // 
            this.UnionComboBox.FormattingEnabled = true;
            this.UnionComboBox.Items.AddRange(new object[] {
            "and",
            "or",
            "none"});
            this.UnionComboBox.Location = new System.Drawing.Point(14, 67);
            this.UnionComboBox.Name = "UnionComboBox";
            this.UnionComboBox.Size = new System.Drawing.Size(72, 24);
            this.UnionComboBox.TabIndex = 15;
            this.UnionComboBox.Text = "none";
            this.UnionComboBox.Visible = false;
            // 
            // Latitud
            // 
            this.Latitud.Location = new System.Drawing.Point(149, 23);
            this.Latitud.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.Latitud.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.Latitud.Name = "Latitud";
            this.Latitud.Size = new System.Drawing.Size(51, 22);
            this.Latitud.TabIndex = 14;
            this.Latitud.Visible = false;
            // 
            // YesNo
            // 
            this.YesNo.Items.Add("Si");
            this.YesNo.Items.Add("No");
            this.YesNo.Location = new System.Drawing.Point(80, 21);
            this.YesNo.Name = "YesNo";
            this.YesNo.Size = new System.Drawing.Size(120, 22);
            this.YesNo.TabIndex = 8;
            this.YesNo.Visible = false;
            // 
            // BirthDate
            // 
            this.BirthDate.Location = new System.Drawing.Point(14, 23);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(227, 22);
            this.BirthDate.TabIndex = 10;
            this.BirthDate.Visible = false;
            // 
            // Longitud
            // 
            this.Longitud.Location = new System.Drawing.Point(32, 23);
            this.Longitud.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.Longitud.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(54, 22);
            this.Longitud.TabIndex = 13;
            this.Longitud.Visible = false;
            // 
            // AddSmarListButton
            // 
            this.AddSmarListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddSmarListButton.Location = new System.Drawing.Point(211, 419);
            this.AddSmarListButton.Name = "AddSmarListButton";
            this.AddSmarListButton.Size = new System.Drawing.Size(124, 23);
            this.AddSmarListButton.TabIndex = 3;
            this.AddSmarListButton.Text = "Add Smart List";
            this.AddSmarListButton.UseVisualStyleBackColor = true;
            this.AddSmarListButton.Click += new System.EventHandler(this.AddSmarListButton_Click);
            // 
            // DeleteSmartButton
            // 
            this.DeleteSmartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteSmartButton.Location = new System.Drawing.Point(341, 418);
            this.DeleteSmartButton.Name = "DeleteSmartButton";
            this.DeleteSmartButton.Size = new System.Drawing.Size(139, 25);
            this.DeleteSmartButton.TabIndex = 4;
            this.DeleteSmartButton.Text = "Delete Smart List";
            this.DeleteSmartButton.UseVisualStyleBackColor = true;
            this.DeleteSmartButton.Click += new System.EventHandler(this.DeleteSmartButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1154, 682);
            this.Controls.Add(this.DeleteSmartButton);
            this.Controls.Add(this.AddSmarListButton);
            this.Controls.Add(this.smartList);
            this.Controls.Add(this.ImageSmartPanel);
            this.Controls.Add(this.MuestraSmartPanel);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DeletePanel.ResumeLayout(false);
            this.ImageSmartPanel.ResumeLayout(false);
            this.addSmart.ResumeLayout(false);
            this.addSmart.PerformLayout();
            this.OpcionesPanel.ResumeLayout(false);
            this.OpcionesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalificationUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Latitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Longitud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button smartList;
        private System.Windows.Forms.Panel MuestraSmartPanel;
        private System.Windows.Forms.Panel ImageSmartPanel;
        private System.Windows.Forms.Button AddSmarListButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox SentenceBox;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Button DeleteSmartButton;
        private System.Windows.Forms.Panel DeletePanel;
        private System.Windows.Forms.ComboBox ListSmartDelete;
        private System.Windows.Forms.Button Atras1;
        private System.Windows.Forms.Button DeleteButtom;
        private System.Windows.Forms.ComboBox busqueda;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Panel addSmart;
        private System.Windows.Forms.TextBox SeacherPattern;
        private System.Windows.Forms.Panel OpcionesPanel;
        private System.Windows.Forms.ComboBox NationalityComboBox;
        private System.Windows.Forms.ComboBox SexComboBox;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.DomainUpDown YesNo;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.NumericUpDown Longitud;
        private System.Windows.Forms.NumericUpDown Latitud;
        private System.Windows.Forms.ComboBox UnionComboBox;
        private System.Windows.Forms.NumericUpDown CalificationUp;
    }
}

