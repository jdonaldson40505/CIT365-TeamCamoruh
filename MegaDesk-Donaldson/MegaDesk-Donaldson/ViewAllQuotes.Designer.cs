namespace MegaDesk_Donaldson
{
    partial class ViewAllQuotes
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
            this.backToMainMenu = new System.Windows.Forms.Button();
            this.DeskQuoteDataView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DeskQuoteDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // backToMainMenu
            // 
            this.backToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToMainMenu.Location = new System.Drawing.Point(12, 403);
            this.backToMainMenu.Name = "backToMainMenu";
            this.backToMainMenu.Size = new System.Drawing.Size(118, 35);
            this.backToMainMenu.TabIndex = 0;
            this.backToMainMenu.Text = "Back";
            this.backToMainMenu.UseVisualStyleBackColor = true;
            this.backToMainMenu.Click += new System.EventHandler(this.backToMainMenu_Click);
            // 
            // DeskQuoteDataView
            // 
            this.DeskQuoteDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeskQuoteDataView.Location = new System.Drawing.Point(12, 12);
            this.DeskQuoteDataView.Name = "DeskQuoteDataView";
            this.DeskQuoteDataView.RowHeadersWidth = 30;
            this.DeskQuoteDataView.Size = new System.Drawing.Size(776, 385);
            this.DeskQuoteDataView.TabIndex = 1;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeskQuoteDataView);
            this.Controls.Add(this.backToMainMenu);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.DeskQuoteDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backToMainMenu;
        private System.Windows.Forms.DataGridView DeskQuoteDataView;
    }
}