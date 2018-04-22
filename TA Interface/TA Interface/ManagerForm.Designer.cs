namespace TA_Interface
{
    partial class ManagerForm
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
            this.ChooseTourGridView = new System.Windows.Forms.DataGridView();
            this.ManagerMenu = new System.Windows.Forms.TabControl();
            this.ChooseTourPage = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExtendedSearchButton = new System.Windows.Forms.Button();
            this.numOfTouristsField = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchTourButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TourInfoButton = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ComboBoxCountry = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseTourGridView)).BeginInit();
            this.ManagerMenu.SuspendLayout();
            this.ChooseTourPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfTouristsField)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseTourGridView
            // 
            this.ChooseTourGridView.AllowUserToAddRows = false;
            this.ChooseTourGridView.AllowUserToDeleteRows = false;
            this.ChooseTourGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChooseTourGridView.ColumnHeadersVisible = false;
            this.ChooseTourGridView.Location = new System.Drawing.Point(19, 32);
            this.ChooseTourGridView.Name = "ChooseTourGridView";
            this.ChooseTourGridView.Size = new System.Drawing.Size(574, 360);
            this.ChooseTourGridView.TabIndex = 1;
            // 
            // ManagerMenu
            // 
            this.ManagerMenu.Controls.Add(this.ChooseTourPage);
            this.ManagerMenu.Controls.Add(this.tabPage2);
            this.ManagerMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManagerMenu.Location = new System.Drawing.Point(0, 0);
            this.ManagerMenu.Name = "ManagerMenu";
            this.ManagerMenu.SelectedIndex = 0;
            this.ManagerMenu.Size = new System.Drawing.Size(861, 478);
            this.ManagerMenu.TabIndex = 3;
            // 
            // ChooseTourPage
            // 
            this.ChooseTourPage.Controls.Add(this.label8);
            this.ChooseTourPage.Controls.Add(this.panel1);
            this.ChooseTourPage.Controls.Add(this.TourInfoButton);
            this.ChooseTourPage.Controls.Add(this.HeaderLabel);
            this.ChooseTourPage.Controls.Add(this.QuitButton);
            this.ChooseTourPage.Controls.Add(this.ChooseTourGridView);
            this.ChooseTourPage.Location = new System.Drawing.Point(4, 22);
            this.ChooseTourPage.Name = "ChooseTourPage";
            this.ChooseTourPage.Padding = new System.Windows.Forms.Padding(3);
            this.ChooseTourPage.Size = new System.Drawing.Size(853, 452);
            this.ChooseTourPage.TabIndex = 0;
            this.ChooseTourPage.Text = "Подбор тура";
            this.ChooseTourPage.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(626, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "label8";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.ComboBoxCountry);
            this.panel1.Controls.Add(this.ExtendedSearchButton);
            this.panel1.Controls.Add(this.numOfTouristsField);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.SearchTourButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(599, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 360);
            this.panel1.TabIndex = 15;
            // 
            // ExtendedSearchButton
            // 
            this.ExtendedSearchButton.Location = new System.Drawing.Point(124, 198);
            this.ExtendedSearchButton.Name = "ExtendedSearchButton";
            this.ExtendedSearchButton.Size = new System.Drawing.Size(119, 30);
            this.ExtendedSearchButton.TabIndex = 20;
            this.ExtendedSearchButton.Text = "Расширенный поиск";
            this.ExtendedSearchButton.UseVisualStyleBackColor = true;
            this.ExtendedSearchButton.Click += new System.EventHandler(this.ExtendedSearchButton_Click);
            // 
            // numOfTouristsField
            // 
            this.numOfTouristsField.Location = new System.Drawing.Point(121, 108);
            this.numOfTouristsField.Name = "numOfTouristsField";
            this.numOfTouristsField.Size = new System.Drawing.Size(120, 20);
            this.numOfTouristsField.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Количество туристов";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Дата начала";
            // 
            // SearchTourButton
            // 
            this.SearchTourButton.Location = new System.Drawing.Point(166, 148);
            this.SearchTourButton.Name = "SearchTourButton";
            this.SearchTourButton.Size = new System.Drawing.Size(77, 30);
            this.SearchTourButton.TabIndex = 12;
            this.SearchTourButton.Text = "Найти";
            this.SearchTourButton.UseVisualStyleBackColor = true;
            this.SearchTourButton.Click += new System.EventHandler(this.SearchTourButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата окончания";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Страна";
            // 
            // TourInfoButton
            // 
            this.TourInfoButton.Location = new System.Drawing.Point(404, 409);
            this.TourInfoButton.Name = "TourInfoButton";
            this.TourInfoButton.Size = new System.Drawing.Size(170, 31);
            this.TourInfoButton.TabIndex = 13;
            this.TourInfoButton.Text = "Информация о турах";
            this.TourInfoButton.UseVisualStyleBackColor = true;
            this.TourInfoButton.Click += new System.EventHandler(this.TourInfoButton_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(16, 3);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(0, 13);
            this.HeaderLabel.TabIndex = 12;
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(19, 409);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 11;
            this.QuitButton.Text = "Выйти";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(853, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ComboBoxCountry
            // 
            this.ComboBoxCountry.FormattingEnabled = true;
            this.ComboBoxCountry.Location = new System.Drawing.Point(120, 11);
            this.ComboBoxCountry.Name = "ComboBoxCountry";
            this.ComboBoxCountry.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxCountry.TabIndex = 21;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(120, 77);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker2.TabIndex = 22;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 478);
            this.Controls.Add(this.ManagerMenu);
            this.Name = "ManagerForm";
            this.Text = "АИС Турагентство: Менеджер";
            ((System.ComponentModel.ISupportInitialize)(this.ChooseTourGridView)).EndInit();
            this.ManagerMenu.ResumeLayout(false);
            this.ChooseTourPage.ResumeLayout(false);
            this.ChooseTourPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfTouristsField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ChooseTourGridView;
        private System.Windows.Forms.TabControl ManagerMenu;
        private System.Windows.Forms.TabPage ChooseTourPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button TourInfoButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SearchTourButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numOfTouristsField;
        private System.Windows.Forms.Button ExtendedSearchButton;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ComboBoxCountry;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}