namespace TA_Interface
{
    partial class HeadForm
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
            this.ReportsPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TourOpGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.TablePage = new System.Windows.Forms.TabPage();
            this.QuitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShowButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TableComboBox = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TableNameLabel = new System.Windows.Forms.Label();
            this.GridViewPage1 = new System.Windows.Forms.DataGridView();
            this.Menu = new System.Windows.Forms.TabControl();
            this.ReportsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TourOpGridView)).BeginInit();
            this.TablePage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPage1)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportsPage
            // 
            this.ReportsPage.Controls.Add(this.button1);
            this.ReportsPage.Controls.Add(this.label1);
            this.ReportsPage.Controls.Add(this.TourOpGridView);
            this.ReportsPage.Controls.Add(this.button2);
            this.ReportsPage.Location = new System.Drawing.Point(4, 22);
            this.ReportsPage.Name = "ReportsPage";
            this.ReportsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ReportsPage.Size = new System.Drawing.Size(853, 452);
            this.ReportsPage.TabIndex = 1;
            this.ReportsPage.Text = "Отчеты";
            this.ReportsPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // TourOpGridView
            // 
            this.TourOpGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TourOpGridView.Location = new System.Drawing.Point(34, 54);
            this.TourOpGridView.Name = "TourOpGridView";
            this.TourOpGridView.Size = new System.Drawing.Size(486, 173);
            this.TourOpGridView.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(670, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Удалить запись";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TablePage
            // 
            this.TablePage.Controls.Add(this.QuitButton);
            this.TablePage.Controls.Add(this.panel1);
            this.TablePage.Controls.Add(this.TableNameLabel);
            this.TablePage.Controls.Add(this.GridViewPage1);
            this.TablePage.Location = new System.Drawing.Point(4, 22);
            this.TablePage.Name = "TablePage";
            this.TablePage.Padding = new System.Windows.Forms.Padding(3);
            this.TablePage.Size = new System.Drawing.Size(853, 452);
            this.TablePage.TabIndex = 0;
            this.TablePage.Text = "Таблицы";
            this.TablePage.UseVisualStyleBackColor = true;
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(24, 421);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 10;
            this.QuitButton.Text = "Выйти";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.ShowButton);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.TableComboBox);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(594, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 163);
            this.panel1.TabIndex = 10;
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(64, 124);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowButton.TabIndex = 13;
            this.ShowButton.Text = "Показать";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(154, 124);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TableComboBox
            // 
            this.TableComboBox.FormattingEnabled = true;
            this.TableComboBox.Location = new System.Drawing.Point(76, 6);
            this.TableComboBox.Name = "TableComboBox";
            this.TableComboBox.Size = new System.Drawing.Size(133, 21);
            this.TableComboBox.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Таблица";
            // 
            // TableNameLabel
            // 
            this.TableNameLabel.AutoSize = true;
            this.TableNameLabel.Location = new System.Drawing.Point(24, 10);
            this.TableNameLabel.Name = "TableNameLabel";
            this.TableNameLabel.Size = new System.Drawing.Size(103, 13);
            this.TableNameLabel.TabIndex = 9;
            this.TableNameLabel.Text = "Название таблицы";
            // 
            // GridViewPage1
            // 
            this.GridViewPage1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GridViewPage1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridViewPage1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.GridViewPage1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewPage1.Location = new System.Drawing.Point(24, 32);
            this.GridViewPage1.Name = "GridViewPage1";
            this.GridViewPage1.Size = new System.Drawing.Size(555, 368);
            this.GridViewPage1.TabIndex = 7;
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.TablePage);
            this.Menu.Controls.Add(this.ReportsPage);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.SelectedIndex = 0;
            this.Menu.Size = new System.Drawing.Size(861, 478);
            this.Menu.TabIndex = 8;
            // 
            // HeadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 478);
            this.Controls.Add(this.Menu);
            this.Name = "HeadForm";
            this.Text = "АИС Турагентство: Руководитель";
            this.ReportsPage.ResumeLayout(false);
            this.ReportsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TourOpGridView)).EndInit();
            this.TablePage.ResumeLayout(false);
            this.TablePage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPage1)).EndInit();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage ReportsPage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TourOpGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage TablePage;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox TableComboBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TableNameLabel;
        private System.Windows.Forms.DataGridView GridViewPage1;
        private System.Windows.Forms.TabControl Menu;

    }
}