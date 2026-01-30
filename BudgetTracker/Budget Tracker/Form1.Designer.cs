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
            ipsumToolStripMenuItem = new ToolStripMenuItem();
            gbMain = new GroupBox();
            dataGridView1 = new DataGridView();
            gb2 = new GroupBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            pvm = new Label();
            label1 = new Label();
            comboBox4 = new ComboBox();
            comboBox1 = new ComboBox();
            menuStrip1.SuspendLayout();
            gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gb2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { loremToolStripMenuItem, ipsumToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(918, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // loremToolStripMenuItem
            // 
            loremToolStripMenuItem.Name = "loremToolStripMenuItem";
            loremToolStripMenuItem.Size = new Size(53, 20);
            loremToolStripMenuItem.Text = "Lorem";
            // 
            // ipsumToolStripMenuItem
            // 
            ipsumToolStripMenuItem.Name = "ipsumToolStripMenuItem";
            ipsumToolStripMenuItem.Size = new Size(52, 20);
            ipsumToolStripMenuItem.Text = "Ipsum";
            // 
            // gbMain
            // 
            gbMain.Controls.Add(dataGridView1);
            gbMain.Location = new Point(18, 23);
            gbMain.Margin = new Padding(3, 2, 3, 2);
            gbMain.Name = "gbMain";
            gbMain.Padding = new Padding(3, 2, 3, 2);
            gbMain.Size = new Size(402, 324);
            gbMain.TabIndex = 1;
            gbMain.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 12);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(392, 308);
            dataGridView1.TabIndex = 0;
            // 
            // gb2
            // 
            gb2.Controls.Add(textBox1);
            gb2.Controls.Add(dateTimePicker1);
            gb2.Controls.Add(label4);
            gb2.Controls.Add(label3);
            gb2.Controls.Add(pvm);
            gb2.Controls.Add(label1);
            gb2.Controls.Add(comboBox4);
            gb2.Controls.Add(comboBox1);
            gb2.Location = new Point(455, 23);
            gb2.Margin = new Padding(3, 2, 3, 2);
            gb2.Name = "gb2";
            gb2.Padding = new Padding(3, 2, 3, 2);
            gb2.Size = new Size(353, 320);
            gb2.TabIndex = 2;
            gb2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 138);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 154);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(81, 62);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 104);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 7;
            label4.Text = "Kategoria:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 138);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 6;
            label3.Text = "Kuvaus:";
            // 
            // pvm
            // 
            pvm.AutoSize = true;
            pvm.Location = new Point(6, 68);
            pvm.Name = "pvm";
            pvm.Size = new Size(71, 15);
            pvm.TabIndex = 5;
            pvm.Text = "Päivämäärä:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 22);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 4;
            label1.Text = "Tapahtuma:";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(81, 101);
            comboBox4.Margin = new Padding(3, 2, 3, 2);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(201, 23);
            comboBox4.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(81, 20);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 23);
            comboBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 485);
            Controls.Add(gb2);
            Controls.Add(gbMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gbMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gb2.ResumeLayout(false);
            gb2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem loremToolStripMenuItem;
        private ToolStripMenuItem ipsumToolStripMenuItem;
        private GroupBox gbMain;
        private GroupBox gb2;
        private DataGridView dataGridView1;
        private ComboBox comboBox4;
        private ComboBox comboBox1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label3;
        private Label pvm;
        private TextBox textBox1;
    }
}
