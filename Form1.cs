using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
		public double total = 0, a = 0;
		public int operacao;
		public String controle = "1";
		public Form1()
        {
            InitializeComponent();
        }

		# region Teclas com os numeros

        private void btn1_Click(object sender, EventArgs e)
        {
			txtVisor.Text += "1";
		}

        private void btn2_Click(object sender, EventArgs e)
        {
			txtVisor.Text += "2";
		}

        private void btn3_Click(object sender, EventArgs e)
        {
			txtVisor.Text += "3";
		}

        private void btn4_Click(object sender, EventArgs e)
        {
			txtVisor.Text += "4";
		}

        private void btn5_Click(object sender, EventArgs e)
        {
			txtVisor.Text += "5";
		}

        private void btn6_Click(object sender, EventArgs e)
        {
			txtVisor.Text += "6";
		}

        private void btn7_Click(object sender, EventArgs e)
        {
			txtVisor.Text += "7";
		}

        private void btn8_Click(object sender, EventArgs e)
        {
			txtVisor.Text += "8";
		}

        private void btn9_Click(object sender, EventArgs e)
        {
			txtVisor.Text += "9";
		}

        private void btn0_Click(object sender, EventArgs e)
        {
			txtVisor.Text += "0"; 
		}
        #endregion

		# region Teclas especiais
        private void btnVirgula_Click(object sender, EventArgs e)
        {
			txtVisor.Text += ",";
		}

        private void btnDel_Click(object sender, EventArgs e)
        {
			txtVisor.Text = String.Empty;
			total = 0;
			controle = "1";
		}
        #endregion

        
    }
}
