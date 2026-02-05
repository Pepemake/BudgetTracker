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
            lbMenu.Location = new Point(160, 42);
            lbMenu.Name = "lbMenu";
            lbMenu.Size = new Size(343, 65);
            lbMenu.TabIndex = 0;
            lbMenu.Text = "Budget Tracker";
            // 
            // btnKirjaudu
            // 
            btnKirjaudu.Location = new Point(6, 19);
            btnKirjaudu.Name = "btnKirjaudu";
            btnKirjaudu.Size = new Size(140, 62);
            btnKirjaudu.TabIndex = 1;
            btnKirjaudu.Text = "Kirjaudu";
            btnKirjaudu.UseVisualStyleBackColor = true;
            btnKirjaudu.Click += btnKirjaudu_Click;
            // 
            // btnSulje
            // 
            btnSulje.Location = new Point(6, 224);
            btnSulje.Name = "btnSulje";
            btnSulje.Size = new Size(140, 62);
            btnSulje.TabIndex = 4;
            btnSulje.Text = "Sulje";
            btnSulje.UseVisualStyleBackColor = true;
            btnSulje.Click += btnSulje_Click;
            // 
            // btnLuoprofiili
            // 
            btnLuoprofiili.Location = new Point(6, 87);
            btnLuoprofiili.Name = "btnLuoprofiili";
            btnLuoprofiili.Size = new Size(140, 62);
            btnLuoprofiili.TabIndex = 5;
            btnLuoprofiili.Text = "Luo Profiili";
            btnLuoprofiili.UseVisualStyleBackColor = true;
            btnLuoprofiili.Click += btnLuoProfiili_Click;
            // 
            // cbKayttajat
            // 
            cbKayttajat.AllowDrop = true;
            cbKayttajat.FormattingEnabled = true;
            cbKayttajat.Location = new Point(173, 22);
            cbKayttajat.Name = "cbKayttajat";
            cbKayttajat.Size = new Size(140, 23);
            cbKayttajat.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPoistaprofiili);
            groupBox1.Controls.Add(btnNayta);
            groupBox1.Controls.Add(tbProfiilisalasana);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btnKirjaudu);
            groupBox1.Controls.Add(cbKayttajat);
            groupBox1.Controls.Add(btnLuoprofiili);
            groupBox1.Controls.Add(btnSulje);
            groupBox1.Location = new Point(133, 146);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 331);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // btnPoistaprofiili
            // 
            btnPoistaprofiili.Location = new Point(6, 156);
            btnPoistaprofiili.Name = "btnPoistaprofiili";
            btnPoistaprofiili.Size = new Size(140, 62);
            btnPoistaprofiili.TabIndex = 12;
            btnPoistaprofiili.Text = "Poista Profiili";
            btnPoistaprofiili.UseVisualStyleBackColor = true;
            btnPoistaprofiili.Click += btnPoistaprofiili_Click;
            // 
            // btnNayta
            // 
            btnNayta.Location = new Point(319, 58);
            btnNayta.Name = "btnNayta";
            btnNayta.Size = new Size(68, 21);
            btnNayta.TabIndex = 11;
            btnNayta.Text = "Näytä";
            btnNayta.UseVisualStyleBackColor = true;
            btnNayta.Click += btnNayta_Click;
            // 
            // tbProfiilisalasana
            // 
            tbProfiilisalasana.Location = new Point(173, 58);
            tbProfiilisalasana.Name = "tbProfiilisalasana";
            tbProfiilisalasana.Size = new Size(140, 23);
            tbProfiilisalasana.TabIndex = 10;
            tbProfiilisalasana.Text = "Salasana";
            tbProfiilisalasana.UseSystemPasswordChar = true;
            tbProfiilisalasana.Enter += tbProfiilisalasana_Enter;
            // 
            // button3
            // 
            button3.Location = new Point(39, 292);
            button3.Name = "button3";
            button3.Size = new Size(74, 27);
            button3.TabIndex = 9;
            button3.Text = "Tekijä";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Kirjautuminen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 513);
            Controls.Add(groupBox1);
            Controls.Add(lbMenu);
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
    }
}