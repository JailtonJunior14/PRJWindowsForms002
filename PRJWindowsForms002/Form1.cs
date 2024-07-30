using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJWindowsForms002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            // Entrada de dados
            double n1 = double.Parse(txtN1.Text);
            double n2 = double.Parse(txtN2.Text);
            
            // Processamento
            double resultado = n1 + n2;
            
            //Saída de dados
            lblResultado.Text = resultado.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpa a TextBox com propriedade
            //lblResultado.Text = "";
            //txtN1.Text = "";
            //txtN2.Text = "";

            //Com clear
            txtN1.Clear();
            txtN2.Clear();
            txtN1.Focus();
            lblResultado.Text = "";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Fecha a aplicação
            Application.Exit();
            //Fecha o Formulario
            this.Close();
        }
    }
}
