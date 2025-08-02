using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Size tamanho = new Size();
            tamanho.Height = 200;
            tamanho.Width = 400;
            this.Size = tamanho;

            InitializeComponent();
            this.Text = "Victor Gabriel";
            this.Size = new Size(800, 600); //Mesma coisa
            this.ControlBox = false; //Desabilita o botão de fechar, minimizar e maximizar

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Carregando a Form";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.Text = "Clicando na Form";
        }
    }
}
