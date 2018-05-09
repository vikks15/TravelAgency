namespace TA_Interface
{
    partial class TouristForm
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.OrdersGridView = new System.Windows.Forms.DataGridView();
            this.WindowNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TouristMenu = new System.Windows.Forms.TabControl();
            this.OrdersPage = new System.Windows.Forms.TabPage();
            this.TouristInfoTab = new System.Windows.Forms.TabPage();
            this.TouristGridView = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            this.TouristMenu.SuspendLayout();
            this.OrdersPage.SuspendLayout();
            this.TouristInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TouristGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(21, 269);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGridView.Location = new System.Drawing.Point(21, 43);
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.Size = new System.Drawing.Size(627, 204);
            this.OrdersGridView.TabIndex = 1;
            // 
            // WindowNameLabel
            // 
            this.WindowNameLabel.AutoSize = true;
            this.WindowNameLabel.Location = new System.Drawing.Point(52, 9);
            this.WindowNameLabel.Name = "WindowNameLabel";
            this.WindowNameLabel.Size = new System.Drawing.Size(0, 13);
            this.WindowNameLabel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // TouristMenu
            // 
            this.TouristMenu.Controls.Add(this.OrdersPage);
            this.TouristMenu.Controls.Add(this.TouristInfoTab);
            this.TouristMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TouristMenu.Location = new System.Drawing.Point(0, 0);
            this.TouristMenu.Name = "TouristMenu";
            this.TouristMenu.SelectedIndex = 0;
            this.TouristMenu.Size = new System.Drawing.Size(678, 327);
            this.TouristMenu.TabIndex = 6;
            // 
            // OrdersPage
            // 
            this.OrdersPage.Controls.Add(this.OrdersGridView);
            this.OrdersPage.Controls.Add(this.label1);
            this.OrdersPage.Controls.Add(this.ExitButton);
            this.OrdersPage.Location = new System.Drawing.Point(4, 22);
            this.OrdersPage.Name = "OrdersPage";
            this.OrdersPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersPage.Size = new System.Drawing.Size(670, 301);
            this.OrdersPage.TabIndex = 0;
            this.OrdersPage.Text = "Мои заказы";
            this.OrdersPage.UseVisualStyleBackColor = true;
            // 
            // TouristInfoTab
            // 
            this.TouristInfoTab.Controls.Add(this.SaveButton);
            this.TouristInfoTab.Controls.Add(this.TouristGridView);
            this.TouristInfoTab.Location = new System.Drawing.Point(4, 22);
            this.TouristInfoTab.Name = "TouristInfoTab";
            this.TouristInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.TouristInfoTab.Size = new System.Drawing.Size(670, 296);
            this.TouristInfoTab.TabIndex = 1;
            this.TouristInfoTab.Text = "Личные данные туристов";
            this.TouristInfoTab.UseVisualStyleBackColor = true;
            this.TouristInfoTab.Click += new System.EventHandler(this.TouristInfoTab_Click);
            // 
            // TouristGridView
            // 
            this.TouristGridView.AllowUserToAddRows = false;
            this.TouristGridView.AllowUserToOrderColumns = true;
            this.TouristGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TouristGridView.Location = new System.Drawing.Point(8, 35);
            this.TouristGridView.Name = "TouristGridView";
            this.TouristGridView.Size = new System.Drawing.Size(637, 186);
            this.TouristGridView.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(570, 246);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TouristForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 327);
            this.Controls.Add(this.TouristMenu);
            this.Controls.Add(this.WindowNameLabel);
            this.Name = "TouristForm";
            this.Text = "Форма туриста";
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            this.TouristMenu.ResumeLayout(false);
            this.OrdersPage.ResumeLayout(false);
            this.OrdersPage.PerformLayout();
            this.TouristInfoTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TouristGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView OrdersGridView;
        public System.Windows.Forms.Label WindowNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl TouristMenu;
        private System.Windows.Forms.TabPage OrdersPage;
        private System.Windows.Forms.TabPage TouristInfoTab;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView TouristGridView;
    }
}