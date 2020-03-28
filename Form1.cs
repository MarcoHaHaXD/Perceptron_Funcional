using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace redNeuronal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Inicio();
        }

        List<And> Lista = new List<And>();
        And and;
        double w1, w2, w3, umbral;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int y, a = 0;

        public void Inicio()
        {
            and = new And(-1, -1, -1, -1);
            Lista.Add(and);
            and = new And(-1, -1, 1, -1);
            Lista.Add(and);
            and = new And(-1, 1, -1, -1);
            Lista.Add(and);
            and = new And(-1, 1, 1, -1);
            Lista.Add(and);
            and = new And(1, -1, -1, -1);
            Lista.Add(and);
            and = new And(1, -1, 1, -1);
            Lista.Add(and);
            and = new And(1, 1, -1, -1);
            Lista.Add(and);
            and = new And(1, 1, 1, 1);
            Lista.Add(and);
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            w1 = double.Parse(txt1.Text);
            w2 = double.Parse(txt2.Text);
            w3 = double.Parse(txt3.Text);
            umbral = double.Parse(txt4.Text);

            do
            {

                foreach (And a in Lista)
                {
                    y = (a.Entrada1 * w1 + a.Entrada2 * w2 + a.Entrada3 * w3) + umbral > 0 ? 1 : -1;
                    if (y != a.Salidax)
                    {

                        w1 = w1 + (a.Salidax * a.Entrada1);
                        w2 = w2 + (a.Salidax * a.Entrada2);
                        w3 = w3 + (a.Salidax * a.Entrada3);
                        umbral = umbral + a.Salidax;
                        this.a = 0;

                    }
                    else
                        this.a++;
                }
            } while (a == Lista.Count);
            txt1.Text = w1.ToString();
            txt2.Text = w2.ToString();
            txt3.Text = w3.ToString();
            txt4.Text = umbral.ToString();
            MessageBox.Show("Cambio de valores");
        }
    }
}
