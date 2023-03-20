using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                int n = Convert.ToInt32(textBox2.Text);
                int soucet = 0;
                int i = 0;
                int cislo;
                int p = 0;
                while (i < n)
                {
                    try { 
                        cislo = Convert.ToInt32(textBox1.Lines[p]);
                        i++;
                        
                    }
                    catch (FormatException)
                    {
                        continue;
                    }
                    catch (OverflowException)
                    {
                        continue;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Textbox nemá tolik řádků");
                        break;
                    }
                    finally
                    {
                        p++;
                    }
                    soucet += checked(cislo);

                }

                MessageBox.Show(string.Format($"{soucet}"));
            }
            catch (FormatException) 
            {
                MessageBox.Show("Zadej číslo");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Moc velké číslo "+ ex.Message);
            }
        }
    }
}
