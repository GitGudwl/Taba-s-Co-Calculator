namespace WindowsFormsApp2
{
    partial class Form3
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
            this.ConvertButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CelciusToKelvinRadioButton = new System.Windows.Forms.RadioButton();
            this.FahrenheitToCelciusRadioButton = new System.Windows.Forms.RadioButton();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FahrenheitToKelvinRadioButton = new System.Windows.Forms.RadioButton();
            this.KelvinToCelciusRadioButton = new System.Windows.Forms.RadioButton();
            this.CelciusToFahrenheitRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConvertButton
            // 
            this.ConvertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ConvertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertButton.ForeColor = System.Drawing.Color.Black;
            this.ConvertButton.Location = new System.Drawing.Point(876, 635);
            this.ConvertButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(150, 62);
            this.ConvertButton.TabIndex = 0;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = false;
            this.ConvertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.AccessibleName = "textBoxTwo";
            this.OutputTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.OutputTextBox.Location = new System.Drawing.Point(593, 532);
            this.OutputTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(432, 52);
            this.OutputTextBox.TabIndex = 2;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Red;
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.Black;
            this.ResetButton.Location = new System.Drawing.Point(78, 635);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(145, 62);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CelciusToKelvinRadioButton);
            this.groupBox1.Controls.Add(this.FahrenheitToCelciusRadioButton);
            this.groupBox1.Controls.Add(this.InputTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FahrenheitToKelvinRadioButton);
            this.groupBox1.Controls.Add(this.KelvinToCelciusRadioButton);
            this.groupBox1.Controls.Add(this.CelciusToFahrenheitRadioButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ResetButton);
            this.groupBox1.Controls.Add(this.ConvertButton);
            this.groupBox1.Controls.Add(this.OutputTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(46, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1110, 739);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperature Converter";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CelciusToKelvinRadioButton
            // 
            this.CelciusToKelvinRadioButton.AutoSize = true;
            this.CelciusToKelvinRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelciusToKelvinRadioButton.Location = new System.Drawing.Point(75, 412);
            this.CelciusToKelvinRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CelciusToKelvinRadioButton.Name = "CelciusToKelvinRadioButton";
            this.CelciusToKelvinRadioButton.Size = new System.Drawing.Size(182, 29);
            this.CelciusToKelvinRadioButton.TabIndex = 15;
            this.CelciusToKelvinRadioButton.TabStop = true;
            this.CelciusToKelvinRadioButton.Text = "Celcius to Kelvin";
            this.CelciusToKelvinRadioButton.UseVisualStyleBackColor = true;
            this.CelciusToKelvinRadioButton.CheckedChanged += new System.EventHandler(this.CelciusToKelvinRadioButton_CheckedChanged_1);
            // 
            // FahrenheitToCelciusRadioButton
            // 
            this.FahrenheitToCelciusRadioButton.AutoSize = true;
            this.FahrenheitToCelciusRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FahrenheitToCelciusRadioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FahrenheitToCelciusRadioButton.Location = new System.Drawing.Point(75, 332);
            this.FahrenheitToCelciusRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FahrenheitToCelciusRadioButton.Name = "FahrenheitToCelciusRadioButton";
            this.FahrenheitToCelciusRadioButton.Size = new System.Drawing.Size(221, 29);
            this.FahrenheitToCelciusRadioButton.TabIndex = 14;
            this.FahrenheitToCelciusRadioButton.TabStop = true;
            this.FahrenheitToCelciusRadioButton.Text = "Fahrenheit to Celcius";
            this.FahrenheitToCelciusRadioButton.UseVisualStyleBackColor = true;
            this.FahrenheitToCelciusRadioButton.CheckedChanged += new System.EventHandler(this.FahrenheitToCelciusRadioButton_CheckedChanged);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(363, 135);
            this.InputTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(707, 49);
            this.InputTextBox.TabIndex = 13;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Conversion type";
            // 
            // FahrenheitToKelvinRadioButton
            // 
            this.FahrenheitToKelvinRadioButton.AutoSize = true;
            this.FahrenheitToKelvinRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FahrenheitToKelvinRadioButton.Location = new System.Drawing.Point(75, 492);
            this.FahrenheitToKelvinRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FahrenheitToKelvinRadioButton.Name = "FahrenheitToKelvinRadioButton";
            this.FahrenheitToKelvinRadioButton.Size = new System.Drawing.Size(210, 29);
            this.FahrenheitToKelvinRadioButton.TabIndex = 11;
            this.FahrenheitToKelvinRadioButton.TabStop = true;
            this.FahrenheitToKelvinRadioButton.Text = "Fahrenheit to Kelvin";
            this.FahrenheitToKelvinRadioButton.UseVisualStyleBackColor = true;
            this.FahrenheitToKelvinRadioButton.CheckedChanged += new System.EventHandler(this.FahrenheitToKelvinRadioButton_CheckedChanged);
            // 
            // KelvinToCelciusRadioButton
            // 
            this.KelvinToCelciusRadioButton.AutoSize = true;
            this.KelvinToCelciusRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KelvinToCelciusRadioButton.Location = new System.Drawing.Point(75, 452);
            this.KelvinToCelciusRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.KelvinToCelciusRadioButton.Name = "KelvinToCelciusRadioButton";
            this.KelvinToCelciusRadioButton.Size = new System.Drawing.Size(182, 29);
            this.KelvinToCelciusRadioButton.TabIndex = 10;
            this.KelvinToCelciusRadioButton.TabStop = true;
            this.KelvinToCelciusRadioButton.Text = "Kelvin to Celcius";
            this.KelvinToCelciusRadioButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.KelvinToCelciusRadioButton.UseVisualStyleBackColor = true;
            this.KelvinToCelciusRadioButton.CheckedChanged += new System.EventHandler(this.KelvinToCelciusRadioButton_CheckedChanged);
            // 
            // CelciusToFahrenheitRadioButton
            // 
            this.CelciusToFahrenheitRadioButton.AutoSize = true;
            this.CelciusToFahrenheitRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelciusToFahrenheitRadioButton.Location = new System.Drawing.Point(75, 372);
            this.CelciusToFahrenheitRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CelciusToFahrenheitRadioButton.Name = "CelciusToFahrenheitRadioButton";
            this.CelciusToFahrenheitRadioButton.Size = new System.Drawing.Size(221, 29);
            this.CelciusToFahrenheitRadioButton.TabIndex = 8;
            this.CelciusToFahrenheitRadioButton.TabStop = true;
            this.CelciusToFahrenheitRadioButton.Text = "Celcius to Fahrenheit";
            this.CelciusToFahrenheitRadioButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CelciusToFahrenheitRadioButton.UseVisualStyleBackColor = true;
            this.CelciusToFahrenheitRadioButton.CheckedChanged += new System.EventHandler(this.CelciusToFahrenheitRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 542);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Converted Value";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter  Value to Convert:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1200, 854);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "AssignmentSetA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton FahrenheitToKelvinRadioButton;
        private System.Windows.Forms.RadioButton KelvinToCelciusRadioButton;
        private System.Windows.Forms.RadioButton CelciusToFahrenheitRadioButton;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.RadioButton FahrenheitToCelciusRadioButton;
        private System.Windows.Forms.RadioButton CelciusToKelvinRadioButton;
    }
}

