using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Büfe_Satıs_Sistemi_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        Int32 kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Int32 bilet, misir, su, cay,toplam;
            bilet =Convert.ToInt16(textBox1.Text);
            misir =Convert.ToInt16(textBox2.Text);
            su = Convert.ToInt16(textBox3.Text);    
            cay = Convert.ToInt16(textBox4.Text);

            toplam = bilet * 200 + misir * 75 + su * 15 + cay * 30;
            label9.Text=toplam.ToString()+ "TL" ;

            kasatutar = kasatutar + toplam;
           label10.Text=kasatutar.ToString()+ "TL";
            


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text =  "" ;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
    }
}
