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
            this.SuspendLayout();
            // 
            // backMainMenu
            // 
            this.backMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backMainMenu.Location = new System.Drawing.Point(13, 13);
            this.backMainMenu.Name = "backMainMenu";
            this.backMainMenu.Size = new System.Drawing.Size(127, 43);
            this.backMainMenu.TabIndex = 0;
            this.backMainMenu.Text = "Back";
            this.backMainMenu.UseVisualStyleBackColor = true;
            this.backMainMenu.Click += new System.EventHandler(this.backMainMenu_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backMainMenu);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backMainMenu;
    }
}