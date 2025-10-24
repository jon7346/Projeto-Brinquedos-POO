using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrinquedoPOO

{
    /*
         Tela que irá realizar o cadastro de um novo brinquedo e exibir a listagem de brinquedos
    -Campos necessários para o cadastro de acordo com as classes de objetos
    -Botão Adicionar: Adicionar um novo registro a listagem
    -Validação de campos Vazio: Deve validar se TODOS os campos foram preenchidos corretamente
    -Validar campo CNPJ: deve possuir somente números e 14 caracteres
    -Validar campo Código de Barras: deve possuir somente números e 13 caracteres
    -Listar todos os registro em uma ListBox
    -No ListBox apresentar o registro da seguinte forma: Código de Barras - Descrição - Categoria - Nome Fabricante
    -Botão Remover: Remover o registro selecionado da listagem
    -Botão Visualizar: Chamar uma nova tela para apresentar todos os dados do registro selecionado

     */
    
    public partial class TelaBrinquedos: Form
    {
        BrinquedoExecução BrinquedoExecucao = new BrinquedoExecução();
        public TelaBrinquedos(BrinquedoExecução brinquedoExecucao)
        {
            InitializeComponent();
            BrinquedoExecucao = brinquedoExecucao;
        }

        public Brinquedos ExtrairBrinquedos()
        {
            return lstBrinquedos.SelectedItem as Brinquedos;
        }

        public void AtualizarLista()
        {
            lstBrinquedos.DataSource = null;
            lstBrinquedos.DataSource = BrinquedoExecucao.ListarBrinquedos();

            lstBrinquedos.DisplayMember = "ConcatenacaoCategoriaNomeFabri";
        }

        string SoNumero(string Texto)
        {

            string resultado = "";
            for (int i = 0; i < Texto.Length; i++)
            {
                if (char.IsDigit(Texto[i]))
                {
                    resultado += Texto[i];
                }
            }
            return resultado;
        }



        
        public bool Validação()


        {
            if (txtCNPJ.Text.Length == 14 && txtCNPJ.Text.All(char.IsDigit))
            {
                if (txtCódigoB.Text.Length == 13 && txtCódigoB.Text.All(char.IsDigit))
                {
                    if (
                     string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                     string.IsNullOrWhiteSpace(txtDescricao.Text) ||
                     string.IsNullOrWhiteSpace(SoNumero(txtCódigoB.Text).ToString()) ||
                     string.IsNullOrWhiteSpace(SoNumero(txtCNPJ.Text).ToString()) ||
                     string.IsNullOrWhiteSpace(txtIdadeMinima.Text) ||
                     string.IsNullOrWhiteSpace(txtNome.Text) ||
                     string.IsNullOrWhiteSpace(txtPreco.Text)
                      )
                 
                    {
                        MessageBox.Show("Todos os campos devem ser preenchidos");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Código de barras invalido");
                    return false;
                }

            }
            else {
                MessageBox.Show("CNPJ invalido");
                return false;
            }
           
           
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (Validação())
            {
                Brinquedos NovoBrinquedo = new Brinquedos();
                NovoBrinquedo.Descricao = txtDescricao.Text;
                NovoBrinquedo.Categoria = txtCategoria.Text;
                NovoBrinquedo.Nome = txtNome.Text;
                NovoBrinquedo.CNPJ =  SoNumero(txtCNPJ.Text).ToString();
                NovoBrinquedo.CodigoDeBarras = txtCódigoB.Text;
                NovoBrinquedo.IdadeMinima = txtIdadeMinima.Text;
                NovoBrinquedo.Preco = decimal.Parse(txtPreco.Text);

                BrinquedoExecucao.Adicionar(NovoBrinquedo);

                AtualizarLista();

            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            BrinquedoExecucao.Remover(ExtrairBrinquedos());
            MessageBox.Show("Brinquedo Removido !!");

            AtualizarLista(); 
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            Form tela = new TelaVisualizacao(ExtrairBrinquedos());
            tela.ShowDialog(); 



            
        }
    }
}
