using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeCadastro.Entities;

namespace SistemaDeCadastro
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas;
        public Form1()
        {
            InitializeComponent();

            pessoas = new List<Pessoa>();

            comboEC.Items.Add("Solteiro(a)");
            comboEC.Items.Add("Casado(a)");
            comboEC.Items.Add("Divorciado(a)");
            comboEC.Items.Add("Viúvo(a)");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int index = -1;

            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa.Nome == txtNome.Text)
                {
                    index = pessoas.IndexOf(pessoa);
                    break;
                }

            }

            if (txtNome.Text == "")
            {
                MessageBox.Show("O campo Nome é obrigatório.");
                txtNome.Focus();
                return;
            }

            if (txtTelefone.Text == "(  )      -")
            {
                MessageBox.Show("O campo Telefone é obrigatório.");
                txtTelefone.Focus();
                return;
            }

            char sexo;
            if (radioM.Checked)
            {
                sexo = 'M';
            }
            else if (radioF.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'O';
            }

            Pessoa novaPessoa = new Pessoa();
            novaPessoa.Nome = txtNome.Text;
            novaPessoa.DataNascimento = txtData.Text;
            novaPessoa.EstadoCivil = comboEC.SelectedItem.ToString();
            novaPessoa.Telefone = txtTelefone.Text;
            novaPessoa.CasaPropria = checkCasa.Checked;
            novaPessoa.Veiculo = checkVeiculo.Checked;
            novaPessoa.Sexo = sexo;

            if (index == -1)
            {
                pessoas.Add(novaPessoa);
            }
            else
            {
                pessoas[index] = novaPessoa;
            }

            btnLimpar_Click(btnLimpar, EventArgs.Empty);

            Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int indice = lista.SelectedIndex;

            if (indice == -1)
            {
                MessageBox.Show("Selecione uma pessoa para excluir.");
                return;
            }
            pessoas.RemoveAt(indice);

            Listar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtData.Text = "";
            comboEC.SelectedIndex = 0;
            txtTelefone.Text = "";
            checkCasa.Checked = false;
            checkVeiculo.Checked = false;
            radioF.Checked = false;
            radioM.Checked = false;
            radioO.Checked = false;
            txtNome.Focus();
        }

        private void Listar()
        {
            lista.Items.Clear();

            foreach (Pessoa pessoa in pessoas)
            {
                lista.Items.Add(pessoa.Nome);

            }
        }

        private void lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indice = lista.SelectedIndex;
            Pessoa pessoa = pessoas[indice];

            txtNome.Text = pessoa.Nome;
            txtData.Text = pessoa.DataNascimento;
            comboEC.SelectedItem = pessoa.EstadoCivil;
            txtTelefone.Text = pessoa.Telefone;
            checkCasa.Checked = pessoa.CasaPropria;
            checkVeiculo.Checked = pessoa.Veiculo;
            switch (pessoa.Sexo)
            {
                case 'M':
                    radioM.Checked = true;
                    break;
                case 'F':
                    radioF.Checked = true;
                    break;
                default:
                    radioO.Checked = true;
                    break;
            }
        }
    }
}
