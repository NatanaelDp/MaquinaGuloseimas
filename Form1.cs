using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MáquinaDeGuloseimas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            double valor1 = 5.00;
            double valor2 = 6.00;
            double valor3 = 7.00;
            double valor = double.Parse(txtInfo.Text);

            double conta = valor - valor1;
            double contal = valor - valor2;
            double conta2 = valor - valor3;

            if (valor==valor1||valor==valor2 ||valor==valor3)

                MessageBox.Show("Produto adquirido"); 

            else
            {
                MessageBox.Show("DINHEIRO INSUFICIENTE");


            }
        }
           
    }
}
