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
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            this.TouristMenu.SuspendLayout();
            this.OrdersPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(8, 295);
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
            this.OrdersGridView.Location = new System.Drawing.Point(32, 43);
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.Size = new System.Drawing.Size(391, 204);
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
            this.label1.Location = new System.Drawing.Point(29, 17);
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
            this.TouristMenu.Size = new System.Drawing.Size(459, 352);
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
            this.OrdersPage.Size = new System.Drawing.Size(451, 326);
            this.OrdersPage.TabIndex = 0;
            this.OrdersPage.Text = "Мои заказы";
            this.OrdersPage.UseVisualStyleBackColor = true;
            // 
            // TouristInfoTab
            // 
            this.TouristInfoTab.Location = new System.Drawing.Point(4, 22);
            this.TouristInfoTab.Name = "TouristInfoTab";
            this.TouristInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.TouristInfoTab.Size = new System.Drawing.Size(451, 326);
            this.TouristInfoTab.TabIndex = 1;
            this.TouristInfoTab.Text = "Личные данные туристов";
            this.TouristInfoTab.UseVisualStyleBackColor = true;
            // 
            // TouristForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 352);
            this.Controls.Add(this.TouristMenu);
            this.Controls.Add(this.WindowNameLabel);
            this.Name = "TouristForm";
            this.Text = "Форма туриста";
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            this.TouristMenu.ResumeLayout(false);
            this.OrdersPage.ResumeLayout(false);
            this.OrdersPage.PerformLayout();
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
    }
}