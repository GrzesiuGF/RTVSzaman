using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szaman
{
    public partial class AddProductWindow : Form
    {
        public string ShortName => shortNameTextBox.Text;
        public string FullName => fullNameTextBox.Text;
        public string Cena => priceTextBox.Text;

        public AddProductWindow()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
