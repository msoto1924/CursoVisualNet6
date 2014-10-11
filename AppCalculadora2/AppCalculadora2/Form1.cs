using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadora2
{
    public partial class Form1 : Form
    {
        bool borrado=true, punto=true;
        string operacion;
        double num1, igual, num2;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (borrado)
            {
                txtResultado.Text = "";
                txtResultado.Text = "0";
                borrado = false;
                punto = true;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (borrado)
            {
                txtResultado.Text = "";
                txtResultado.Text = "1";
                borrado = false;
                punto = true;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (borrado)
            {
                txtResultado.Text = "";
                txtResultado.Text = "2";
                borrado = false;
                punto = true;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (borrado)
            {
                txtResultado.Text = "";
                txtResultado.Text = "3";
                borrado = false;
                punto = true;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (borrado)
            {
                txtResultado.Text = "";
                txtResultado.Text = "4";
                borrado = false;
                punto = true;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (borrado)
            {
                txtResultado.Text = "";
                txtResultado.Text = "5";
                borrado = false;
                punto = true;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (borrado)
            {
                txtResultado.Text = "";
                txtResultado.Text = "6";
                borrado = false;
                punto = true;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (borrado)
            {
                txtResultado.Text = "";
                txtResultado.Text = "7";
                borrado = false;
                punto = true;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (borrado)
            {
                txtResultado.Text = "";
                txtResultado.Text = "8";
                borrado = false;
                punto = true;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (borrado)
            {
                txtResultado.Text = "";
                txtResultado.Text = "9";
                borrado = false;
                punto = true;
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "9";
            }
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            operacion = "+";
            borrado = true;
            num1 = double.Parse(txtResultado.Text);
            lbl2Resultado.Text = num1 + " " + operacion;
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            operacion = "-";
            borrado = true;
            num1 = double.Parse(txtResultado.Text);
            lbl2Resultado.Text = num1 + " " + operacion;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operacion = "*";
            borrado = true;
            num1 = double.Parse(txtResultado.Text);
            lbl2Resultado.Text = num1 + " " + operacion;
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            operacion = "/";
            borrado = true;
            num1 = double.Parse(txtResultado.Text);
            lbl2Resultado.Text = num1 + " " + operacion;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtResultado.Text);
            borrado = true;
            lbl2Resultado.Text = " ";
            switch (operacion)
            {
                case "+":
                    igual = num1 + num2;
                    txtResultado.Text = igual.ToString();
                    break;
                case "-":
                    igual = num1 - num2;
                    txtResultado.Text = igual.ToString();
                    break;
                case "*":
                    igual = num1 * num2;
                    txtResultado.Text = igual.ToString();
                    break;
                case "/":
                    igual = num1 / num2;
                    txtResultado.Text = igual.ToString();
                    break;
            }
        }

        private void btnBorrado_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
            borrado = true;
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
         /* if (txtResultado.Text.Length != 12)
              {
              txtResultado.MaxLength = 12;
              }
              else
              {
              txtResultado.Text="Fuera De Rango";
              }
               txtResultado.Text = "Fuera De Rango";*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            borrado=false;
            if (punto == true)
            {
                txtResultado.Text = txtResultado.Text + ",";
                punto = false;
            }
            else
            {
                return;
            }
        }
    }
}
