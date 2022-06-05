namespace WindowsFormsApp2
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GramToKilogramRadioButton = new System.Windows.Forms.RadioButton();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.KilogramToQuintalRadioButton = new System.Windows.Forms.RadioButton();
            this.GramToOunceRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.MilligramToGramRadioButton = new System.Windows.Forms.RadioButton();
            this.QuintalToTonneRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.QuintalToTonneRadioButton);
            this.groupBox1.Controls.Add(this.MilligramToGramRadioButton);
            this.groupBox1.Controls.Add(this.GramToKilogramRadioButton);
            this.groupBox1.Controls.Add(this.InputTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.KilogramToQuintalRadioButton);
            this.groupBox1.Controls.Add(this.GramToOunceRadioButton);
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
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weigth Converter";
            // 
            // GramToKilogramRadioButton
            // 
            this.GramToKilogramRadioButton.AutoSize = true;
            this.GramToKilogramRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GramToKilogramRadioButton.Location = new System.Drawing.Point(75, 412);
            this.GramToKilogramRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GramToKilogramRadioButton.Name = "GramToKilogramRadioButton";
            this.GramToKilogramRadioButton.Size = new System.Drawing.Size(188, 29);
            this.GramToKilogramRadioButton.TabIndex = 15;
            this.GramToKilogramRadioButton.TabStop = true;
            this.GramToKilogramRadioButton.Text = "Gram to Kilogram";
            this.GramToKilogramRadioButton.UseVisualStyleBackColor = true;
            this.GramToKilogramRadioButton.CheckedChanged += new System.EventHandler(this.GramToKilogramRadioButton_CheckedChanged);
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
            // KilogramToQuintalRadioButton
            // 
            this.KilogramToQuintalRadioButton.AutoSize = true;
            this.KilogramToQuintalRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KilogramToQuintalRadioButton.Location = new System.Drawing.Point(75, 452);
            this.KilogramToQuintalRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.KilogramToQuintalRadioButton.Name = "KilogramToQuintalRadioButton";
            this.KilogramToQuintalRadioButton.Size = new System.Drawing.Size(274, 29);
            this.KilogramToQuintalRadioButton.TabIndex = 10;
            this.KilogramToQuintalRadioButton.TabStop = true;
            this.KilogramToQuintalRadioButton.Text = "Kilogram to Quintal (Metric)";
            this.KilogramToQuintalRadioButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.KilogramToQuintalRadioButton.UseVisualStyleBackColor = true;
            this.KilogramToQuintalRadioButton.CheckedChanged += new System.EventHandler(this.KilogramToQuintalRadioButton_CheckedChanged);
            // 
            // GramToOunceRadioButton
            // 
            this.GramToOunceRadioButton.AutoSize = true;
            this.GramToOunceRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GramToOunceRadioButton.Location = new System.Drawing.Point(75, 372);
            this.GramToOunceRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GramToOunceRadioButton.Name = "GramToOunceRadioButton";
            this.GramToOunceRadioButton.Size = new System.Drawing.Size(170, 29);
            this.GramToOunceRadioButton.TabIndex = 8;
            this.GramToOunceRadioButton.TabStop = true;
            this.GramToOunceRadioButton.Text = "Gram to Ounce";
            this.GramToOunceRadioButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.GramToOunceRadioButton.UseVisualStyleBackColor = true;
            this.GramToOunceRadioButton.CheckedChanged += new System.EventHandler(this.GramToOunceRadioButton_CheckedChanged);
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
            this.ConvertButton.TabIndex = 0;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = false;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
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
            this.OutputTextBox.TextChanged += new System.EventHandler(this.OutputTextBox_TextChanged);
            // 
            // MilligramToGramRadioButton
            // 
            this.MilligramToGramRadioButton.AutoSize = true;
            this.MilligramToGramRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MilligramToGramRadioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MilligramToGramRadioButton.Location = new System.Drawing.Point(75, 332);
            this.MilligramToGramRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MilligramToGramRadioButton.Name = "MilligramToGramRadioButton";
            this.MilligramToGramRadioButton.Size = new System.Drawing.Size(188, 29);
            this.MilligramToGramRadioButton.TabIndex = 16;
            this.MilligramToGramRadioButton.TabStop = true;
            this.MilligramToGramRadioButton.Text = "Milligram to Gram";
            this.MilligramToGramRadioButton.UseVisualStyleBackColor = true;
            this.MilligramToGramRadioButton.CheckedChanged += new System.EventHandler(this.MilligramToGramRadioButton_CheckedChanged);
            // 
            // QuintalToTonneRadioButton
            // 
            this.QuintalToTonneRadioButton.AutoSize = true;
            this.QuintalToTonneRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuintalToTonneRadioButton.Location = new System.Drawing.Point(75, 492);
            this.QuintalToTonneRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QuintalToTonneRadioButton.Name = "QuintalToTonneRadioButton";
            this.QuintalToTonneRadioButton.Size = new System.Drawing.Size(254, 29);
            this.QuintalToTonneRadioButton.TabIndex = 17;
            this.QuintalToTonneRadioButton.TabStop = true;
            this.QuintalToTonneRadioButton.Text = "Quintal (Metric) to Tonne";
            this.QuintalToTonneRadioButton.UseVisualStyleBackColor = true;
            this.QuintalToTonneRadioButton.CheckedChanged += new System.EventHandler(this.QuintalToTonneRadioButton_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1200, 854);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Weight Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton GramToKilogramRadioButton;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton KilogramToQuintalRadioButton;
        private System.Windows.Forms.RadioButton GramToOunceRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.RadioButton MilligramToGramRadioButton;
        private System.Windows.Forms.RadioButton QuintalToTonneRadioButton;
    }
}