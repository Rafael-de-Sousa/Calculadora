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

		#region Teclas com os numeros
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
		}

        private void btnIgual_Click(object sender, EventArgs e)
        {
			switch (operacao)
			{
				case 1:
					a = Convert.ToDouble(txtVisor.Text);
					total = total + a;
					txtVisor.Text = total.ToString();
					a = 0;
					total = 0;
					break;
				case 2:
					a = Convert.ToDouble(txtVisor.Text);
					total = total - a;
					txtVisor.Text = total.ToString();
					a = 0;
					total = 0;
					break;
				case 3:
					a = Convert.ToDouble(txtVisor.Text);
					total = total * a;
					txtVisor.Text = total.ToString();
					a = 0;
					total = 0;
					break;
				case 4:
					a = Convert.ToDouble(txtVisor.Text);
					total = total / a;
					txtVisor.Text = total.ToString();
					a = 0;
					total = 0;
					break;
			}
		}
        #endregion

        #region Operações
        private void btnSoma_Click(object sender, EventArgs e)
		{
			if (txtVisor.Text != String.Empty)
			{
				a = Convert.ToDouble(txtVisor.Text);
				total = total + a;
				txtVisor.Text = String.Empty;
				a = 0;
				operacao = 1;
			}
			else
			{
				MessageBox.Show("Entre com algum valor.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

        private void btnMult_Click(object sender, EventArgs e)
        {
			if (controle == "1" || total == 0)
			{
				a = Convert.ToDouble(txtVisor.Text);
				total = a;
				txtVisor.Text = String.Empty;
				a = 0;
				operacao = 3;
				controle = "2";
			}
			else
			{
				a = Convert.ToDouble(txtVisor.Text);
				total = total * a;
				txtVisor.Text = String.Empty;
				a = 0;
				operacao = 3;
			}
		}

        private void btnDiv_Click(object sender, EventArgs e)
        {
			if (controle == "1" || total == 0)
			{
				a = Convert.ToDouble(txtVisor.Text);
				total = a;
				txtVisor.Text = String.Empty;
				a = 0;
				operacao = 4;
				controle = "2";
			}
			else
			{
				a = Convert.ToDouble(txtVisor.Text);
				total = total / a;
				txtVisor.Text = String.Empty;
				a = 0;
				operacao = 4;
			}
		}

        private void btnPonto_Click(object sender, EventArgs e)
        {
			txtVisor.Text += ".";
		}

        private void btnC_Click(object sender, EventArgs e)
        {
			string n = txtVisor.Text;
			if (txtVisor.Text != String.Empty)
            {
				n = n.Remove(n.Length - 1);
				txtVisor.Text = n;
			}
			
		}

        

        private void btnSub_Click(object sender, EventArgs e)
		{
			if (txtVisor.Text != String.Empty)
			{
				a = Convert.ToDouble(txtVisor.Text);
				total = a - total;
				txtVisor.Text = String.Empty;
				a = 0;
				operacao = 2;
			}
			else
			{
				MessageBox.Show("Entre com algum valor.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		#endregion
	}
}
