using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                int n = Convert.ToInt32(textBox2.Text);

                double cisloA = a;

                if (n < 0)
                {
                    n = Math.Abs(n);
                    for (int i = 1; i < n; i++)
                    {
                        a *= cisloA;
                    }
                    if (a != double.PositiveInfinity)
                    {
                        MessageBox.Show($"Cislo {cisloA} na {n} je 1/{a}");
                    }
                    else
                    {
                        MessageBox.Show("Číslo je nekonečné");
                    }
                }
                else
                {
                    for (int i = 1; i < n; i++)
                    {
                        a *= cisloA;
                    }
                    if (a != double.PositiveInfinity)
                    {
                        MessageBox.Show($"Cislo {cisloA} na {n} je {a}");
                    }
                    else
                    {
                        MessageBox.Show("Číslo je nekonečné");
                    }
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Došlo k přetečení datového typu double. Zadejte menší hodnoty.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Chybný formát vstupních dat. Zadejte platné hodnoty.");
            }

        }
    }
}
