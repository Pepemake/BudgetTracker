namespace Budget_Tracker
{
    partial class Kirjautuminen
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
            lbMenu = new Label();
            btnKirjaudu = new Button();
            btnSulje = new Button();
            btnLuoprofiili = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            cbKayttajat = new ComboBox();
            groupBox1 = new GroupBox();
            btnMuokkaa = new Button();
            lblBudjetti = new Label();
            tbBudjetti = new TextBox();
            btnPoistaprofiili = new Button();
            btnNayta = new Button();
            tbProfiilisalasana = new TextBox();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbMenu
            // 
            lbMenu.AutoSize = true;
            lbMenu.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMenu.Location = new Point(183, 56);
            lbMenu.Name = "lbMenu";
            lbMenu.Size = new Size(428, 81);
            lbMenu.TabIndex = 0;
            lbMenu.Text = "Budget Tracker";
            // 
            // btnKirjaudu
            // 
            btnKirjaudu.Location = new Point(7, 25);
            btnKirjaudu.Margin = new Padding(3, 4, 3, 4);
            btnKirjaudu.Name = "btnKirjaudu";
            btnKirjaudu.Size = new Size(160, 83);
            btnKirjaudu.TabIndex = 1;
            btnKirjaudu.Text = "Kirjaudu";
            btnKirjaudu.UseVisualStyleBackColor = true;
            btnKirjaudu.Click += btnKirjaudu_Click;
            // 
            // btnSulje
            // 
            btnSulje.Location = new Point(7, 299);
            btnSulje.Margin = new Padding(3, 4, 3, 4);
            btnSulje.Name = "btnSulje";
            btnSulje.Size = new Size(160, 83);
            btnSulje.TabIndex = 4;
            btnSulje.Text = "Sulje";
            btnSulje.UseVisualStyleBackColor = true;
            btnSulje.Click += btnSulje_Click;
            // 
            // btnLuoprofiili
            // 
            btnLuoprofiili.Location = new Point(7, 116);
            btnLuoprofiili.Margin = new Padding(3, 4, 3, 4);
            btnLuoprofiili.Name = "btnLuoprofiili";
            btnLuoprofiili.Size = new Size(78, 83);
            btnLuoprofiili.TabIndex = 5;
            btnLuoprofiili.Text = "Luo Profiili";
            btnLuoprofiili.UseVisualStyleBackColor = true;
            btnLuoprofiili.Click += btnLuoProfiili_Click;
            // 
            // cbKayttajat
            // 
            cbKayttajat.AllowDrop = true;
            cbKayttajat.FormattingEnabled = true;
            cbKayttajat.Location = new Point(198, 29);
            cbKayttajat.Margin = new Padding(3, 4, 3, 4);
            cbKayttajat.Name = "cbKayttajat";
            cbKayttajat.Size = new Size(159, 28);
            cbKayttajat.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMuokkaa);
            groupBox1.Controls.Add(lblBudjetti);
            groupBox1.Controls.Add(tbBudjetti);
            groupBox1.Controls.Add(btnPoistaprofiili);
            groupBox1.Controls.Add(btnNayta);
            groupBox1.Controls.Add(tbProfiilisalasana);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btnKirjaudu);
            groupBox1.Controls.Add(cbKayttajat);
            groupBox1.Controls.Add(btnLuoprofiili);
            groupBox1.Controls.Add(btnSulje);
            groupBox1.Location = new Point(152, 195);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(451, 441);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // btnMuokkaa
            // 
            btnMuokkaa.Location = new Point(86, 116);
            btnMuokkaa.Margin = new Padding(3, 4, 3, 4);
            btnMuokkaa.Name = "btnMuokkaa";
            btnMuokkaa.Size = new Size(81, 83);
            btnMuokkaa.TabIndex = 15;
            btnMuokkaa.Text = "Muokkaa Profiilia";
            btnMuokkaa.UseVisualStyleBackColor = true;
            btnMuokkaa.Click += btnMuokkaa_Click;
            // 
            // lblBudjetti
            // 
            lblBudjetti.AutoSize = true;
            lblBudjetti.Location = new Point(198, 116);
            lblBudjetti.Name = "lblBudjetti";
            lblBudjetti.Size = new Size(64, 20);
            lblBudjetti.TabIndex = 14;
            lblBudjetti.Text = "Budjetti:";
            // 
            // tbBudjetti
            // 
            tbBudjetti.Location = new Point(268, 116);
            tbBudjetti.Name = "tbBudjetti";
            tbBudjetti.Size = new Size(82, 27);
            tbBudjetti.TabIndex = 13;
            tbBudjetti.TextChanged += textBox1_TextChanged;
            // 
            // btnPoistaprofiili
            // 
            btnPoistaprofiili.Location = new Point(7, 208);
            btnPoistaprofiili.Margin = new Padding(3, 4, 3, 4);
            btnPoistaprofiili.Name = "btnPoistaprofiili";
            btnPoistaprofiili.Size = new Size(160, 83);
            btnPoistaprofiili.TabIndex = 12;
            btnPoistaprofiili.Text = "Poista Profiili";
            btnPoistaprofiili.UseVisualStyleBackColor = true;
            btnPoistaprofiili.Click += btnPoistaprofiili_Click;
            // 
            // btnNayta
            // 
            btnNayta.Location = new Point(365, 77);
            btnNayta.Margin = new Padding(3, 4, 3, 4);
            btnNayta.Name = "btnNayta";
            btnNayta.Size = new Size(78, 28);
            btnNayta.TabIndex = 11;
            btnNayta.Text = "Näytä";
            btnNayta.UseVisualStyleBackColor = true;
            btnNayta.Click += btnNayta_Click;
            // 
            // tbProfiilisalasana
            // 
            tbProfiilisalasana.Location = new Point(198, 77);
            tbProfiilisalasana.Margin = new Padding(3, 4, 3, 4);
            tbProfiilisalasana.Name = "tbProfiilisalasana";
            tbProfiilisalasana.Size = new Size(159, 27);
            tbProfiilisalasana.TabIndex = 10;
            tbProfiilisalasana.Text = "Salasana";
            tbProfiilisalasana.UseSystemPasswordChar = true;
            tbProfiilisalasana.Enter += tbProfiilisalasana_Enter;
            // 
            // button3
            // 
            button3.Location = new Point(45, 389);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(85, 36);
            button3.TabIndex = 9;
            button3.Text = "Tekijä";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Kirjautuminen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 684);
            Controls.Add(groupBox1);
            Controls.Add(lbMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Kirjautuminen";
            Text = "Kirjautuminen";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMenu;
        private Button btnKirjaudu;
        private Button btnSulje;
        private Button btnLuoprofiili;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox cbKayttajat;
        private GroupBox groupBox1;
        private Button button3;
        private TextBox tbProfiilisalasana;
        private Button btnNayta;
        private Button btnPoistaprofiili;
        private TextBox tbBudjetti;
        private Label lblBudjetti;
        private Button btnMuokkaa;
    }
}