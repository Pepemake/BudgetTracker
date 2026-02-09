namespace Budget_Tracker
{
    partial class Graafit
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartPiirakka = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartKayra = new System.Windows.Forms.DataVisualization.Charting.Chart();
            menuStrip1 = new MenuStrip();
            valikkoToolStripMenuItem = new ToolStripMenuItem();
            takaisinToolStripMenuItem = new ToolStripMenuItem();
            suljeOhjelmaToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)chartPiirakka).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartKayra).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // chartPiirakka
            // 
            chartArea1.Name = "ChartArea1";
            chartPiirakka.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartPiirakka.Legends.Add(legend1);
            chartPiirakka.Location = new Point(47, 54);
            chartPiirakka.Name = "chartPiirakka";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartPiirakka.Series.Add(series1);
            chartPiirakka.Size = new Size(393, 375);
            chartPiirakka.TabIndex = 0;
            chartPiirakka.Text = "chart1";
            // 
            // chartKayra
            // 
            chartArea2.Name = "ChartArea1";
            chartKayra.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartKayra.Legends.Add(legend2);
            chartKayra.Location = new Point(496, 54);
            chartKayra.Name = "chartKayra";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartKayra.Series.Add(series2);
            chartKayra.Size = new Size(389, 375);
            chartKayra.TabIndex = 1;
            chartKayra.Text = "chart2";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { valikkoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1030, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // valikkoToolStripMenuItem
            // 
            valikkoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { takaisinToolStripMenuItem, suljeOhjelmaToolStripMenuItem });
            valikkoToolStripMenuItem.Name = "valikkoToolStripMenuItem";
            valikkoToolStripMenuItem.Size = new Size(70, 24);
            valikkoToolStripMenuItem.Text = "Valikko";
            // 
            // takaisinToolStripMenuItem
            // 
            takaisinToolStripMenuItem.Name = "takaisinToolStripMenuItem";
            takaisinToolStripMenuItem.Size = new Size(224, 26);
            takaisinToolStripMenuItem.Text = "Takaisin";
            takaisinToolStripMenuItem.Click += takaisinToolStripMenuItem_Click;
            // 
            // suljeOhjelmaToolStripMenuItem
            // 
            suljeOhjelmaToolStripMenuItem.Name = "suljeOhjelmaToolStripMenuItem";
            suljeOhjelmaToolStripMenuItem.Size = new Size(224, 26);
            suljeOhjelmaToolStripMenuItem.Text = "Sulje Ohjelma";
            suljeOhjelmaToolStripMenuItem.Click += suljeOhjelmaToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chartKayra);
            groupBox1.Controls.Add(chartPiirakka);
            groupBox1.Location = new Point(42, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(925, 485);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // Graafit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 558);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Graafit";
            Text = "Graafit";
            Load += Graafit_Load;
            ((System.ComponentModel.ISupportInitialize)chartPiirakka).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartKayra).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPiirakka;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKayra;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem valikkoToolStripMenuItem;
        private ToolStripMenuItem takaisinToolStripMenuItem;
        private ToolStripMenuItem suljeOhjelmaToolStripMenuItem;
        private GroupBox groupBox1;
    }
}