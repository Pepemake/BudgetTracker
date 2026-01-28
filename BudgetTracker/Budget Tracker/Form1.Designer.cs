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
            label1 = new Label();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
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
            menuStrip1.Size = new Size(804, 28);
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
            gbMain.Size = new Size(460, 432);
            gbMain.TabIndex = 1;
            gbMain.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 16);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(448, 410);
            dataGridView1.TabIndex = 0;
            // 
            // gb2
            // 
            gb2.Controls.Add(label1);
            gb2.Controls.Add(comboBox4);
            gb2.Controls.Add(comboBox3);
            gb2.Controls.Add(comboBox2);
            gb2.Controls.Add(comboBox1);
            gb2.Location = new Point(520, 31);
            gb2.Name = "gb2";
            gb2.Size = new Size(250, 277);
            gb2.TabIndex = 2;
            gb2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 4;
            label1.Text = "Tapahtuma:";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(93, 184);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(151, 28);
            comboBox4.TabIndex = 3;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(93, 135);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(93, 79);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(93, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 500);
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
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label1;
    }
}
