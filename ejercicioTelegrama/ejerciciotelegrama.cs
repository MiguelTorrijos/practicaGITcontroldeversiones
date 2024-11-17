using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string textoTelegrama = txtTelegrama.Text.Trim();
            int numPalabras = 0;
            double coste = 0;

            numPalabras = textoTelegrama.Split().Length;
                      
            if (rdbOrdinario.Checked)
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 2.5 + 0.5 * (numPalabras - 10);
                }
            }
            else if (rdbUrgente.Checked)
            {
                if (numPalabras <= 10)
                {
                    coste = 5;
                }
                else
                {
                    coste = 5 + 0.75 * (numPalabras - 10);
                }
            }
            else
            {
                coste = 0;
            }
        txrPrecio.Text = coste.ToString() + " euros.";
        }

    }
}

   