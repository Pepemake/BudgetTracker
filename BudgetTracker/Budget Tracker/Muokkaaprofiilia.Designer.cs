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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(353, 210);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(109, 210);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(353, 149);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(484, 426);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 149);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 5;
            label2.Text = "Vanha Salasana:";
            label2.Click += label2_Click;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 210);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 7;
            label4.Text = "Uusi Salasana:";
            label4.Click += this.label4_Click;
            // 
            // Muokkaaprofiilia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 450);
            Controls.Add(groupBox1);
            Name = "Muokkaaprofiilia";
            Text = "Muokkaaprofiilia";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}