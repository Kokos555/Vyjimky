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
                    int a = Convert.ToInt32(textBox1.Text);
                    int n = Convert.ToInt32(textBox2.Text);

                    int cisloA = a;

                    if (n < 0)
                    {
                        n = Math.Abs(n);
                        for (int i = 1; i < n; i++)
                        {
                            a *= cisloA;
                        }
                        MessageBox.Show($"Cislo {cisloA} na {n} je 1/{a}");
                    }
                    else
                    {
                    
                        for (int i = 1; i < n; i++)
                        {
                            try { 
                                 a *= checked(cisloA);
                            } catch (OverflowException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    MessageBox.Show($"Cislo {cisloA} na {n} je {a}");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
