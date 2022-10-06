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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void backToMainMenu_Click(object sender, EventArgs e)
        {
            Form form = (MainMenu)Tag;
            form.Show();
            Close();
        }
    }
}
