using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace idade
{
    public partial class frmidade : Form
    {
        public frmidade()
        {
            InitializeComponent();
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            int idade;
            
            idade = Convert.ToInt32(txtidade.Text);
            if (idade < 18) MessageBox.Show("Você ainda é menor de idade", "Mensagem");
            else MessageBox.Show("Você já é maior de idade", "Mensagem");
        }

        private void btnpeso_Click(object sender, EventArgs e)
        {
            int peso;
            peso = Convert.ToInt32(txtpeso.Text);
                        
            if (peso <= 50)
            { 
                MessageBox.Show("Você abaixo do peso");
            }
            else if(peso >= 51 && peso <= 90)
            {
                MessageBox.Show(" Vovê está no peso ideal");

            }

            else
            {
                MessageBox.Show("Você está acima do peso");
            }

        }
    }
}
