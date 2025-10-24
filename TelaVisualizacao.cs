using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrinquedoPOO
{
    /*
     Tela irá exibir todos os dados do cadastro de brinquedos
    -Todos os campos TextBox devem ser somente leitura
    -Para informação do fabricante usar apenas um TextBox
        */
    public partial class TelaVisualizacao: Form
    {
        Brinquedos brinquedo = new Brinquedos();
        public TelaVisualizacao(Brinquedos brinquedoExucucao)
        {
            InitializeComponent();
            brinquedo = brinquedoExucucao;
        }

        private void TelaVisualizacao_Load(object sender, EventArgs e)
        {
             txtConcatenaFabri.Text = brinquedo.Concatenacao();
             txtCategoria.Text = brinquedo.Categoria;
             txtCódigoB.Text = brinquedo.CodigoDeBarras;
             txtDescricao.Text = brinquedo.Descricao;
             txtIdadeMinima.Text = brinquedo.IdadeMinima;
             txtPreco.Text = brinquedo.Preco.ToString();
        }
    }
}
