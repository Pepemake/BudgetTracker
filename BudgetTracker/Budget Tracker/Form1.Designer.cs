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
            label4 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
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
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1049, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // loremToolStripMenuItem
            // 
            loremToolStripMenuItem.Name = "loremToolStripMenuItem";
            loremToolStripMenuItem.Size = new Size(65, 24);
            loremToolStripMenuItem.Text = "Lorem";
            // 
            // ipsumToolStripMenuItem
            // 
            ipsumToolStripMenuItem.Name = "ipsumToolStripMenuItem";
            ipsumToolStripMenuItem.Size = new Size(63, 24);
            ipsumToolStripMenuItem.Text = "Ipsum";
            // 
            // gbMain
            // 
            gbMain.Controls.Add(dataGridView1);
            gbMain.Location = new Point(21, 31);
            gbMain.Name = "gbMain";
            gbMain.Size = new Size(459, 432);
            gbMain.TabIndex = 1;
            gbMain.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 16);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(448, 411);
            dataGridView1.TabIndex = 0;
            // 
            // gb2
            // 
            gb2.Controls.Add(label4);
            gb2.Controls.Add(label2);
            gb2.Controls.Add(textBox2);
            gb2.Controls.Add(textBox1);
            gb2.Controls.Add(dateTimePicker1);
            gb2.Controls.Add(label3);
            gb2.Controls.Add(pvm);
            gb2.Controls.Add(label1);
            gb2.Controls.Add(comboBox4);
            gb2.Controls.Add(comboBox1);
            gb2.Location = new Point(520, 31);
            gb2.Name = "gb2";
            gb2.Size = new Size(385, 427);
            gb2.TabIndex = 2;
            gb2.TabStop = false;
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
            // textBox2
            // 
            textBox2.Location = new Point(222, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(99, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 184);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 204);
            textBox1.TabIndex = 8;
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
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(93, 134);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(73, 28);
            comboBox4.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(94, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 28);
            comboBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1049, 647);
            Controls.Add(gb2);
            Controls.Add(gbMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
        private Label label3;
        private Label pvm;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label4;
    }
}
