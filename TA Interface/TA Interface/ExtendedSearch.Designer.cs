namespace TA_Interface
{
    partial class ExtendedSearch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.numOfTouristField = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchTourButton = new System.Windows.Forms.Button();
            this.comboBoxAcType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.preceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.сomboBoxCountry = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfTouristField)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.numOfTouristField);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.SearchTourButton);
            this.panel1.Controls.Add(this.comboBoxAcType);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.preceTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxCity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.сomboBoxCountry);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 289);
            this.panel1.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(122, 178);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // numOfTouristField
            // 
            this.numOfTouristField.Location = new System.Drawing.Point(122, 208);
            this.numOfTouristField.Name = "numOfTouristField";
            this.numOfTouristField.Size = new System.Drawing.Size(120, 20);
            this.numOfTouristField.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Количество туристов";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 147);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Дата начала";
            // 
            // SearchTourButton
            // 
            this.SearchTourButton.Location = new System.Drawing.Point(166, 244);
            this.SearchTourButton.Name = "SearchTourButton";
            this.SearchTourButton.Size = new System.Drawing.Size(77, 30);
            this.SearchTourButton.TabIndex = 12;
            this.SearchTourButton.Text = "Найти";
            this.SearchTourButton.UseVisualStyleBackColor = true;
            this.SearchTourButton.Click += new System.EventHandler(this.SearchTourButton_Click);
            // 
            // comboBoxAcType
            // 
            this.comboBoxAcType.FormattingEnabled = true;
            this.comboBoxAcType.Location = new System.Drawing.Point(122, 76);
            this.comboBoxAcType.Name = "comboBoxAcType";
            this.comboBoxAcType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAcType.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Тип проживания";
            // 
            // preceTextBox
            // 
            this.preceTextBox.Location = new System.Drawing.Point(122, 113);
            this.preceTextBox.Name = "preceTextBox";
            this.preceTextBox.Size = new System.Drawing.Size(121, 20);
            this.preceTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена (рубли)";
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(122, 40);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCity.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Город";
            // 
            // сomboBoxCountry
            // 
            this.сomboBoxCountry.FormattingEnabled = true;
            this.сomboBoxCountry.Location = new System.Drawing.Point(122, 13);
            this.сomboBoxCountry.Name = "сomboBoxCountry";
            this.сomboBoxCountry.Size = new System.Drawing.Size(121, 21);
            this.сomboBoxCountry.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Страна";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Дата окончания";
            // 
            // ExtendedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 303);
            this.Controls.Add(this.panel1);
            this.Name = "ExtendedSearch";
            this.Text = "Расширенный поиск";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfTouristField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numOfTouristField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SearchTourButton;
        private System.Windows.Forms.ComboBox comboBoxAcType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox preceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox сomboBoxCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
    }
}