namespace MegaDesk_Donaldson
{
    partial class SearchQuotes
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
            this.backMainMenu = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchGridView = new System.Windows.Forms.DataGridView();
            this.FirstNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchComboBoxLabel = new System.Windows.Forms.Label();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backMainMenu
            // 
            this.backMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backMainMenu.Location = new System.Drawing.Point(13, 13);
            this.backMainMenu.Name = "backMainMenu";
            this.backMainMenu.Size = new System.Drawing.Size(118, 35);
            this.backMainMenu.TabIndex = 0;
            this.backMainMenu.Text = "Back";
            this.backMainMenu.UseVisualStyleBackColor = true;
            this.backMainMenu.Click += new System.EventHandler(this.backMainMenu_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchButton.Location = new System.Drawing.Point(344, 96);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchGridView
            // 
            this.searchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstNameCol,
            this.LastNameCol,
            this.TotalCol});
            this.searchGridView.Location = new System.Drawing.Point(65, 136);
            this.searchGridView.Name = "searchGridView";
            this.searchGridView.Size = new System.Drawing.Size(657, 286);
            this.searchGridView.TabIndex = 18;
            // 
            // FirstNameCol
            // 
            this.FirstNameCol.HeaderText = "First Name";
            this.FirstNameCol.Name = "FirstNameCol";
            // 
            // LastNameCol
            // 
            this.LastNameCol.HeaderText = "Last Name";
            this.LastNameCol.Name = "LastNameCol";
            // 
            // TotalCol
            // 
            this.TotalCol.HeaderText = "Total";
            this.TotalCol.Name = "TotalCol";
            // 
            // searchComboBoxLabel
            // 
            this.searchComboBoxLabel.AutoSize = true;
            this.searchComboBoxLabel.Location = new System.Drawing.Point(62, 101);
            this.searchComboBoxLabel.Name = "searchComboBoxLabel";
            this.searchComboBoxLabel.Size = new System.Drawing.Size(99, 13);
            this.searchComboBoxLabel.TabIndex = 19;
            this.searchComboBoxLabel.Text = "Search By Material:";
            // 
            // searchComboBox
            // 
            this.searchComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchComboBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.searchComboBox.Location = new System.Drawing.Point(167, 98);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(171, 21);
            this.searchComboBox.TabIndex = 20;
            this.searchComboBox.Text = "Select Material";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.searchComboBoxLabel);
            this.Controls.Add(this.searchGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.backMainMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.TransparencyKey = System.Drawing.Color.IndianRed;
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backMainMenu;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView searchGridView;
        private System.Windows.Forms.Label searchComboBoxLabel;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCol;
    }
}