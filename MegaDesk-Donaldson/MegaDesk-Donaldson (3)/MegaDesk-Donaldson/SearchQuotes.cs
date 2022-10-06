using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Donaldson
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void backMainMenu_Click(object sender, EventArgs e)
        {
            Form form = (MainMenu)Tag;
            form.Show();
            Close();
        }
    }
}
