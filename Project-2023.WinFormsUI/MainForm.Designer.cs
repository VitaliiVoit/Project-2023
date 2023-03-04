namespace Project_2023.WinFormsUI
{
    partial class MainForm
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
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(130, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вибрати конвертер";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(54, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Маса";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += ChooseWeightConverter_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Tag = "";
            radioButton1.Text = "Довжина";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += ChooseLengthConverter_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 118);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(209, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(227, 118);
            button1.Name = "button1";
            button1.Size = new Size(90, 45);
            button1.TabIndex = 2;
            button1.Text = "Нове значення";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OpenMeasurementForm_Click;
            // 
            // button2
            // 
            button2.Location = new Point(73, 147);
            button2.Name = "button2";
            button2.Size = new Size(93, 23);
            button2.TabIndex = 3;
            button2.Text = "Конвертувати";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Convert_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 187);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(209, 23);
            textBox2.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Location = new Point(148, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(169, 100);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Система в яку конвертумо";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 47);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(97, 19);
            radioButton4.TabIndex = 7;
            radioButton4.TabStop = true;
            radioButton4.Text = "Не метрична";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += ChooseNoMetricSystem_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Checked = true;
            radioButton3.Location = new Point(6, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(81, 19);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "Метрична";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += ChooseMetricSystem_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 242);
            Controls.Add(groupBox2);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "MainForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
    }
}