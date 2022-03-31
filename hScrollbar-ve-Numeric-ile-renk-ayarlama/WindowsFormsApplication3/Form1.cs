using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int m83kirmizi = int.Parse(numericUpDown1.Value.ToString());
            int m83yesil = int.Parse(numericUpDown2.Value.ToString());
            int m83mavi = int.Parse(numericUpDown3.Value.ToString());
            label4.ForeColor = Color.FromArgb(m83kirmizi, m83mavi, m83yesil);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int m83kirmizi = int.Parse(numericUpDown1.Value.ToString());
            int m83yesil = int.Parse(numericUpDown2.Value.ToString());
            int m83mavi = int.Parse(numericUpDown3.Value.ToString());
            label4.ForeColor = Color.FromArgb(m83kirmizi, m83mavi, m83yesil);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            int m83kirmizi = int.Parse(numericUpDown1.Value.ToString());
            int m83yesil = int.Parse(numericUpDown2.Value.ToString());
            int m83mavi = int.Parse(numericUpDown3.Value.ToString());
            label4.ForeColor = Color.FromArgb(m83kirmizi, m83mavi, m83yesil);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int m83kirmizi = int.Parse(hScrollBar1.Value.ToString());
            int m83yesil = int.Parse(hScrollBar2.Value.ToString());
            int m83mavi = int.Parse(hScrollBar3.Value.ToString());
            groupBox1.BackColor = Color.FromArgb(m83kirmizi, m83mavi, m83yesil);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            int m83kirmizi = int.Parse(hScrollBar1.Value.ToString());
            int m83yesil = int.Parse(hScrollBar2.Value.ToString());
            int m83mavi = int.Parse(hScrollBar3.Value.ToString());
            groupBox1.BackColor = Color.FromArgb(m83kirmizi, m83mavi, m83yesil);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            int m83kirmizi = int.Parse(hScrollBar1.Value.ToString());
            int m83yesil = int.Parse(hScrollBar2.Value.ToString());
            int m83mavi = int.Parse(hScrollBar3.Value.ToString());
            groupBox1.BackColor = Color.FromArgb(m83kirmizi, m83mavi, m83yesil);
        }
    }
}
