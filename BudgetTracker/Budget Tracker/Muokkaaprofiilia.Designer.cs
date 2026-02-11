namespace Budget_Tracker
{
    partial class Muokkaaprofiilia
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
            tbUnimi = new TextBox();
            tbUsalasana = new TextBox();
            tbBudjetti = new TextBox();
            tbVsalasana = new TextBox();
            groupBox1 = new GroupBox();
            btnTallenna = new Button();
            label5 = new Label();
            cbProfiili = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            valikkoToolStripMenuItem = new ToolStripMenuItem();
            takaisinToolStripMenuItem = new ToolStripMenuItem();
            suljeToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tbUnimi
            // 
            tbUnimi.Location = new Point(109, 149);
            tbUnimi.Name = "tbUnimi";
            tbUnimi.Size = new Size(125, 27);
            tbUnimi.TabIndex = 0;
            // 
            // tbUsalasana
            // 
            tbUsalasana.Location = new Point(353, 210);
            tbUsalasana.Name = "tbUsalasana";
            tbUsalasana.Size = new Size(125, 27);
            tbUsalasana.TabIndex = 1;
            // 
            // tbBudjetti
            // 
            tbBudjetti.Location = new Point(109, 210);
            tbBudjetti.Name = "tbBudjetti";
            tbBudjetti.Size = new Size(125, 27);
            tbBudjetti.TabIndex = 2;
            // 
            // tbVsalasana
            // 
            tbVsalasana.Location = new Point(353, 149);
            tbVsalasana.Name = "tbVsalasana";
            tbVsalasana.Size = new Size(125, 27);
            tbVsalasana.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTallenna);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbProfiili);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbVsalasana);
            groupBox1.Controls.Add(tbUnimi);
            groupBox1.Controls.Add(tbBudjetti);
            groupBox1.Controls.Add(tbUsalasana);
            groupBox1.Location = new Point(12, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(484, 407);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // btnTallenna
            // 
            btnTallenna.Location = new Point(165, 269);
            btnTallenna.Name = "btnTallenna";
            btnTallenna.Size = new Size(156, 86);
            btnTallenna.TabIndex = 10;
            btnTallenna.Text = "Tallenna";
            btnTallenna.UseVisualStyleBackColor = true;
            btnTallenna.Click += btnTallenna_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 93);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 9;
            label5.Text = "Valitse Profiili:";
            // 
            // cbProfiili
            // 
            cbProfiili.FormattingEnabled = true;
            cbProfiili.Location = new Point(129, 90);
            cbProfiili.Name = "cbProfiili";
            cbProfiili.Size = new Size(105, 28);
            cbProfiili.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 210);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 7;
            label4.Text = "Uusi Salasana:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 213);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 6;
            label3.Text = "Uusi Budjetti:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 149);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 5;
            label2.Text = "Vanha Salasana:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 149);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 4;
            label1.Text = "Uusi Nimi:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { valikkoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(508, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // valikkoToolStripMenuItem
            // 
            valikkoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { takaisinToolStripMenuItem, suljeToolStripMenuItem });
            valikkoToolStripMenuItem.Name = "valikkoToolStripMenuItem";
            valikkoToolStripMenuItem.Size = new Size(70, 24);
            valikkoToolStripMenuItem.Text = "Valikko";
            // 
            // takaisinToolStripMenuItem
            // 
            takaisinToolStripMenuItem.Name = "takaisinToolStripMenuItem";
            takaisinToolStripMenuItem.Size = new Size(143, 26);
            takaisinToolStripMenuItem.Text = "Takaisin";
            takaisinToolStripMenuItem.Click += takaisinToolStripMenuItem_Click;
            // 
            // suljeToolStripMenuItem
            // 
            suljeToolStripMenuItem.Name = "suljeToolStripMenuItem";
            suljeToolStripMenuItem.Size = new Size(143, 26);
            suljeToolStripMenuItem.Text = "Sulje";
            suljeToolStripMenuItem.Click += suljeToolStripMenuItem_Click;
            // 
            // Muokkaaprofiilia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 450);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Muokkaaprofiilia";
            Text = "Muokkaaprofiilia";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUnimi;
        private TextBox tbUsalasana;
        private TextBox tbBudjetti;
        private TextBox tbVsalasana;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private ComboBox cbProfiili;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem valikkoToolStripMenuItem;
        private ToolStripMenuItem takaisinToolStripMenuItem;
        private ToolStripMenuItem suljeToolStripMenuItem;
        private Button btnTallenna;
    }
}