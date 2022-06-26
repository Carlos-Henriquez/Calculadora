using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double amount1 = 0, amount2 = 0;
        char operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void addNumber(object sender, EventArgs e)
        {
            var button = ((Button)sender);

            if (txtBoxDisplay.Text == "0")
                txtBoxDisplay.Text = "";

            txtBoxDisplay.Text += button.Text;
        
        }

        private void clickOperation(object sender, EventArgs e)
        {
            var button = ((Button)sender);

            amount1 = Convert.ToDouble(txtBoxDisplay.Text);
            operation = Convert.ToChar(button.Tag);

            if (operation == '²')
            {
                amount1 = Math.Pow(amount1, 2);
                txtBoxDisplay.Text = amount1.ToString();
            }
            else if (operation == '√')
            {
                amount1 = Math.Sqrt(amount1);
                txtBoxDisplay.Text = amount1.ToString();
            }
            else
            {
                txtBoxDisplay.Text = "0";
            }
        }

        #region CalculatorFunctions

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //boton de remover
            if (txtBoxDisplay.Text.Length > 1)
            {
                txtBoxDisplay.Text = txtBoxDisplay.Text.Substring(0, txtBoxDisplay.Text.Length - 1);
            }
            else
            {
                txtBoxDisplay.Text = "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //boton de limpiar
            amount1 = 0;
            amount2 = 0;
            operation = '\0';
            txtBoxDisplay.Text = "0";
        }

        private void btnClearError_Click(object sender, EventArgs e)
        {
            //boton de limpiar error
            txtBoxDisplay.Text = "0";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            //boton de punto
            if (!txtBoxDisplay.Text.Contains("."))
            {
                txtBoxDisplay.Text += ".";
            }
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            //boton de negativo
            amount1 = Convert.ToDouble(txtBoxDisplay.Text);
            amount1 *= -1;
            txtBoxDisplay.Text = amount1.ToString();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            //boton de igual
            amount2 = Convert.ToDouble(txtBoxDisplay.Text);

            if (operation == '+')
            {
                txtBoxDisplay.Text = (amount1 + amount2).ToString();
                amount1 = Convert.ToDouble(txtBoxDisplay.Text);
            }

            else if (operation == '-')
            {
                txtBoxDisplay.Text = (amount1 - amount2).ToString();
                amount1 = Convert.ToDouble(txtBoxDisplay.Text);
            }

            else if (operation == '×')
            {
                txtBoxDisplay.Text = (amount1 * amount2).ToString();
                amount1 = Convert.ToDouble(txtBoxDisplay.Text);
            }

            else if (operation == '÷')
            {
                if (txtBoxDisplay.Text != "0")
                {
                    txtBoxDisplay.Text = (amount1 / amount2).ToString();
                    amount1 = Convert.ToDouble(txtBoxDisplay.Text);
                }
                else
                {
                    MessageBox.Show("No se puede dividir entre cero.");
                }
                
            }

            else if (operation == '%')
            {
                txtBoxDisplay.Text = ((amount1 / 100) * amount2).ToString();
                amount1 = Convert.ToDouble(txtBoxDisplay.Text);
            }

        }

        #endregion

    }

    //Por esta calculadora fue creada por Carlos Henriquez 2020-10203
    //Esta calculadora fue programada en ingles para mayor facilidad a la hora de memorizar, nombrar y programar.
}