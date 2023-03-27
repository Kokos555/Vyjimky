using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private bool JeRodneCislo(string datum, out DateTime datum_z_rc, out string zprava)
        {
            
                zprava = string.Format("Správné rodné číslo");
                string rok = datum.Substring(0, 2);
                string mesic = datum.Substring(2, 2);
                string den = datum.Substring(4, 2);
                datum = datum.Remove(6, 1);
            long cislo;
                cislo = Int64.Parse(datum);
                datum_z_rc = DateTime.Now;
            try
            {

                if (cislo % 11 != 0) throw new FormatException();           
                int rokc = Int32.Parse(rok); //Zjistit rok, jestli 2003 nebo 1908
                int mesc = Int32.Parse(mesic);
                int denc = Int32.Parse(den);
                if (mesc > 50)
                {
                    mesc -= 50;
                }
                if (mesc < 1 || mesc > 12)
                {
                    zprava = String.Format("Špatný měsíc");
                    return false;
                }
                int pocetdni = DateTime.DaysInMonth(rokc, mesc);
                if (denc < 1 || denc > pocetdni) throw new FormatException();
                if (rokc < 1900) { 
                    datum_z_rc = new DateTime(rokc + 1900, mesc, denc);
                }
                else
                {
                    datum_z_rc = new DateTime(rokc + 2000, mesc, denc);
                }
                return true;
            }catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rc = textBox1.Text;
            if (JeRodneCislo(rc, out DateTime datum_z_rc, out string zprava))
            {
                MessageBox.Show(string.Format($"Rodné číslo je {rc} a je platné, převedení na datum je to {datum_z_rc:d}"));
            }
        }
    }
}
