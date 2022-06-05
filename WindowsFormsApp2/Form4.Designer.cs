namespace WindowsFormsApp2
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CentimeterToMeterRadioButton = new System.Windows.Forms.RadioButton();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MeterToKilometerRadioButton = new System.Windows.Forms.RadioButton();
            this.MeterToFootRadioButton = new System.Windows.Forms.RadioButton();
            this.MeterToMileRadioButton = new System.Windows.Forms.RadioButton();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter  Value to Convert:";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(363, 135);
            this.InputTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(707, 49);
            this.InputTextBox.TabIndex = 14;
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
            this.label3.TabIndex = 15;
            this.label3.Text = "Conversion type";
            // 
            // CentimeterToMeterRadioButton
            // 
            this.CentimeterToMeterRadioButton.AutoSize = true;
            this.CentimeterToMeterRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CentimeterToMeterRadioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CentimeterToMeterRadioButton.Location = new System.Drawing.Point(75, 332);
            this.CentimeterToMeterRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CentimeterToMeterRadioButton.Name = "CentimeterToMeterRadioButton";
            this.CentimeterToMeterRadioButton.Size = new System.Drawing.Size(208, 29);
            this.CentimeterToMeterRadioButton.TabIndex = 16;
            this.CentimeterToMeterRadioButton.TabStop = true;
            this.CentimeterToMeterRadioButton.Text = "Centimeter to Meter";
            this.CentimeterToMeterRadioButton.UseVisualStyleBackColor = true;
            this.CentimeterToMeterRadioButton.CheckedChanged += new System.EventHandler(this.CentimeterToMeterRadioButton_CheckedChanged);
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
            this.OutputTextBox.TabIndex = 17;
            this.OutputTextBox.TextChanged += new System.EventHandler(this.OutputTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 542);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Converted Value";
            this.label1.UseWaitCursor = true;
            // 
            // MeterToKilometerRadioButton
            // 
            this.MeterToKilometerRadioButton.AutoSize = true;
            this.MeterToKilometerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeterToKilometerRadioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MeterToKilometerRadioButton.Location = new System.Drawing.Point(75, 372);
            this.MeterToKilometerRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MeterToKilometerRadioButton.Name = "MeterToKilometerRadioButton";
            this.MeterToKilometerRadioButton.Size = new System.Drawing.Size(195, 29);
            this.MeterToKilometerRadioButton.TabIndex = 19;
            this.MeterToKilometerRadioButton.TabStop = true;
            this.MeterToKilometerRadioButton.Text = "Meter to Kilometer";
            this.MeterToKilometerRadioButton.UseVisualStyleBackColor = true;
            this.MeterToKilometerRadioButton.CheckedChanged += new System.EventHandler(this.MeterToKilometerRadioButton_CheckedChanged);
            // 
            // MeterToFootRadioButton
            // 
            this.MeterToFootRadioButton.AutoSize = true;
            this.MeterToFootRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeterToFootRadioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MeterToFootRadioButton.Location = new System.Drawing.Point(75, 412);
            this.MeterToFootRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MeterToFootRadioButton.Name = "MeterToFootRadioButton";
            this.MeterToFootRadioButton.Size = new System.Drawing.Size(152, 29);
            this.MeterToFootRadioButton.TabIndex = 21;
            this.MeterToFootRadioButton.TabStop = true;
            this.MeterToFootRadioButton.Text = "Meter to Foot";
            this.MeterToFootRadioButton.UseVisualStyleBackColor = true;
            this.MeterToFootRadioButton.CheckedChanged += new System.EventHandler(this.MeterToFootRadioButton_CheckedChanged);
            // 
            // MeterToMileRadioButton
            // 
            this.MeterToMileRadioButton.AutoSize = true;
            this.MeterToMileRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeterToMileRadioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MeterToMileRadioButton.Location = new System.Drawing.Point(75, 452);
            this.MeterToMileRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MeterToMileRadioButton.Name = "MeterToMileRadioButton";
            this.MeterToMileRadioButton.Size = new System.Drawing.Size(149, 29);
            this.MeterToMileRadioButton.TabIndex = 22;
            this.MeterToMileRadioButton.TabStop = true;
            this.MeterToMileRadioButton.Text = "Meter to Mile";
            this.MeterToMileRadioButton.UseVisualStyleBackColor = true;
            this.MeterToMileRadioButton.CheckedChanged += new System.EventHandler(this.MeterToMileRadioButton_CheckedChanged);
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
            this.ResetButton.TabIndex = 23;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
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
            this.ConvertButton.TabIndex = 24;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = false;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConvertButton);
            this.groupBox1.Controls.Add(this.ResetButton);
            this.groupBox1.Controls.Add(this.MeterToMileRadioButton);
            this.groupBox1.Controls.Add(this.MeterToFootRadioButton);
            this.groupBox1.Controls.Add(this.MeterToKilometerRadioButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.OutputTextBox);
            this.groupBox1.Controls.Add(this.CentimeterToMeterRadioButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.InputTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(46, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1110, 739);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Length Converter";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1200, 854);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Length Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton CentimeterToMeterRadioButton;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton MeterToKilometerRadioButton;
        private System.Windows.Forms.RadioButton MeterToFootRadioButton;
        private System.Windows.Forms.RadioButton MeterToMileRadioButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}