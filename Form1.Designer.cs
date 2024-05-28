namespace BLOKA16
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxKategorija = new System.Windows.Forms.ComboBox();
            this.comboBoxIzlozba = new System.Windows.Forms.ComboBox();
            this.comboBoxPas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.dataGridViewKategorije = new System.Windows.Forms.DataGridView();
            this.buttonIzmenaKategorije = new System.Windows.Forms.Button();
            this.textBoxNazivKat = new System.Windows.Forms.TextBox();
            this.textBoxIDKat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonIzadji = new System.Windows.Forms.Button();
            this.buttonPrikazi = new System.Windows.Forms.Button();
            this.labelUkupnoTakmicilo = new System.Windows.Forms.Label();
            this.labelUkupnoPrijavljeno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxIzlozba2 = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorije)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(728, 440);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.comboBoxKategorija);
            this.tabPage1.Controls.Add(this.comboBoxIzlozba);
            this.tabPage1.Controls.Add(this.comboBoxPas);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(720, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unesi prijavu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::A16.Properties.Resources.pasmacka;
            this.pictureBox1.Location = new System.Drawing.Point(364, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Zatvori aplikaciju";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prijava";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::A16.Properties.Resources.zatvori;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(171, 142);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 57);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::A16.Properties.Resources.dodaj;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(60, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 57);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxKategorija
            // 
            this.comboBoxKategorija.FormattingEnabled = true;
            this.comboBoxKategorija.Location = new System.Drawing.Point(112, 93);
            this.comboBoxKategorija.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxKategorija.Name = "comboBoxKategorija";
            this.comboBoxKategorija.Size = new System.Drawing.Size(125, 21);
            this.comboBoxKategorija.TabIndex = 5;
            // 
            // comboBoxIzlozba
            // 
            this.comboBoxIzlozba.FormattingEnabled = true;
            this.comboBoxIzlozba.Location = new System.Drawing.Point(112, 66);
            this.comboBoxIzlozba.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxIzlozba.Name = "comboBoxIzlozba";
            this.comboBoxIzlozba.Size = new System.Drawing.Size(202, 21);
            this.comboBoxIzlozba.TabIndex = 4;
            // 
            // comboBoxPas
            // 
            this.comboBoxPas.FormattingEnabled = true;
            this.comboBoxPas.Location = new System.Drawing.Point(112, 41);
            this.comboBoxPas.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPas.Name = "comboBoxPas";
            this.comboBoxPas.Size = new System.Drawing.Size(125, 21);
            this.comboBoxPas.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategorija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Izložba";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pas";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.buttonDodaj);
            this.tabPage5.Controls.Add(this.buttonObrisi);
            this.tabPage5.Controls.Add(this.dataGridViewKategorije);
            this.tabPage5.Controls.Add(this.buttonIzmenaKategorije);
            this.tabPage5.Controls.Add(this.textBoxNazivKat);
            this.tabPage5.Controls.Add(this.textBoxIDKat);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(720, 414);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Kategorije pasa";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(45, 121);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(56, 19);
            this.buttonDodaj.TabIndex = 9;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(142, 121);
            this.buttonObrisi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(56, 19);
            this.buttonObrisi.TabIndex = 8;
            this.buttonObrisi.Text = "Obriši";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // dataGridViewKategorije
            // 
            this.dataGridViewKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKategorije.Location = new System.Drawing.Point(33, 156);
            this.dataGridViewKategorije.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewKategorije.Name = "dataGridViewKategorije";
            this.dataGridViewKategorije.RowHeadersWidth = 51;
            this.dataGridViewKategorije.RowTemplate.Height = 24;
            this.dataGridViewKategorije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKategorije.Size = new System.Drawing.Size(284, 241);
            this.dataGridViewKategorije.TabIndex = 7;
            this.dataGridViewKategorije.SelectionChanged += new System.EventHandler(this.dataGridViewKategorije_SelectionChanged);
            // 
            // buttonIzmenaKategorije
            // 
            this.buttonIzmenaKategorije.Location = new System.Drawing.Point(241, 121);
            this.buttonIzmenaKategorije.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIzmenaKategorije.Name = "buttonIzmenaKategorije";
            this.buttonIzmenaKategorije.Size = new System.Drawing.Size(56, 19);
            this.buttonIzmenaKategorije.TabIndex = 6;
            this.buttonIzmenaKategorije.Text = "Izmeni";
            this.buttonIzmenaKategorije.UseVisualStyleBackColor = true;
            this.buttonIzmenaKategorije.Click += new System.EventHandler(this.buttonIzmenaKategorije_Click);
            // 
            // textBoxNazivKat
            // 
            this.textBoxNazivKat.Location = new System.Drawing.Point(123, 81);
            this.textBoxNazivKat.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNazivKat.MaxLength = 10;
            this.textBoxNazivKat.Name = "textBoxNazivKat";
            this.textBoxNazivKat.Size = new System.Drawing.Size(149, 20);
            this.textBoxNazivKat.TabIndex = 4;
            // 
            // textBoxIDKat
            // 
            this.textBoxIDKat.Location = new System.Drawing.Point(123, 58);
            this.textBoxIDKat.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIDKat.Name = "textBoxIDKat";
            this.textBoxIDKat.Size = new System.Drawing.Size(76, 20);
            this.textBoxIDKat.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 81);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Naziv kategorije";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "ID kategorije";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "KATEGORIJE PASA";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.buttonIzadji);
            this.tabPage2.Controls.Add(this.buttonPrikazi);
            this.tabPage2.Controls.Add(this.labelUkupnoTakmicilo);
            this.tabPage2.Controls.Add(this.labelUkupnoPrijavljeno);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.comboBoxIzlozba2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(720, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Statistika";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 172);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(304, 235);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(413, 182);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(304, 229);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sifra";
            this.columnHeader1.Width = 56;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime psa";
            this.columnHeader2.Width = 309;
            // 
            // chart1
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(259, 5);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(230, 190);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // buttonIzadji
            // 
            this.buttonIzadji.BackColor = System.Drawing.Color.Teal;
            this.buttonIzadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzadji.ForeColor = System.Drawing.Color.White;
            this.buttonIzadji.Location = new System.Drawing.Point(332, 292);
            this.buttonIzadji.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIzadji.Name = "buttonIzadji";
            this.buttonIzadji.Size = new System.Drawing.Size(69, 42);
            this.buttonIzadji.TabIndex = 11;
            this.buttonIzadji.Text = "IZADJI";
            this.buttonIzadji.UseVisualStyleBackColor = false;
            this.buttonIzadji.Click += new System.EventHandler(this.buttonIzadji_Click);
            // 
            // buttonPrikazi
            // 
            this.buttonPrikazi.BackColor = System.Drawing.Color.Teal;
            this.buttonPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrikazi.ForeColor = System.Drawing.Color.White;
            this.buttonPrikazi.Location = new System.Drawing.Point(332, 214);
            this.buttonPrikazi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrikazi.Name = "buttonPrikazi";
            this.buttonPrikazi.Size = new System.Drawing.Size(69, 42);
            this.buttonPrikazi.TabIndex = 10;
            this.buttonPrikazi.Text = "PRIKAŽI";
            this.buttonPrikazi.UseVisualStyleBackColor = false;
            this.buttonPrikazi.Click += new System.EventHandler(this.buttonPrikazi_Click);
            // 
            // labelUkupnoTakmicilo
            // 
            this.labelUkupnoTakmicilo.AutoSize = true;
            this.labelUkupnoTakmicilo.Location = new System.Drawing.Point(25, 92);
            this.labelUkupnoTakmicilo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUkupnoTakmicilo.Name = "labelUkupnoTakmicilo";
            this.labelUkupnoTakmicilo.Size = new System.Drawing.Size(166, 13);
            this.labelUkupnoTakmicilo.TabIndex = 8;
            this.labelUkupnoTakmicilo.Text = "Ukupan broj pasa koji se takmicio";
            // 
            // labelUkupnoPrijavljeno
            // 
            this.labelUkupnoPrijavljeno.AutoSize = true;
            this.labelUkupnoPrijavljeno.Location = new System.Drawing.Point(22, 68);
            this.labelUkupnoPrijavljeno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUkupnoPrijavljeno.Name = "labelUkupnoPrijavljeno";
            this.labelUkupnoPrijavljeno.Size = new System.Drawing.Size(165, 13);
            this.labelUkupnoPrijavljeno.TabIndex = 7;
            this.labelUkupnoPrijavljeno.Text = "Ukupan broj pasa koji je prijavljen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Izložba";
            // 
            // comboBoxIzlozba2
            // 
            this.comboBoxIzlozba2.FormattingEnabled = true;
            this.comboBoxIzlozba2.Location = new System.Drawing.Point(62, 32);
            this.comboBoxIzlozba2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxIzlozba2.Name = "comboBoxIzlozba2";
            this.comboBoxIzlozba2.Size = new System.Drawing.Size(150, 21);
            this.comboBoxIzlozba2.TabIndex = 5;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.richTextBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(720, 414);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "O aplikaciji";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(720, 414);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Izlaz";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(712, 411);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 440);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Prijava na izložbu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorije)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBoxKategorija;
        private System.Windows.Forms.ComboBox comboBoxIzlozba;
        private System.Windows.Forms.ComboBox comboBoxPas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxIzlozba2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonIzadji;
        private System.Windows.Forms.Button buttonPrikazi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelUkupnoTakmicilo;
        private System.Windows.Forms.Label labelUkupnoPrijavljeno;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewKategorije;
        private System.Windows.Forms.TextBox textBoxNazivKat;
        private System.Windows.Forms.TextBox textBoxIDKat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonIzmenaKategorije;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

