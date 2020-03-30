using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            float true_wynik = 1000000 / 3;


            int z = int.Parse(z_box.Text);
            Random rnd = new Random();

            double f = 0.0F;
            int o = 0;
            WindowsFormsApp.SingleCount single = new SingleCount();
            bool czy1 = false;
            bool czy2 = false;
            single.X1 = double.Parse(x1_box.Text);
            single.X2 = double.Parse(x2_box.Text);
            for (double j = 10; j < 100000; j = j + 1 )
            {


                f = 0.0F;
                int licz = 0;
                double old_i = 0;
                double n = j;
                for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                {

                    licz += 1;
                    f += (i * i) * (i - old_i);
                    
                    old_i = i;
                };
                if (Math.Floor(f) % z == 0)
                {
                    Console.Out.WriteLine("wartosc f = " + f.ToString() + " " );
                    wynik_box.Text +=  " prostokaty n = " + n.ToString();
                    czy1 = true;
                }
                f = 0.0F;

                n = j;
                old_i = 0;
                for (double i = 0.0F; i <= 100.0; i = i + 100F / n)
                {

                    licz += 1;
                    f += (((i * i) + (old_i * old_i)) / 2) * (i - old_i);

                    old_i = i;
                };

                if (Math.Floor(f) % z == 0)
                {
                    wynik_box.Text += " trapezy n = " + n.ToString();
                    czy2 = true;
                }
                if (czy1 && czy2) 
                {
                    break;
                }
            };
        }
    }
}
