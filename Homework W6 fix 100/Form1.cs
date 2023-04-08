using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_W6
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {      
            
        }

        private void play_Click(object sender, EventArgs e)
        {
            Form2 second = new Form2();
            if (Convert.ToInt32(nyawa.Text) <= 3 )
            {
                MessageBox.Show("Input Higher");
            }
            else if (nyawa.Text == "")
            {
                MessageBox.Show("Please Input");
            }
            else
            {
                Form2.size = Convert.ToInt32(nyawa.Text);
                second.Show();
            }
        }

        private void nyawa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
