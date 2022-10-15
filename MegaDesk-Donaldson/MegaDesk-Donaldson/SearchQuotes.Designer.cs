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
            this.searchComboBoxLabel = new System.Windows.Forms.Label();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.FirstNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backMainMenu
            // 
            this.backMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backMainMenu.Location = new System.Drawing.Point(26, 25);
            this.backMainMenu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.backMainMenu.Name = "backMainMenu";
            this.backMainMenu.Size = new System.Drawing.Size(236, 67);
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
            this.searchButton.Location = new System.Drawing.Point(688, 185);
            this.searchButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 44);
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
            this.id,
            this.Material,
            this.height,
            this.width,
            this.depth,
            this.quantity,
            this.TotalCol});
            this.searchGridView.Location = new System.Drawing.Point(46, 241);
            this.searchGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searchGridView.Name = "searchGridView";
            this.searchGridView.RowHeadersWidth = 82;
            this.searchGridView.Size = new System.Drawing.Size(1486, 550);
            this.searchGridView.TabIndex = 18;
            // 
            // searchComboBoxLabel
            // 
            this.searchComboBoxLabel.AutoSize = true;
            this.searchComboBoxLabel.Location = new System.Drawing.Point(124, 194);
            this.searchComboBoxLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.searchComboBoxLabel.Name = "searchComboBoxLabel";
            this.searchComboBoxLabel.Size = new System.Drawing.Size(200, 25);
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
            this.searchComboBox.Location = new System.Drawing.Point(334, 188);
            this.searchComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(338, 33);
            this.searchComboBox.TabIndex = 20;
            this.searchComboBox.Text = "Select Material";
            // 
            // FirstNameCol
            // 
            this.FirstNameCol.HeaderText = "First Name";
            this.FirstNameCol.MinimumWidth = 10;
            this.FirstNameCol.Name = "FirstNameCol";
            this.FirstNameCol.Width = 200;
            // 
            // LastNameCol
            // 
            this.LastNameCol.HeaderText = "Last Name";
            this.LastNameCol.MinimumWidth = 10;
            this.LastNameCol.Name = "LastNameCol";
            this.LastNameCol.Width = 200;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 10;
            this.id.Name = "id";
            this.id.Width = 200;
            // 
            // Material
            // 
            this.Material.HeaderText = "Material";
            this.Material.MinimumWidth = 10;
            this.Material.Name = "Material";
            this.Material.Width = 200;
            // 
            // height
            // 
            this.height.HeaderText = "Height";
            this.height.MinimumWidth = 10;
            this.height.Name = "height";
            this.height.Width = 200;
            // 
            // width
            // 
            this.width.HeaderText = "Width";
            this.width.MinimumWidth = 10;
            this.width.Name = "width";
            this.width.Width = 200;
            // 
            // depth
            // 
            this.depth.HeaderText = "Depth";
            this.depth.MinimumWidth = 10;
            this.depth.Name = "depth";
            this.depth.Width = 200;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 10;
            this.quantity.Name = "quantity";
            this.quantity.Width = 200;
            // 
            // TotalCol
            // 
            this.TotalCol.HeaderText = "Total";
            this.TotalCol.MinimumWidth = 10;
            this.TotalCol.Name = "TotalCol";
            this.TotalCol.Width = 200;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.searchComboBoxLabel);
            this.Controls.Add(this.searchGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.backMainMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn height;
        private System.Windows.Forms.DataGridViewTextBoxColumn width;
        private System.Windows.Forms.DataGridViewTextBoxColumn depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCol;
    }
}