using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random value = new Random();
            listBox1.Items.Clear();

            try { 
                int[] pole = new int[Convert.ToInt32(textBox2.Text)];

                int pocet = Convert.ToInt32(textBox1.Text);

                for (int i = 0; i < pocet; i++) {
                    pole[i] = value.Next(1, 21);
                    listBox1.Items.Add(pole[i]);
                }
                int mocnina = pole[5];
                int first_number = pole[0];

                for (int i = 2; i < mocnina; i++) {
                    try { 
                    first_number *= mocnina;
                    }
                    catch (OverflowException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                MessageBox.Show(String.Format($"{first_number}"));

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
          

        }
    }
}
