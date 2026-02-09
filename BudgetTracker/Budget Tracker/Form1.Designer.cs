namespace Budget_Tracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            loremToolStripMenuItem = new ToolStripMenuItem();
            kirjauduUlosToolStripMenuItem = new ToolStripMenuItem();
            suljeToolStripMenuItem = new ToolStripMenuItem();
            ipsumToolStripMenuItem = new ToolStripMenuItem();
            graafitToolStripMenuItem = new ToolStripMenuItem();
            tekijäToolStripMenuItem = new ToolStripMenuItem();
            gbMain = new GroupBox();
            dgvTapahtumat = new DataGridView();
            gb2 = new GroupBox();
            tbTapahtuma = new TextBox();
            label4 = new Label();
            label2 = new Label();
            tbMaara = new TextBox();
            tbKuvaus = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            pvm = new Label();
            label1 = new Label();
            cbKategoria = new ComboBox();
            groupBox1 = new GroupBox();
            btnPaivita = new Button();
            btnPoista = new Button();
            btnMuokkaa = new Button();
            btnLisaa = new Button();
            groupBox2 = new GroupBox();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            btnValitse = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            menuStrip1.SuspendLayout();
            gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTapahtumat).BeginInit();
            gb2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { loremToolStripMenuItem, ipsumToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1049, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // loremToolStripMenuItem
            // 
            loremToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kirjauduUlosToolStripMenuItem, suljeToolStripMenuItem });
            loremToolStripMenuItem.Name = "loremToolStripMenuItem";
            loremToolStripMenuItem.Size = new Size(70, 24);
            loremToolStripMenuItem.Text = "Valikko";
            // 
            // kirjauduUlosToolStripMenuItem
            // 
            kirjauduUlosToolStripMenuItem.Name = "kirjauduUlosToolStripMenuItem";
            kirjauduUlosToolStripMenuItem.Size = new Size(180, 26);
            kirjauduUlosToolStripMenuItem.Text = "Kirjaudu Ulos";
            kirjauduUlosToolStripMenuItem.Click += kirjauduUlosToolStripMenuItem_Click;
            // 
            // suljeToolStripMenuItem
            // 
            suljeToolStripMenuItem.Name = "suljeToolStripMenuItem";
            suljeToolStripMenuItem.Size = new Size(180, 26);
            suljeToolStripMenuItem.Text = "Sulje";
            suljeToolStripMenuItem.Click += suljeToolStripMenuItem_Click;
            // 
            // ipsumToolStripMenuItem
            // 
            ipsumToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { graafitToolStripMenuItem, tekijäToolStripMenuItem });
            ipsumToolStripMenuItem.Name = "ipsumToolStripMenuItem";
            ipsumToolStripMenuItem.Size = new Size(96, 24);
            ipsumToolStripMenuItem.Text = "Listätietoja";
            // 
            // graafitToolStripMenuItem
            // 
            graafitToolStripMenuItem.Name = "graafitToolStripMenuItem";
            graafitToolStripMenuItem.Size = new Size(137, 26);
            graafitToolStripMenuItem.Text = "Graafit";
            graafitToolStripMenuItem.Click += graafitToolStripMenuItem_Click;
            // 
            // tekijäToolStripMenuItem
            // 
            tekijäToolStripMenuItem.Name = "tekijäToolStripMenuItem";
            tekijäToolStripMenuItem.Size = new Size(137, 26);
            tekijäToolStripMenuItem.Text = "Tekijä";
            tekijäToolStripMenuItem.Click += tekijäToolStripMenuItem_Click;
            // 
            // gbMain
            // 
            gbMain.Controls.Add(dgvTapahtumat);
            gbMain.Location = new Point(21, 31);
            gbMain.Name = "gbMain";
            gbMain.Size = new Size(459, 432);
            gbMain.TabIndex = 1;
            gbMain.TabStop = false;
            // 
            // dgvTapahtumat
            // 
            dgvTapahtumat.AllowUserToAddRows = false;
            dgvTapahtumat.AllowUserToDeleteRows = false;
            dgvTapahtumat.AllowUserToOrderColumns = true;
            dgvTapahtumat.AllowUserToResizeColumns = false;
            dgvTapahtumat.AllowUserToResizeRows = false;
            dgvTapahtumat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTapahtumat.Location = new Point(6, 16);
            dgvTapahtumat.Name = "dgvTapahtumat";
            dgvTapahtumat.RowHeadersWidth = 51;
            dgvTapahtumat.Size = new Size(448, 411);
            dgvTapahtumat.TabIndex = 0;
            dgvTapahtumat.CellClick += dataGridView1_CellClick;
            // 
            // gb2
            // 
            gb2.Controls.Add(tbTapahtuma);
            gb2.Controls.Add(label4);
            gb2.Controls.Add(label2);
            gb2.Controls.Add(tbMaara);
            gb2.Controls.Add(tbKuvaus);
            gb2.Controls.Add(dateTimePicker1);
            gb2.Controls.Add(label3);
            gb2.Controls.Add(pvm);
            gb2.Controls.Add(label1);
            gb2.Controls.Add(cbKategoria);
            gb2.Location = new Point(520, 31);
            gb2.Name = "gb2";
            gb2.Size = new Size(385, 427);
            gb2.TabIndex = 2;
            gb2.TabStop = false;
            // 
            // tbTapahtuma
            // 
            tbTapahtuma.Location = new Point(93, 44);
            tbTapahtuma.Name = "tbTapahtuma";
            tbTapahtuma.Size = new Size(228, 27);
            tbTapahtuma.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 137);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 11;
            label4.Text = "Kategoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 137);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 10;
            label2.Text = "Määrä:";
            // 
            // tbMaara
            // 
            tbMaara.Location = new Point(222, 134);
            tbMaara.Name = "tbMaara";
            tbMaara.Size = new Size(99, 27);
            tbMaara.TabIndex = 9;
            // 
            // tbKuvaus
            // 
            tbKuvaus.Location = new Point(94, 184);
            tbKuvaus.Margin = new Padding(3, 4, 3, 4);
            tbKuvaus.Multiline = true;
            tbKuvaus.Name = "tbKuvaus";
            tbKuvaus.Size = new Size(231, 204);
            tbKuvaus.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(93, 91);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 184);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 6;
            label3.Text = "Kuvaus:";
            // 
            // pvm
            // 
            pvm.AutoSize = true;
            pvm.Location = new Point(6, 91);
            pvm.Name = "pvm";
            pvm.Size = new Size(88, 20);
            pvm.TabIndex = 5;
            pvm.Text = "Päivämäärä:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 42);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 4;
            label1.Text = "Tapahtuma:";
            // 
            // cbKategoria
            // 
            cbKategoria.FormattingEnabled = true;
            cbKategoria.Location = new Point(93, 134);
            cbKategoria.Name = "cbKategoria";
            cbKategoria.Size = new Size(73, 28);
            cbKategoria.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPaivita);
            groupBox1.Controls.Add(btnPoista);
            groupBox1.Controls.Add(btnMuokkaa);
            groupBox1.Controls.Add(btnLisaa);
            groupBox1.Location = new Point(520, 479);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 125);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Paneeli Ohjain";
            // 
            // btnPaivita
            // 
            btnPaivita.Location = new Point(202, 79);
            btnPaivita.Name = "btnPaivita";
            btnPaivita.Size = new Size(159, 40);
            btnPaivita.TabIndex = 3;
            btnPaivita.Text = "Päivitä";
            btnPaivita.UseVisualStyleBackColor = true;
            btnPaivita.Click += btnPaivita_Click;
            // 
            // btnPoista
            // 
            btnPoista.Location = new Point(37, 79);
            btnPoista.Name = "btnPoista";
            btnPoista.Size = new Size(159, 40);
            btnPoista.TabIndex = 2;
            btnPoista.Text = "Poista";
            btnPoista.UseVisualStyleBackColor = true;
            btnPoista.Click += btnPoista_Click;
            // 
            // btnMuokkaa
            // 
            btnMuokkaa.Location = new Point(202, 26);
            btnMuokkaa.Name = "btnMuokkaa";
            btnMuokkaa.Size = new Size(159, 40);
            btnMuokkaa.TabIndex = 1;
            btnMuokkaa.Text = "Muokkaa";
            btnMuokkaa.UseVisualStyleBackColor = true;
            btnMuokkaa.MouseClick += btnMuokkaa_Click;
            // 
            // btnLisaa
            // 
            btnLisaa.Location = new Point(37, 26);
            btnLisaa.Name = "btnLisaa";
            btnLisaa.Size = new Size(159, 40);
            btnLisaa.TabIndex = 0;
            btnLisaa.Text = "Lisää";
            btnLisaa.UseVisualStyleBackColor = true;
            btnLisaa.Click += btnLisaa_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePicker3);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(btnValitse);
            groupBox2.Location = new Point(27, 479);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(385, 125);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ajanrajaus";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(202, 79);
            dateTimePicker3.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(159, 27);
            dateTimePicker3.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(37, 79);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(159, 27);
            dateTimePicker2.TabIndex = 5;
            // 
            // btnValitse
            // 
            btnValitse.Location = new Point(37, 26);
            btnValitse.Name = "btnValitse";
            btnValitse.Size = new Size(324, 40);
            btnValitse.TabIndex = 0;
            btnValitse.Text = "Valitse";
            btnValitse.UseVisualStyleBackColor = true;
            btnValitse.Click += btnVertaa_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            ClientSize = new Size(1049, 647);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(gb2);
            Controls.Add(gbMain);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1067, 694);
            MinimumSize = new Size(1067, 694);
            Name = "Form1";
            Text = "Budget Tracker";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gbMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTapahtumat).EndInit();
            gb2.ResumeLayout(false);
            gb2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem loremToolStripMenuItem;
        private ToolStripMenuItem ipsumToolStripMenuItem;
        private GroupBox gbMain;
        private GroupBox gb2;
        private DataGridView dgvTapahtumat;
        private ComboBox cbKategoria;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label pvm;
        private TextBox tbKuvaus;
        private TextBox tbMaara;
        private Label label2;
        private Label label4;
        private TextBox tbTapahtuma;
        private GroupBox groupBox1;
        private Button btnPaivita;
        private Button btnPoista;
        private Button btnMuokkaa;
        private Button btnLisaa;
        private GroupBox groupBox2;
        private Button btnValitse;
        private ToolStripMenuItem suljeToolStripMenuItem;
        private ToolStripMenuItem graafitToolStripMenuItem;
        private ToolStripMenuItem tekijäToolStripMenuItem;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ToolStripMenuItem kirjauduUlosToolStripMenuItem;
    }
}
