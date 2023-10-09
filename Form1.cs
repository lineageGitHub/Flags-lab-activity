using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flags
{
    public partial class flagsForm : Form
    {
        public flagsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void finlandBtn_Click(object sender, EventArgs e)
        {
            countryNameDisplay.Text = "Finland";
        }

        private void frenchBtn_Click(object sender, EventArgs e)
        {
            countryNameDisplay.Text = "France";
        }

        private void germanBtn_Click(object sender, EventArgs e)
        {
            countryNameDisplay.Text = "Germany";
        }

        private void countryNameDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
