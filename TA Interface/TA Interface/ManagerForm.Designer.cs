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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.QuitButton = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TourInfoButton = new System.Windows.Forms.Button();
            this.AirlineInfo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseTourGridView)).BeginInit();
            this.ManagerMenu.SuspendLayout();
            this.ChooseTourPage.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.ChooseTourPage.Controls.Add(this.panel1);
            this.ChooseTourPage.Controls.Add(this.AirlineInfo);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(16, 3);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(0, 13);
            this.HeaderLabel.TabIndex = 12;
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
            // AirlineInfo
            // 
            this.AirlineInfo.Location = new System.Drawing.Point(599, 406);
            this.AirlineInfo.Name = "AirlineInfo";
            this.AirlineInfo.Size = new System.Drawing.Size(170, 38);
            this.AirlineInfo.TabIndex = 14;
            this.AirlineInfo.Text = "Информация об Авиакомпании";
            this.AirlineInfo.UseVisualStyleBackColor = true;
            this.AirlineInfo.Click += new System.EventHandler(this.AirlineInfo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxCity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxCountry);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(599, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 360);
            this.panel1.TabIndex = 15;
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
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(122, 13);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCountry.TabIndex = 1;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена (рубли)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 7;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Продолжительность";
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
        private System.Windows.Forms.Button AirlineInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label label1;
    }
}