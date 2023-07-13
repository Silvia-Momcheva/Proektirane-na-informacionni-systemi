using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HranitelenMagazin
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            new Стоки().ShowDialog();
            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            new Slujiteli().ShowDialog();
            
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            new Prodajbi().ShowDialog();
           
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            new Dostavki().ShowDialog();    
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            new Zaqvki().ShowDialog();
        }
    }
}
